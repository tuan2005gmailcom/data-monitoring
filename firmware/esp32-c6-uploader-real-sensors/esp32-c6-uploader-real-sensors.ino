#include <WiFi.h>
#include <WiFiManager.h>
#include <HTTPClient.h>
#include <Wire.h>
#include <DHT.h>
#include <Adafruit_INA219.h>
#include <math.h>

// -----------------------------------------------------------------------------
// Configuration
// -----------------------------------------------------------------------------
const char* API_URL = "https://localhost/esp32-web-monitoring/web/api.php";

// DHT22
constexpr uint8_t DHT_PIN = 4;
constexpr uint8_t DHT_TYPE = DHT22;

// Resistance measurement:
// 3.3 V ---- R_KNOWN ---- GPIO 2 ---- R_UNKNOWN ---- GND
constexpr uint8_t RESISTANCE_ADC_PIN = 2;
constexpr float ADC_SUPPLY_MV = 3300.0f;
constexpr float KNOWN_RESISTOR_OHMS = 10000.0f;  // Change if not 10 kOhm.
constexpr uint8_t ADC_SAMPLE_COUNT = 20;

DHT dht(DHT_PIN, DHT_TYPE);
Adafruit_INA219 ina219;

bool ina219Available = false;

struct Measurements {
  float temperature;
  float humidity;
  float resistance;
  float currentMa;
  bool valid;
};

// Average several ADC samples to reduce noise.
float readAverageAdcMilliVolts() {
  uint32_t totalMv = 0;

  for (uint8_t i = 0; i < ADC_SAMPLE_COUNT; i++) {
    totalMv += analogReadMilliVolts(RESISTANCE_ADC_PIN);
    delay(3);
  }

  return static_cast<float>(totalMv) / ADC_SAMPLE_COUNT;
}

// Formula for:
// 3.3 V ---- R_KNOWN ---- ADC ---- R_UNKNOWN ---- GND
float readUnknownResistanceOhms() {
  const float voltageMv = readAverageAdcMilliVolts();

  // Near 0 V: unknown resistance is approximately 0 ohm.
  if (voltageMv <= 1.0f) {
    return 0.0f;
  }

  // Near 3.3 V: open circuit or resistance too large to measure reliably.
  if (voltageMv >= ADC_SUPPLY_MV - 1.0f) {
    return NAN;
  }

  return KNOWN_RESISTOR_OHMS * voltageMv / (ADC_SUPPLY_MV - voltageMv);
}

Measurements readMeasurements() {
  Measurements data{};

  data.temperature = dht.readTemperature();
  data.humidity = dht.readHumidity();
  data.resistance = readUnknownResistanceOhms();
  data.currentMa = ina219Available ? ina219.getCurrent_mA() : NAN;

  data.valid =
    !isnan(data.temperature) &&
    !isnan(data.humidity) &&
    !isnan(data.resistance) &&
    !isnan(data.currentMa);

  return data;
}

bool connectToWiFi() {
  WiFi.mode(WIFI_STA);

  WiFiManager manager;
  // If no saved network is available, the ESP32 creates this configuration AP.
  return manager.autoConnect("ESP32-Supervisor", "esp32setup");
}

void printMeasurements(const Measurements& data) {
  Serial.printf("Temperature: %.2f °C\n", data.temperature);
  Serial.printf("Humidity: %.2f %%\n", data.humidity);
  Serial.printf("Resistance: %.2f ohm\n", data.resistance);
  Serial.printf("Current: %.3f mA\n", data.currentMa);
}

void sendMeasurements(const Measurements& data) {
  if (!data.valid) {
    Serial.println("Invalid sensor reading; HTTP transmission cancelled.");
    return;
  }

  if (WiFi.status() != WL_CONNECTED) {
    Serial.println("Wi-Fi unavailable");
    return;
  }

  String url = String(API_URL)
    + "?t=" + String(data.temperature, 2)
    + "&h=" + String(data.humidity, 2)
    + "&r=" + String(data.resistance, 6)
    + "&c=" + String(data.currentMa, 5);

  WiFiClient client;
  HTTPClient http;

  if (!http.begin(client, url)) {
    Serial.println("Unable to initialize HTTP connection.");
    return;
  }

  const int statusCode = http.GET();

  if (statusCode > 0) {
    Serial.printf("HTTP status: %d\n", statusCode);
    Serial.println(http.getString());
  } else {
    Serial.printf("HTTP error: %s\n", http.errorToString(statusCode).c_str());
  }

  http.end();
}

void setup() {
  Serial.begin(115200);
  delay(300);

  dht.begin();

  analogReadResolution(12);
  analogSetPinAttenuation(RESISTANCE_ADC_PIN, ADC_11db);

  // Uses the board's default SDA/SCL pins.
  Wire.begin();

  ina219Available = ina219.begin();
  if (!ina219Available) {
    Serial.println("INA219 not detected. Check SDA, SCL, power and I2C address.");
  }

  if (!connectToWiFi()) {
    Serial.println("Wi-Fi connection failed. Restarting...");
    delay(3000);
    ESP.restart();
  }

  Serial.print("Connected. Local IP: ");
  Serial.println(WiFi.localIP());
}

void loop() {
  const Measurements data = readMeasurements();
  printMeasurements(data);
  sendMeasurements(data);

  // DHT22 should not be read more frequently than about once every 2 seconds.
  delay(5000);
}

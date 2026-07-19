// Firmware ESP32-C6 pour l'interface C# Windows Forms.
// Mesures réelles :
// - DHT22 sur GPIO 4
// - INA219 sur le bus I2C
// - Pont diviseur de résistance sur GPIO 2

#include <Wire.h>
#include <DHT.h>
#include <Adafruit_INA219.h>
#include <math.h>

constexpr unsigned long SERIAL_BAUDRATE = 19200;

// -----------------------------------------------------------------------------
// Capteurs
// -----------------------------------------------------------------------------

constexpr uint8_t DHT_PIN = 4;
constexpr uint8_t DHT_TYPE = DHT22;

// Câblage du pont diviseur:
// 3.3 V ---- R_KNOWN ---- GPIO 2 ---- R_UNKNOWN ---- GND
constexpr uint8_t RESISTANCE_ADC_PIN = 2;
constexpr float ADC_SUPPLY_MV = 3300.0f;
constexpr float KNOWN_RESISTOR_OHMS = 10000.0f;  // Modifier si différente.
constexpr uint8_t ADC_SAMPLE_COUNT = 20;

DHT dht(DHT_PIN, DHT_TYPE);
Adafruit_INA219 ina219;
bool ina219Available = false;

// -----------------------------------------------------------------------------
// Historique simple en RAM
// -----------------------------------------------------------------------------

constexpr uint8_t HISTORY_SIZE = 10;

struct Measurement {
  float temperature;
  float humidity;
  float resistance;
  float currentMa;
  unsigned long timestampMs;
  bool valid;
};

Measurement history[HISTORY_SIZE];
uint8_t storedMeasurements = 0;
uint8_t historyReadIndex = 0;

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

  if (voltageMv <= 1.0f) {
    return 0.0f;
  }

  if (voltageMv >= ADC_SUPPLY_MV - 1.0f) {
    return NAN;
  }

  return KNOWN_RESISTOR_OHMS * voltageMv / (ADC_SUPPLY_MV - voltageMv);
}

Measurement readMeasurement() {
  Measurement data{};

  data.temperature = dht.readTemperature();
  data.humidity = dht.readHumidity();
  data.resistance = readUnknownResistanceOhms();
  data.currentMa = ina219Available ? ina219.getCurrent_mA() : NAN;
  data.timestampMs = millis();

  data.valid =
    !isnan(data.temperature) &&
    !isnan(data.humidity) &&
    !isnan(data.resistance) &&
    !isnan(data.currentMa);

  return data;
}

void saveToHistory(const Measurement& data) {
  if (!data.valid) {
    return;
  }

  if (storedMeasurements < HISTORY_SIZE) {
    history[storedMeasurements++] = data;
    return;
  }

  // Shift older records when the RAM history is full.
  for (uint8_t i = 1; i < HISTORY_SIZE; i++) {
    history[i - 1] = history[i];
  }

  history[HISTORY_SIZE - 1] = data;
}

void printMeasurementResponse(const Measurement& data) {
  if (!data.valid) {
    Serial.println("AT+ERROR=SENSOR_READ");
    return;
  }

  // Expected by the C# HMI:
  // AT+M=temperature,humidity,resistance,current
  Serial.print("AT+M=");
  Serial.print(data.temperature, 2);
  Serial.print(',');
  Serial.print(data.humidity, 2);
  Serial.print(',');
  Serial.print(data.resistance, 6);
  Serial.print(',');
  Serial.println(data.currentMa, 5);
}

void printHistoryRecord(const Measurement& data, uint8_t index) {
  // Existing C# format:
  // AT+H=resistance,humidity,temperature,date
  Serial.print("AT+H=");
  Serial.print(data.resistance, 6);
  Serial.print(',');
  Serial.print(data.humidity, 2);
  Serial.print(',');
  Serial.print(data.temperature, 2);
  Serial.print(",RAM+");

  // No RTC is configured, therefore we expose elapsed time since boot.
  Serial.print(data.timestampMs / 1000UL);
  Serial.print("s-");
  Serial.println(index + 1);
}

void setup() {
  Serial.begin(SERIAL_BAUDRATE);
  Serial.setTimeout(100);
  delay(500);

  dht.begin();

  analogReadResolution(12);
  analogSetPinAttenuation(RESISTANCE_ADC_PIN, ADC_11db);

  // Uses the default SDA and SCL pins of the selected ESP32-C6 board.
  Wire.begin();

  ina219Available = ina219.begin();
  if (!ina219Available) {
    Serial.println("AT+ERROR=INA219_NOT_FOUND");
  }
}

void loop() {
  if (!Serial.available()) {
    return;
  }

  String command = Serial.readStringUntil('\n');
  command.trim();

  if (command.length() == 0) {
    return;
  }

  if (command.startsWith("AT+T=")) {
    // The board currently echoes the PC calendar.
    // Add an RTC library later if the date must be stored on the ESP32.
    Serial.println(command);
  }
  else if (command.startsWith("AT+F=")) {
    Serial.println(command);
  }
  else if (command.startsWith("AT+A=")) {
    Serial.println(command);
  }
  else if (command == "AT+M?") {
    const Measurement data = readMeasurement();
    saveToHistory(data);
    printMeasurementResponse(data);
  }
  else if (command == "AT+H?") {
    if (historyReadIndex < storedMeasurements) {
      printHistoryRecord(history[historyReadIndex], historyReadIndex);
      historyReadIndex++;
    } else {
      Serial.println("AT+OK");
      historyReadIndex = 0;
    }
  }
  else if (command == "AT+E?") {
    storedMeasurements = 0;
    historyReadIndex = 0;
    Serial.println("DELETE SUCCESS");
  }
  else {
    Serial.print("UNKNOWN COMMAND: ");
    Serial.println(command);
  }
}

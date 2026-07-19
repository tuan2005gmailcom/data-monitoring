<?php
declare(strict_types=1);

header('Content-Type: application/json; charset=utf-8');
require __DIR__ . '/db.php';

function required_float_parameter(string $name): float
{
    $value = filter_input(INPUT_GET, $name, FILTER_VALIDATE_FLOAT);
    if ($value === false || $value === null) {
        throw new InvalidArgumentException("Invalid or missing parameter: {$name}");
    }
    return (float) $value;
}

function optional_float_parameter(string $name): ?float
{
    $rawValue = filter_input(INPUT_GET, $name, FILTER_UNSAFE_RAW);
    if ($rawValue === null || $rawValue === '') {
        return null;
    }

    $value = filter_var($rawValue, FILTER_VALIDATE_FLOAT);
    if ($value === false) {
        throw new InvalidArgumentException("Invalid parameter: {$name}");
    }
    return (float) $value;
}

try {
    $temperature = required_float_parameter('t');
    $humidity = required_float_parameter('h');
    $resistance = required_float_parameter('r');
    $currentMa = optional_float_parameter('c');

    if ($humidity < 0 || $humidity > 100) {
        throw new InvalidArgumentException('Humidity must be between 0 and 100%.');
    }

    $statement = database()->prepare(
        'INSERT INTO measurements (temperature, humidity, resistance, current_ma)
         VALUES (:temperature, :humidity, :resistance, :current_ma)'
    );
    $statement->execute([
        ':temperature' => $temperature,
        ':humidity' => $humidity,
        ':resistance' => $resistance,
        ':current_ma' => $currentMa,
    ]);

    http_response_code(201);
    echo json_encode([
        'status' => 'success',
        'message' => 'Measurement saved',
    ], JSON_THROW_ON_ERROR);
} catch (InvalidArgumentException $error) {
    http_response_code(400);
    echo json_encode(['status' => 'error', 'message' => $error->getMessage()]);
} catch (Throwable $error) {
    http_response_code(500);
    echo json_encode(['status' => 'error', 'message' => 'Server error']);
}

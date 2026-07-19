<?php
declare(strict_types=1);

header('Content-Type: application/json; charset=utf-8');
require __DIR__ . '/db.php';

try {
    $limit = filter_input(INPUT_GET, 'limit', FILTER_VALIDATE_INT) ?: 50;
    $limit = max(1, min($limit, 500));

    $statement = database()->prepare(
        'SELECT id, temperature, humidity, resistance, current_ma, created_at
         FROM measurements
         ORDER BY created_at DESC, id DESC
         LIMIT :row_limit'
    );
    $statement->bindValue(':row_limit', $limit, PDO::PARAM_INT);
    $statement->execute();

    echo json_encode([
        'status' => 'success',
        'measurements' => $statement->fetchAll(),
    ], JSON_THROW_ON_ERROR);
} catch (Throwable $error) {
    http_response_code(500);
    echo json_encode(['status' => 'error', 'message' => 'Unable to read measurements']);
}

<?php
declare(strict_types=1);

function database(): PDO
{
    $configFile = __DIR__ . '/config.php';
    if (!is_file($configFile)) {
        throw new RuntimeException('Missing web/config.php. Copy config.example.php and configure it.');
    }

    $config = require $configFile;
    $dsn = sprintf(
        'mysql:host=%s;dbname=%s;charset=utf8mb4',
        $config['host'],
        $config['database']
    );

    return new PDO($dsn, $config['user'], $config['password'], [
        PDO::ATTR_ERRMODE => PDO::ERRMODE_EXCEPTION,
        PDO::ATTR_DEFAULT_FETCH_MODE => PDO::FETCH_ASSOC,
        PDO::ATTR_EMULATE_PREPARES => false,
    ]);
}

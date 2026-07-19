# Interface C# Windows Forms

Cette application reprend la démarche du support **C#en.pdf** et transforme le prototype initial en une interface de supervision exploitable sous Visual Studio 2022.

## Fonctions disponibles

- détection des ports COM ;
- sélection du débit série ;
- connexion et déconnexion en 8N1 ;
- indicateur visuel de l’état de la liaison ;
- synchronisation du calendrier de la carte ;
- configuration de la fréquence de mesure ;
- configuration des adresses LoRa ;
- demande d’une mesure instantanée ;
- affichage de la température, de l’humidité, de la résistivité et du courant ;
- téléchargement de l’historique depuis l’EEPROM ;
- consultation directe de la base MySQL ;
- suppression des données EEPROM ou MySQL ;
- export de la grille dans un fichier TXT ou CSV.

## Ouvrir le projet

Ouvre le fichier suivant dans Visual Studio 2022 :

```text
Esp32Supervisor.sln
```

La charge de travail **Développement Desktop .NET** et le **Developer Pack .NET Framework 4.8.1** doivent être installés.

Visual Studio restaure automatiquement le paquet NuGet `MySql.Data`. Si ce n’est pas le cas :

1. ouvre **Outils > Gestionnaire de package NuGet > Gérer les packages NuGet pour la solution** ;
2. recherche `MySql.Data` ;
3. installe-le dans le projet `Esp32Supervisor`.

## Tester la liaison série

Téléverse d’abord le programme suivant dans la carte XIAO ESP32-C6 :

```text
../firmware/esp32-c6-serial-hmi/esp32-c6-serial-hmi.ino
```

Dans l’application :

1. clique sur **SCAN PORT** ;
2. sélectionne le port de la carte ;
3. sélectionne `19200` bauds ;
4. clique sur **CONNECT** ;
5. teste **CALENDAR**, **FREQUENCY**, **ENABLE** et **MEASURE**.

Ne laisse pas le moniteur série Arduino ouvert pendant le test : deux logiciels ne peuvent généralement pas ouvrir le même port COM en même temps.

## Protocole série

| Commande envoyée | Rôle | Exemple de réponse |
|---|---|---|
| `AT+T=dd/MM/yyyy HH:mm:ss` | synchroniser l’heure | écho de la commande |
| `AT+F=1H30` | régler la fréquence | écho de la commande |
| `AT+A=1,100` | régler les adresses LoRa | écho de la commande |
| `AT+M?` | demander une mesure | `AT+M=23.5,54,2.457245,1.65434` |
| `AT+H?` | demander une ligne d’historique | `AT+H=2.23456,54,23.4,24/03/2026 16:34` |
| `AT+OK` | fin de l’historique | aucune autre ligne |
| `AT+E?` | effacer l’EEPROM | `DELETE SUCCESS` |

## Mode base de données

Coche **DATABASE / EEPROM** pour afficher les champs MySQL :

- `HOST` : par exemple `localhost` ;
- `DATABASE` : `esp32_supervision` ;
- `USER` : par exemple `root` ;
- `PSW` : mot de passe MySQL.

L’application lit et supprime les données de la table `measurements` créée par `../database/schema.sql`.

Aucun identifiant réel n’est enregistré dans le dépôt GitHub.

## Générer l’exécutable

Dans Visual Studio 2022 :

1. sélectionne la configuration **Release** ;
2. sélectionne **Any CPU** ou **x64** ;
3. ouvre **Générer > Générer la solution**.

L’exécutable est créé dans :

```text
bin/Release/Esp32Supervisor.exe
```

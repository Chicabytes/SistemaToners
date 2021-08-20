--
-- File generated with SQLiteStudio v3.3.3 on mié. ago. 18 12:01:37 2021
--
-- Text encoding used: System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: Area
CREATE TABLE Area (idArea INT PRIMARY KEY UNIQUE NOT NULL, area STRING UNIQUE NOT NULL);

-- Table: Impresora
CREATE TABLE Impresora (idImpresora INT PRIMARY KEY UNIQUE NOT NULL, area INT REFERENCES Area (idArea) ON DELETE CASCADE ON UPDATE CASCADE NOT NULL, puesto INT UNIQUE, modelo STRING NOT NULL);

-- Table: Toner
CREATE TABLE Toner (idToner INTEGER PRIMARY KEY UNIQUE NOT NULL, modeloT STRING NOT NULL, impresora INT REFERENCES Impresora (idImpresora) ON DELETE CASCADE ON UPDATE CASCADE NOT NULL, fechaCambio DATE NOT NULL, contador STRING NOT NULL);

COMMIT TRANSACTION;
PRAGMA foreign_keys = on;

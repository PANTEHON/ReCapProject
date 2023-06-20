-- Yeni bir veritabanı oluşturma
CREATE DATABASE RecapCarDB;
GO

-- Veritabanını kullanma
USE RecapCarDB;
GO

-- Cars tablosu
CREATE TABLE Cars (
    CarID INT PRIMARY KEY,
    CarName VARCHAR(50),
    BrandID INT,
    ColorID INT
);

-- Brands tablosu
CREATE TABLE Brands (
    BrandID INT PRIMARY KEY,
    BrandName VARCHAR(50)
);

-- Colors tablosu
CREATE TABLE Colors (
    ColorID INT PRIMARY KEY,
    ColorName VARCHAR(50)
);

-- Cars tablosuna veri ekleme
INSERT INTO Cars (CarID, CarName, BrandID, ColorID)
VALUES (1, 'Audi A7', 1, 1),
       (2, 'BMW M3', 2, 4),
       (3, 'BMW M4', 2, 3),
       (4, 'Mercedes-Benz', 3, 2),
       (5, 'Range Rover Evogue', 4, 2);

-- Brands tablosuna veri ekleme
INSERT INTO Brands (BrandID, BrandName)
VALUES (1, 'Audi'),
       (2, 'BMW'),
       (3, 'Mercedes-Benz'),
       (4, 'Range Rover');

-- Colors tablosuna veri ekleme
INSERT INTO Colors (ColorID, ColorName)
VALUES (1, 'Black'),
       (2, 'Grey'),
       (3, 'Red'),
       (4, 'Blue');
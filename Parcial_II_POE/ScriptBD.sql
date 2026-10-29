CREATE DATABASE RegistroNotasPOE;
GO
USE RegistroNotasPOE;
GO

--TABLAS
CREATE TABLE Estudiante (
    Id       INT IDENTITY(1,1) PRIMARY KEY,
    Nombre   NVARCHAR(100) NOT NULL,
    Apellido NVARCHAR(100) NOT NULL,
    Codigo   NVARCHAR(30)  NOT NULL UNIQUE,
    Edad     INT           NOT NULL,
    Carrera  NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE Materia (
    Id      INT IDENTITY(1,1) PRIMARY KEY,
    Ciclo   NVARCHAR(20)  NOT NULL,
    Carrera NVARCHAR(100) NOT NULL,
    Nombre  NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE Nota (
    Id            INT IDENTITY(1,1) PRIMARY KEY,
    IdEstudiante  INT NOT NULL REFERENCES Estudiante(Id),
    IdMateria     INT NOT NULL REFERENCES Materia(Id),
    Laboratorio   DECIMAL(4,2) NULL CHECK (Laboratorio BETWEEN 0 AND 10),
    Parcial       DECIMAL(4,2) NULL CHECK (Parcial     BETWEEN 0 AND 10),
    Asistencia    DECIMAL(4,2) NULL CHECK (Asistencia  BETWEEN 0 AND 10),
    NotaFinal     DECIMAL(4,2) NOT NULL DEFAULT 0,
    CONSTRAINT UQ_Nota_Estudiante_Materia UNIQUE (IdEstudiante, IdMateria)
);
GO

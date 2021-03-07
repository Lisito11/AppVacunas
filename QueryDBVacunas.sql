CREATE DATABASE DBVacunas;

--Tabla Pais
CREATE TABLE Pais (
    PaisID int NOT NULL PRIMARY KEY IDENTITY,
    NombrePais varchar(150) NOT NULL,
);

--Tabla Provincia
CREATE TABLE Provincia (
    ProvinciaID int NOT NULL PRIMARY KEY IDENTITY,
    NombreProvincia varchar(150) NOT NULL,
	PaisID int constraint fk_provincia_pais foreign key (PaisID) references Pais(PaisID)
);

--Tabla Vacuna
CREATE TABLE Vacuna (
	VacunaID int NOT NULL PRIMARY KEY,
	Nombre varchar(150) NOT NULL,
	PaisID int constraint fk_vacuna_pais foreign key (PaisID) references Pais(PaisID),
	NombreOrganizacion varchar(150),
	CantidadDias int,
	CantidadVacuna int
);

--Tabla Direccion
CREATE TABLE Direccion  (
	DireccionID int NOT NULL PRIMARY KEY,
	Latitud DECIMAL,
	Logitud DECIMAL,
	Calle Varchar(150),
	Sector Varchar(100),
	ProvinciaID int constraint fk_direccion_provincia foreign key (ProvinciaID) references Provincia(ProvinciaID),
	PaisID int constraint fk_direccion_pais foreign key (PaisID) references Pais(PaisID)
);

--Tabla Persona
CREATE TABLE Persona (
    PersonaID int NOT NULL PRIMARY KEY IDENTITY,
    Cedula varchar(11),
    Nombres varchar(80),
    Apellido1 varchar(80),
    Apellido2 varchar(80),
	Telefono varchar(15),
    FechaNacimiento DATE,
    EstatusVacuna int NOT NULL,
    FechaDosis1 DATE,
    FechaDosis2 DATE,
	DireccionID int constraint fk_persona_direccion foreign key (DireccionID) references Direccion(DireccionID),
	VacunaID int constraint fk_persona_vacuna foreign key (VacunaID) references Vacuna(VacunaID),
); 


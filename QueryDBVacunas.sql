--CREATE DATABASE DBVacunas;
USE DBVacunas;
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

-------------------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE TABLE pais (
    pais_id int NOT NULL GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    nombre_pais varchar(150) NOT NULL
);

CREATE TABLE provincia (
    provincia_id int NOT NULL GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    nombre_provincia varchar(150) NOT NULL,
    pais_id int, constraint fk_provincia_pais foreign key (pais_id) references pais(pais_id)
);

CREATE TABLE vacuna (
	vacuna_id int NOT NULL GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
	nombre varchar(150) NOT NULL,
	nombre_organizacion varchar(150),
	cantidad_dias int,
	cantidad_vacuna int,
	pais_id int, constraint fk_vacuna_pais foreign key (pais_id) references pais(pais_id)
);

CREATE TABLE direccion  (
	direccion_id int NOT NULL GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
	latitud DECIMAL,
	logitud DECIMAL,
	calle Varchar(150),
	sector Varchar(100),
	provincia_id int, constraint fk_direccion_provincia foreign key (provincia_id) references provincia(provincia_id),
	pais_id int, constraint fk_direccion_pais foreign key (pais_id) references pais(pais_id)
);

CREATE TABLE persona (
    persona_id  int NOT NULL GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    cedula varchar(11),
    nombres varchar(80),
    apellido1 varchar(80),
    apellido2 varchar(80),
    telefono varchar(15),
    fecha_nacimiento DATE,
    estatus_vacuna int NOT NULL,
    fecha_dosis1 DATE,
    fecha_dosis2 DATE,
    direccion_id int, constraint fk_persona_direccion foreign key (direccion_id) references direccion(direccion_id),
    vacuna_id int, constraint fk_persona_vacuna foreign key (vacuna_id) references vacuna(vacuna_id)
);

Provincias Data
INSERT INTO provincia (nombre_provincia, pais_id) VALUES ('Azua', 1);
INSERT INTO provincia (nombre_provincia, pais_id) VALUES ('Bahoruco', 1);
INSERT INTO provincia (nombre_provincia, pais_id) VALUES ('Barahona', 1);
INSERT INTO provincia (nombre_provincia, pais_id) VALUES ('Dajabón', 1);
INSERT INTO provincia (nombre_provincia, pais_id) VALUES ('Distrito Nacional', 1);
INSERT INTO provincia (nombre_provincia, pais_id) VALUES ('Duarte', 1);
INSERT INTO provincia (nombre_provincia, pais_id) VALUES ('Elías Piña', 1);
INSERT INTO provincia (nombre_provincia, pais_id) VALUES ('El Seibo', 1);
INSERT INTO provincia (nombre_provincia, pais_id) VALUES ('Espaillat', 1);
INSERT INTO provincia (nombre_provincia, pais_id) VALUES ('Hato Mayor', 1);
INSERT INTO provincia (nombre_provincia, pais_id) VALUES ('Hermanas Mirabal', 1);
INSERT INTO provincia (nombre_provincia, pais_id) VALUES ('Independencia', 1);
INSERT INTO provincia (nombre_provincia, pais_id) VALUES ('La Altagracia', 1);
INSERT INTO provincia (nombre_provincia, pais_id) VALUES ('La Romana', 1);
INSERT INTO provincia (nombre_provincia, pais_id) VALUES ('La Vega', 1);
INSERT INTO provincia (nombre_provincia, pais_id) VALUES ('María Trinidad Sánchez', 1);
INSERT INTO provincia (nombre_provincia, pais_id) VALUES ('Monseñor Nouel', 1);
INSERT INTO provincia (nombre_provincia, pais_id) VALUES ('Monte Cristi', 1);
INSERT INTO provincia (nombre_provincia, pais_id) VALUES ('Monte Plata', 1);
INSERT INTO provincia (nombre_provincia, pais_id) VALUES ('Pedernales', 1);
INSERT INTO provincia (nombre_provincia, pais_id) VALUES ('Peravia', 1);
INSERT INTO provincia (nombre_provincia, pais_id) VALUES ('Puerto Plata', 1);
INSERT INTO provincia (nombre_provincia, pais_id) VALUES ('Samaná', 1);
INSERT INTO provincia (nombre_provincia, pais_id) VALUES ('San Cristóbal', 1);
INSERT INTO provincia (nombre_provincia, pais_id) VALUES ('San José de Ocoa', 1);
INSERT INTO provincia (nombre_provincia, pais_id) VALUES ('San Juan', 1);
INSERT INTO provincia (nombre_provincia, pais_id) VALUES ('San Pedro de Macorís', 1);
INSERT INTO provincia (nombre_provincia, pais_id) VALUES ('Sánchez Ramírez', 1);
INSERT INTO provincia (nombre_provincia, pais_id) VALUES ('Santiago', 1);
INSERT INTO provincia (nombre_provincia, pais_id) VALUES ('Santiago Rodríguez', 1);
INSERT INTO provincia (nombre_provincia, pais_id) VALUES ('Santo Domingo', 1);
INSERT INTO provincia (nombre_provincia, pais_id) VALUES ('Valverde', 1);

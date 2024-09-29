CREATE DATABASE LIBRARY
GO

USE LIBRARY

CREATE TABLE [Personas](
	[Id] INT NOT NULL IDENTITY(1,1),
	CONSTRAINT [PK_PERSONAS] PRIMARY KEY CLUSTERED ([Id]),
	[Cedula] VARCHAR(50) NOT NULL UNIQUE,
	[Nombre] VARCHAR(80)NOT NULL,
	[Numero] BIGINT
)

CREATE TABLE [Usuarios](
	[Id] INT NOT NULL IDENTITY(1,1),
	CONSTRAINT [PK_USUARIOS] PRIMARY KEY CLUSTERED ([Id]),
	[Cod_usuario] INT NOT NULL UNIQUE,
	[Correo] VARCHAR(40) NOT NULL,
	[Contraseña] VARCHAR(20)NOT NULL,
	[Persona] INT NOT NULL,
	CONSTRAINT [FK_Usuarios_Personas] FOREIGN KEY ([Persona]) REFERENCES [Personas] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
)


CREATE TABLE [Libros](
	[Id] INT NOT NULL IDENTITY(1,1),
	CONSTRAINT [PK_LIBROS] PRIMARY KEY CLUSTERED ([Id]),
	[Cod_libro] INT NOT NULL UNIQUE,
	[Nombre_libro] VARCHAR(100) NOT NULL,
	[Fecha_publicacion] DATE,
	[Autor] VARCHAR(50)
)

CREATE TABLE [Copias](
	[Id] INT NOT NULL IDENTITY (1, 1),
	CONSTRAINT [PK_COPIAS] PRIMARY KEY CLUSTERED ([Id]),
	[Notas] VARCHAR(100),
	[Disponible] BIT DEFAULT 1,
	[Libro] INT,
	CONSTRAINT [FK_Copias_Libros] FOREIGN KEY ([Libro]) REFERENCES [Libros] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
)

CREATE TABLE [Prestamos](
	[Id] INT NOT NULL IDENTITY (1, 1),
	CONSTRAINT [PK_PRESTAMOS] PRIMARY KEY CLUSTERED ([Id]),
	[Fecha_prestamo] DATE NOT NULL,
	[Usuario] INT NOT NULL,
	CONSTRAINT [FK_Prestamos_Usuarios] FOREIGN KEY ([Usuario]) REFERENCES [Usuarios] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
)

CREATE TABLE [Detalles](
	[Id] INT NOT NULL IDENTITY (1, 1),
	CONSTRAINT [PK_DETALLES] PRIMARY KEY CLUSTERED ([Id]),
	[Fecha_entrega] DATE NOT NULL,--OBLIGATORIO
	[Prestamo] INT NOT NULL,
	[Copia] INT NOT NULL,
	CONSTRAINT [FK_Detalles_Prestamos] FOREIGN KEY ([Prestamo]) REFERENCES [Prestamos] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION,
	CONSTRAINT [FK_Detalles_Copias] FOREIGN KEY ([Copia]) REFERENCES [Copias] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
)

INSERT INTO [Personas]([Cedula],[Nombre],[Numero]) VALUES
(15123,'Esteban Quintero Yepes',312344874),
(51232,'Juan Esteban Zapata Yepes',5324354646),
(23433,'Esteban David Quintero Puerta',23435464),
(65413,'Esteban Emanuel Quintero Yepes',685639844),
(76454,'Angie Esteban Quintero',312344876)
SELECT * FROM [Personas]

INSERT INTO [Usuarios]([Cod_usuario],[Correo],[Contraseña],[Persona])VALUES
(235765,'Example@correo.com','Holamundo',2),
(543214,'Example@correo.com','Holam',1),
(6543269,'Example@correo.com','Holapa',3),
(9005566,'Example@correo.com','Holasugra',4),
(987653,'Example@correo.com','Holainfiel',5)
SELECT * FROM [Usuarios]

INSERT INTO [Libros]([Cod_libro],[Nombre_libro],[Fecha_publicacion],[Autor]) VALUES
(23468,'Titulo1','1930-11-01','Silleban'),
(12454,'Titulo2','1920-12-10','Nevereban'),
(965594,'Titulo3','1910-09-21','Noseban'),
(10872,'Titulo4','1940-07-23','Guerrilleban'),
(874723,'Titulo5','1950-07-22','Mariguneban')
SELECT * FROM [Libros]

INSERT INTO [Copias]([Notas],[Disponible],[Libro])VALUES
('A',1,1),
('T',0,2),
('H',1,5),
('J',0,2),
('K',1,3),
('C',1,3)
SELECT * FROM [Copias]

INSERT INTO [Prestamos]([Fecha_prestamo],[Usuario])VALUES
('1530-11-01',1),
('1730-11-01',2),
('1330-11-01',3),
('1230-11-01',4),
('1130-11-01',5),
('1030-11-01',5)
SELECT * FROM [Prestamos]

INSERT INTO [Detalles]([Fecha_entrega],[Prestamo],[Copia])VALUES
('2002-03-15',2,4),
('1980-03-25',1,3),
('2002-11-15',3,1),
('1850-03-25',5,2),
('1980-03-25',4,5),
('2001-12-12',6,6)
SELECT * FROM [Detalles]

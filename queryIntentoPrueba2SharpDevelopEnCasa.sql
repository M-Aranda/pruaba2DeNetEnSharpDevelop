CREATE DATABASE registroAutomovilesSharpDevelop
GO

USE registroAutomovilesSharpDevelop
GO

CREATE TABLE ultimoDuenio(
run VARCHAR (20),
nombreCompleto VARCHAR(30),
telefono VARCHAR (20),
PRIMARY KEY (run)
)
GO

CREATE TABLE automovil (
id INT IDENTITY(1,1),
patente VARCHAR (20),
marca VARCHAR (20),
anio INT,
detalles VARCHAR (100),
ultimoDuenio_fk VARCHAR (20),
FOREIGN KEY (ultimoDuenio_fk) REFERENCES ultimoDuenio (run),
PRIMARY KEY (id)
)
GO

INSERT INTO ultimoDuenio VALUES ('20898088-2', 'Marcelo Aranda', '958677107')
INSERT INTO ultimoDuenio VALUES ('20898088-1', 'Carter Slade', '6749123')
INSERT INTO ultimoDuenio VALUES ('20898088-3', 'Alexei Stukov', '333851140')
GO

INSERT INTO automovil VALUES('AAA-11', 'Ford', 1991, 'En buen estado','20898088-2')
INSERT INTO automovil VALUES('BBB-22', 'Toyota', 1992, 'En buen estado','20898088-1')
INSERT INTO automovil VALUES('CCC-33', 'Suzuki', 1993, 'En buen estado','20898088-3')
GO


CREATE VIEW verCatalogo AS
SELECT automovil.id AS 'Id', automovil.patente AS 'Patente', automovil.marca AS 'Marca',
automovil.anio AS 'Año', automovil.detalles AS 'Detalles', automovil.ultimoDuenio_fk AS 'Rut del último dueño'
FROM automovil
GO

/*
SELECT automovil.id AS 'ID', automovil.patente AS 'Patente', automovil.marca AS 'Marca',
		            automovil.anio AS 'Anio', automovil.detalles AS 'Detalles', ultimoDuenio.run AS 'Run', ultimoDuenio.nombreCompleto AS 'Nombre completo', 
		ultimoDuenio.telefono AS 'Telefono'	FROM automovil, ultimoDuenio WHERE patente='AAA-11' AND automovil.ultimoDuenio_fk=ultimoDuenio.run; 
		*/

/*
SELECT * FROM ultimoDuenio;
SELECT * FROM automovil;
SELECT * FROM verCatalogo;


USE MASTER
GO
DROP DATABASE registroAutomovilesSharpDevelop
GO
*/
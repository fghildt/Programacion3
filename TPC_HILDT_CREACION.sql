CREATE DATABASE TPC_VENTAS_HILDT
GO
USE TPC_VENTAS_HILDT
GO
SET DATEFORMAT 'DMY'
GO
CREATE TABLE MARCAS(
	IDMARCA INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	DESCRIPCION VARCHAR(50)NOT NULL 
)

GO

CREATE TABLE CATEGORIAS(
	IDCAT INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	CATEGORIA VARCHAR(30) NOT NULL
)

GO

CREATE TABLE CLIENTES(
	ID INT PRIMARY KEY IDENTITY (1,1),
	CUIT VARCHAR(20) NOT NULL,
	NOMBRE_APELLIDO VARCHAR (50)NOT NULL,
	FNAC DATETIME NULL,
	DIRECCION VARCHAR (50) NULL,
	MAIL VARCHAR(50) NULL,
	TELEFONO VARCHAR (20) NULL
)
GO

CREATE TABLE PROVEEDORES(
ID INT PRIMARY KEY IDENTITY (1,1),
CUIT VARCHAR(50) NOT NULL,
NOMBRE_APELLIDO VARCHAR (50)NOT NULL,
MAIL VARCHAR(50) NULL,
DIRECCION VARCHAR (50) NULL,
TELEFONO VARCHAR (20) NULL
)

GO

CREATE TABLE PRODUCTOS(
ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
IDMARCA INT NOT NULL FOREIGN KEY REFERENCES MARCAS(IDMARCA),
IDCATEGORIA INT NOT NULL FOREIGN KEY REFERENCES CATEGORIAS(IDCAT),
STOCK INT,
STOCKMIN INT,
NOMBRE VARCHAR(50) NOT NULL,
PRECIOCOMPRA FLOAT NOT NULL,
PORCENTAJEGANANCIA  FLOAT NOT NULL
)
GO
ALTER TABLE PRODUCTOS
ADD CONSTRAINT DEFECTO
DEFAULT 0 FOR STOCKMIN

GO

ALTER TABLE PRODUCTOS
ADD CONSTRAINT DEFECTO_STOCK
DEFAULT 0 FOR STOCK

GO

CREATE TABLE TIPOFC(
IDTIPOFC INT NOT NULL PRIMARY KEY,
TIPO VARCHAR(1) NOT NULL,
ULTIMAFCVENTA INT
)
GO

CREATE TABLE COMPRAS(
IDCOMPRA INT NOT NULL PRIMARY KEY IDENTITY (1,1),
PREFIJOFC INT NOT NULL,
FC INT NOT NULL,
TIPOFC INT NOT NULL FOREIGN KEY REFERENCES TIPOFC(IDTIPOFC),
FECHA DATETIME,
IDPROVEEDOR INT NOT NULL FOREIGN KEY REFERENCES PROVEEDORES(ID)
)
GO

CREATE TABLE DETALLECOMPRAS(
IDDETALLECOMPRA INT NOT NULL PRIMARY KEY IDENTITY (1,1),
IDCOMPRA INT NOT NULL FOREIGN KEY REFERENCES COMPRAS(IDCOMPRA),
IDPRODUCTO INT NOT NULL FOREIGN KEY REFERENCES PRODUCTOS(ID),
CANTIDAD INT NOT NULL,
PRECIO FLOAT NOT NULL
)

GO

CREATE TABLE VENTAS(
IDVENTA INT NOT NULL PRIMARY KEY IDENTITY(1,1),
PREFIJOFC INT,
NROFC INT NOT NULL,
TIPOFC INT NOT NULL FOREIGN KEY REFERENCES TIPOFC(IDTIPOFC),
FECHA DATETIME,
IDCLIENTE INT NOT NULL FOREIGN KEY REFERENCES CLIENTES(ID)
)
GO

ALTER TABLE VENTAS
ADD CONSTRAINT PREF_DEFECTO
DEFAULT 1 FOR PREFIJOFC

GO

CREATE TABLE DETALLEVENTAS(
IDDETALLEVENTA INT NOT NULL PRIMARY KEY IDENTITY(1,1),
NROVENTA INT NOT NULL FOREIGN KEY REFERENCES VENTAS(IDVENTA),
IDPRODUCTO INT NOT NULL FOREIGN KEY REFERENCES PRODUCTOS(ID),
CANTIDAD INT NOT NULL,
PRECIO FLOAT NOT NULL
)
GO

CREATE TABLE PRODXPROV(
ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
IDPROVEEDOR INT NOT NULL FOREIGN KEY REFERENCES PROVEEDORES(ID),
IDPRODUCTO INT NOT NULL FOREIGN KEY REFERENCES PRODUCTOS(ID)
)
GO


--PROVEEDORES
INSERT INTO PROVEEDORES (CUIT, NOMBRE_APELLIDO, MAIL, DIRECCION, TELEFONO) VALUES ('77483983530','MOUSES Y TECLADOS & CIA.','PROVEEDOR1@GMAIL.COM','CALLE FALSA 1234','46757476')
INSERT INTO PROVEEDORES (CUIT, NOMBRE_APELLIDO, MAIL, DIRECCION, TELEFONO) VALUES ('37494185030','PROVEEDOR2','PROVEEDOR2@GMAIL.COM','CALLE FALSA 2345','40221395')
INSERT INTO PROVEEDORES (CUIT, NOMBRE_APELLIDO, MAIL, DIRECCION, TELEFONO) VALUES ('50673285285','PROVEEDOR3','PROVEEDOR3@GMAIL.COM','CALLE FALSA 3456','45326139')
INSERT INTO PROVEEDORES (CUIT, NOMBRE_APELLIDO, MAIL, DIRECCION, TELEFONO) VALUES ('12326966966','PROVEEDOR4','PROVEEDOR4@GMAIL.COM','CALLE FALSA 4567','46765302')
INSERT INTO PROVEEDORES (CUIT, NOMBRE_APELLIDO, MAIL, DIRECCION, TELEFONO) VALUES ('12519289415','PROVEEDOR5','PROVEEDOR5@GMAIL.COM','CALLE FALSA 5678','45264255')
INSERT INTO PROVEEDORES (CUIT, NOMBRE_APELLIDO, MAIL, DIRECCION, TELEFONO) VALUES ('21768437272','PROVEEDOR6','PROVEEDOR6@GMAIL.COM','CALLE FALSA 6789','45987725')
INSERT INTO PROVEEDORES (CUIT, NOMBRE_APELLIDO, MAIL, DIRECCION, TELEFONO) VALUES ('23259750232','PROVEEDOR7','PROVEEDOR7@GMAIL.COM','CALLE FALSA 7900','43740307')
INSERT INTO PROVEEDORES (CUIT, NOMBRE_APELLIDO, MAIL, DIRECCION, TELEFONO) VALUES ('12745017687','PROVEEDOR8','PROVEEDOR8@GMAIL.COM','CALLE FALSA 9011','45866237')
INSERT INTO PROVEEDORES (CUIT, NOMBRE_APELLIDO, MAIL, DIRECCION, TELEFONO) VALUES ('14583979111','PROVEEDOR9','PROVEEDOR9@GMAIL.COM','CALLE FALSA 10122','43646187')
INSERT INTO PROVEEDORES (CUIT, NOMBRE_APELLIDO, MAIL, DIRECCION, TELEFONO) VALUES ('10714935298','PROVEEDOR10','PROVEEDOR10@GMAIL.COM','CALLE FALSA 11233','45205175')
INSERT INTO PROVEEDORES (CUIT, NOMBRE_APELLIDO, MAIL, DIRECCION, TELEFONO) VALUES ('44112421788','PROVEEDOR11','PROVEEDOR11@GMAIL.COM','CALLE FALSA 12344','45006856')
INSERT INTO PROVEEDORES (CUIT, NOMBRE_APELLIDO, MAIL, DIRECCION, TELEFONO) VALUES ('31562606745','PROVEEDOR12','PROVEEDOR12@GMAIL.COM','CALLE FALSA 13455','44215329')



GO
--MARCAS
INSERT INTO MARCAS (DESCRIPCION) VALUES ('PEPSI')
INSERT INTO MARCAS (DESCRIPCION) VALUES ('OREO')
INSERT INTO MARCAS (DESCRIPCION) VALUES ('7UP')
INSERT INTO MARCAS (DESCRIPCION) VALUES ('DON SATUR')
INSERT INTO MARCAS (DESCRIPCION) VALUES ('HERR KUKUMBER')
INSERT INTO MARCAS (DESCRIPCION) VALUES ('ARCOR')
INSERT INTO MARCAS (DESCRIPCION) VALUES ('FARGO')
INSERT INTO MARCAS (DESCRIPCION) VALUES ('BIMBO')
INSERT INTO MARCAS (DESCRIPCION) VALUES ('GALLO')
INSERT INTO MARCAS (DESCRIPCION) VALUES ('T�A MARUCA')
INSERT INTO MARCAS (DESCRIPCION) VALUES ('BC')
INSERT INTO MARCAS (DESCRIPCION) VALUES ('GEORGALOS')
INSERT INTO MARCAS (DESCRIPCION) VALUES ('PHILIPS')
INSERT INTO MARCAS (DESCRIPCION) VALUES ('PANASONIC')
INSERT INTO MARCAS (DESCRIPCION) VALUES ('DOVE')
INSERT INTO MARCAS (DESCRIPCION) VALUES ('ALA')

GO
-- CATEGORIAS
INSERT INTO CATEGORIAS (CATEGORIA) VALUES ('GASEOSAS')
INSERT INTO CATEGORIAS (CATEGORIA) VALUES ('PRODUCTOS LIGHT')
INSERT INTO CATEGORIAS (CATEGORIA) VALUES ('GALLETITAS')
INSERT INTO CATEGORIAS (CATEGORIA) VALUES ('CONSERVAS')
INSERT INTO CATEGORIAS (CATEGORIA) VALUES ('ENCURTIDOS')
INSERT INTO CATEGORIAS (CATEGORIA) VALUES ('PAN LACTAL')
INSERT INTO CATEGORIAS (CATEGORIA) VALUES ('MERMELADAS')
INSERT INTO CATEGORIAS (CATEGORIA) VALUES ('SNACKS')
INSERT INTO CATEGORIAS (CATEGORIA) VALUES ('GOLOSINAS')

GO
--CLIENTES
INSERT INTO CLIENTES (CUIT, NOMBRE_APELLIDO, FNAC, MAIL, TELEFONO,DIRECCION) VALUES ('0001', 'CLIENTE GENERICO', '1/1/1900', 'CLIENTE GENERICO', '1111111111','')
INSERT INTO CLIENTES (CUIT, NOMBRE_APELLIDO, FNAC, MAIL, TELEFONO,DIRECCION) VALUES ('2222', 'PAULA PARETTO', '2/2/1999', 'PAULI_PARETTO@GMAIL.COM', '13245678','calle falsa')
INSERT INTO CLIENTES (CUIT, NOMBRE_APELLIDO, FNAC, MAIL, TELEFONO,DIRECCION) VALUES ('3333', 'BRIAN TOLEDO', '3/3/2000', 'BRIAN.CABJ@HOTMAIL.COM', '3123123','calle falsa')
INSERT INTO CLIENTES (CUIT, NOMBRE_APELLIDO, FNAC, MAIL, TELEFONO,DIRECCION) VALUES ('4444', 'GERM�N LAURO', '4/4/1970', 'GERMAN.LAURO@GMAIL.COM', '54234234','calle falsa')
INSERT INTO CLIENTES (CUIT, NOMBRE_APELLIDO, FNAC, MAIL, TELEFONO,DIRECCION) VALUES ('5555', 'JULIETA LAZCANO', '5/5/1991', 'JULIETA.LAZCANO@LIVE.COM.AR', '725464','calle falsa')
INSERT INTO CLIENTES (CUIT, NOMBRE_APELLIDO, FNAC, MAIL, TELEFONO,DIRECCION) VALUES ('6666', 'CARLA REBECCHI', '6/6/1986', 'REBECCHI.CAR@GMAIL.COM', '7534234','calle falsa')
INSERT INTO CLIENTES (CUIT, NOMBRE_APELLIDO, FNAC, MAIL, TELEFONO,DIRECCION) VALUES ('7777', 'BEL�N SUCCHI', '7/7/1990', 'BEL_SUCCHI@OUTLOOK.COM', '8123123','calle falsa')
INSERT INTO CLIENTES (CUIT, NOMBRE_APELLIDO, FNAC, MAIL, TELEFONO,DIRECCION) VALUES ('8888', 'MAT�AS SCHULZ', '8/8/1991', 'MATIAS.97@HOTMAIL.COM', '10235345','calle falsa')
INSERT INTO CLIENTES (CUIT, NOMBRE_APELLIDO, FNAC, MAIL, TELEFONO,DIRECCION) VALUES ('9999', 'DIEGO SIMONET', '9/9/1992', 'DIEGUISIMONET@GMAIL.COM', '11125345','calle falsa')

--
GO

--PRODUCTOS
INSERT INTO PRODUCTOS(IDMARCA,IDCATEGORIA,NOMBRE,PRECIOCOMPRA,PORCENTAJEGANANCIA) VALUES ('15', '1', 'MOUSE LOGITECH', '377', '42')
INSERT INTO PRODUCTOS(IDMARCA,IDCATEGORIA,NOMBRE,PRECIOCOMPRA,PORCENTAJEGANANCIA) VALUES ('15', '3', 'TECLADO RGB', '381', '60')
INSERT INTO PRODUCTOS(IDMARCA,IDCATEGORIA,NOMBRE,PRECIOCOMPRA,PORCENTAJEGANANCIA) VALUES ('6', '7', 'MOUSE HYPERX', '239', '83')
INSERT INTO PRODUCTOS(IDMARCA,IDCATEGORIA,NOMBRE,PRECIOCOMPRA,PORCENTAJEGANANCIA) VALUES ('6', '1', 'TECLADO HYPERX', '34', '70')
INSERT INTO PRODUCTOS(IDMARCA,IDCATEGORIA,NOMBRE,PRECIOCOMPRA,PORCENTAJEGANANCIA) VALUES ('2', '8', 'PRODUCTO 5', '74', '38')
INSERT INTO PRODUCTOS(IDMARCA,IDCATEGORIA,NOMBRE,PRECIOCOMPRA,PORCENTAJEGANANCIA) VALUES ('1', '4', 'PRODUCTO 6', '262', '80')
INSERT INTO PRODUCTOS(IDMARCA,IDCATEGORIA,NOMBRE,PRECIOCOMPRA,PORCENTAJEGANANCIA) VALUES ('2', '9', 'PRODUCTO 7', '387', '44')
INSERT INTO PRODUCTOS(IDMARCA,IDCATEGORIA,NOMBRE,PRECIOCOMPRA,PORCENTAJEGANANCIA) VALUES ('1', '2', 'PRODUCTO 8', '68', '38')
INSERT INTO PRODUCTOS(IDMARCA,IDCATEGORIA,NOMBRE,PRECIOCOMPRA,PORCENTAJEGANANCIA) VALUES ('1', '2', 'PRODUCTO 9', '68.5', '12.5')

GO

INSERT INTO PRODXPROV (IDPROVEEDOR,IDPRODUCTO) VALUES(1,1)
INSERT INTO PRODXPROV (IDPROVEEDOR,IDPRODUCTO) VALUES(1,2)
INSERT INTO PRODXPROV (IDPROVEEDOR,IDPRODUCTO) VALUES(2,1)
INSERT INTO PRODXPROV (IDPROVEEDOR,IDPRODUCTO) VALUES(3,2)
INSERT INTO PRODXPROV (IDPROVEEDOR,IDPRODUCTO) VALUES(3,5)
INSERT INTO PRODXPROV (IDPROVEEDOR,IDPRODUCTO) VALUES(4,3)
INSERT INTO PRODXPROV (IDPROVEEDOR,IDPRODUCTO) VALUES(1,3)

GO

INSERT INTO TIPOFC(IDTIPOFC,TIPO,ULTIMAFCVENTA) VALUES (1,'A',0)
INSERT INTO TIPOFC(IDTIPOFC,TIPO,ULTIMAFCVENTA) VALUES (2,'B',0)
INSERT INTO TIPOFC(IDTIPOFC,TIPO,ULTIMAFCVENTA) VALUES (3,'C',0)
INSERT INTO TIPOFC(IDTIPOFC,TIPO,ULTIMAFCVENTA) VALUES (4,'T',0)


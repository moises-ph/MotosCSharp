CREATE DATABASE MotorStore;
USE MotorStore;

use DB_Empresa;

CREATE TYPE Cilindraje
from int

go
CREATE TABLE Cliente(
	IdCliente varchar(10) primary key,
	NombreCliente varchar(50) not null,
	ApellidoCliente varchar(50) not null,
	Correo varchar(50) not null,
	Telefono varchar(30) not null,
	Direccion varchar(100) not null,
	Ciudad varchar(100) not null
);
go
go
CREATE TABLE Moto(
	IdCompra int identity(0, 1) primary key,
	FechaCompra datetime default getdate(),
	Marca varchar(50) not null,
	Modelo varchar(4) not null,
	Cilindraje cilindraje not null,
	Freno varchar(50) not null,
	Llantas varchar(50) not null, 
	Refrigeracion varchar(50) not null,
	Suspension varchar(50) not null,
	ValorMoto money not null,
	ValorSoat money not null,
	valorTotal money not null,
    IdCliente varchar(10) FOREIGN KEY REFERENCES Cliente(IdCliente)
);
go
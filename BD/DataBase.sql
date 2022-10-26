CREATE DATABASE MotorStore;
USE MotorStore;
use oli
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
	IdCompra varchar(10) primary key,
	FechaCompra date  not null,
	Marca varchar(50) not null,
	Modelo varchar(4) not null,
	Cilindraje int not null,
	Freno varchar(50) not null,
	Llantas varchar(50) not null, 
	Refrigeracion varchar(50) not null,
	Suspension varchar(50) not null,
	ValorMoto float not null,
	ValorSoat float not null,
	valorTotal float not null,
    IdCliente varchar(10) FOREIGN KEY REFERENCES Cliente(IdCliente)
);
go
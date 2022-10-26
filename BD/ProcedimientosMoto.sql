USE MotorStore

/*Creacion de procedimientos Moto*/

go
CREATE PROCEDURE usp_create_Moto
	@IdCompra varchar(10) ,
	@FechaCompra date ,
	@Marca varchar(50) ,
	@Modelo varchar(4) ,
	@Cilindraje int ,
	@Freno varchar(50) ,
	@Llantas varchar(50) , 
	@Refrigeracion varchar(50),
	@Suspension varchar(50),
	@ValorMoto float ,
	@ValorSoat float ,
	@valorTotal float ,
    @IdCliente varchar(10)
as
begin
	INSERT INTO Moto (IdCompra,FechaCompra,Marca,Modelo,Cilindraje,Freno,Llantas,Refrigeracion,Suspension,ValorMoto,ValorSoat,valorTotal,IdCliente) values (@IdCompra,@FechaCompra,@Marca,@Modelo,@Cilindraje,@Freno,@Llantas,@Refrigeracion,@Suspension,@ValorMoto,@ValorSoat,@valorTotal,@IdCliente);
end
go

execute usp_create_Moto '1','2022-10-25','XD','XD',150,'XD','XD','XD','XD',10,10,10,'1'
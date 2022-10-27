USE MotorStore

use DB_Empresa;

/*Creacion de procedimientos Moto*/

go
CREATE PROCEDURE usp_create_Moto
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
	INSERT INTO Moto (Marca,Modelo,Cilindraje,Freno,Llantas,Refrigeracion,Suspension,ValorMoto,ValorSoat,valorTotal,IdCliente) values (@Marca,@Modelo,@Cilindraje,@Freno,@Llantas,@Refrigeracion,@Suspension,@ValorMoto,@ValorSoat,@valorTotal,@IdCliente);
end
go

execute usp_create_Moto 'XD','XD',150,'XD','XD','XD','XD',10,10,10,'1'

go
create procedure usp_read_Moto
	@IdCompra int
as
begin
	select * from Moto where IdCompra=@IdCompra
end
go

execute usp_read_Moto '1'

go
create procedure usp_Listar_Moto
as
begin
	SELECT * from Moto;
end
go

execute usp_Listar_Moto
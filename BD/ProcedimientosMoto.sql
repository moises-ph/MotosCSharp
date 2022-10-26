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

go
create procedure usp_read_Moto
	@IdCompra varchar(10)
as
begin
	select * from Moto where IdCompra=@IdCompra
end
go

execute usp_read_Moto '1'

go
create procedure usp_update_moto
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
	update Moto set IdCompra=@IdCompra,FechaCompra=@FechaCompra,Marca=@Marca,Modelo=@Modelo,Cilindraje=@Cilindraje,Freno=@Freno,Llantas=@Llantas,Refrigeracion=@Refrigeracion,Suspension=@Suspension,ValorMoto=@ValorMoto,ValorSoat=@ValorSoat,valorTotal=@valorTotal,IdCliente=@IdCliente where IdCompra=@IdCompra
end
go

execute usp_update_moto '1','2022-10-25','BMW','2022',1000,'Disco','Anti Deslizante','Liquida','ABS',100000,1000,100,'1'

go
create procedure usp_delete_Moto
	@IdCompra varchar(10)
as
begin
	delete from Moto where IdCompra=@IdCompra
end
go

execute usp_delete_Moto '1'

go
create procedure usp_Listar_Moto
as
begin
	SELECT '0' as IdCompra, 'Seleccione un Cliente' as Moto
	union
	SELECT IdCompra as IdCompra, Marca as Moto from Moto;
end
go

execute usp_Listar_Moto
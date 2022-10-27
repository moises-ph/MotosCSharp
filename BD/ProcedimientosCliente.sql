USE MotorStore

use DB_Empresa;

/*Creacion de procedimientos Cliente*/

go
CREATE PROCEDURE usp_create_Cliente
	@IdCliente varchar(10) ,
	@NombreCliente varchar(50) ,
	@ApellidoCliente varchar(50) ,
	@Correo varchar(50) ,
	@Telefono varchar(30) ,
	@Direccion varchar(100) ,
	@Ciudad varchar(100) 
as
begin
	INSERT INTO Cliente values (@IdCliente,@NombreCliente,@ApellidoCliente,@Correo,@Telefono,@Direccion,@Ciudad);
end
go

go
create procedure usp_read_Cliente
	@IdCliente varchar(10)
as
begin
	select * from Cliente where IdCliente=@IdCliente
end
go
	execute usp_read_Cliente '2'

go
create procedure usp_Update_Cliente
	@IdCliente varchar(10) ,
	@NombreCliente varchar(50) ,
	@ApellidoCliente varchar(50) ,
	@Correo varchar(50) ,
	@Telefono varchar(30) ,
	@Direccion varchar(100) ,
	@Ciudad varchar(100) 
as
begin
	Update Cliente set  NombreCliente=@NombreCliente,ApellidoCliente=@ApellidoCliente,Correo=@Correo,Telefono=@Telefono,Direccion=@Direccion,Ciudad=@Ciudad where  IdCliente=@IdCliente;
end
go

go
create procedure usp_delete_cliente
	@IdCliente varchar(10)
as
begin
	delete from Cliente where IdCliente=@IdCliente
end
go

go
create procedure usp_Listar_Cliente
as
begin
	SELECT * from Cliente;
end
go


execute usp_create_Cliente '1','Xd','xD','XD@XD.com','1234567890','XD','xD'

execute usp_Update_Cliente '1','Gian','Rios','Gian-5634@hotmail.com','3103058570','No se','Armenia'

execute usp_delete_cliente '2'

execute usp_read_Cliente '1'

execute usp_Listar_Cliente

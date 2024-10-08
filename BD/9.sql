/************************ PROCEDIMIENTOS DE CLIENTES **********************/
/* Procedimiento para mostrar cliente*/

create procedure mostrar_cliente 
as
select clienteid, nombre as 'Nombre', apellido as 'Apellido', numidentidad as 'DNI', direccion as 'Dirección', telefono as 'Teléfono' , movil as 'Móvil', correo as 'Correo', fecha_nac as 'Fecha_de_Nacimiento', departamento as 'Departamento', pais as 'País', ciudad as 'Ciudad', sexo as 'Sexo', nom_contacto as 'Nombre_Contacto', tel_contacto as 'Teléfono_Contacto' from cliente order by clienteid asc
go

/* Procedimiento para insertar cliente */
create procedure insertar_cliente
@nombre varchar(50),
@apellido varchar(50),
@numidentidad varchar(20),
@direccion varchar(100),
@telefono varchar(9),
@movil varchar(9),
@correo varchar(50),
@fecha_nac date,
@departamento varchar(30),
@pais varchar (30),
@ciudad varchar(30),
@sexo varchar(1),
@nom_contacto varchar(30),
@tel_contacto varchar(9)
as
insert into cliente (nombre, apellido, numidentidad, direccion, telefono, movil, correo, fecha_nac, departamento, pais, ciudad, sexo, nom_contacto, tel_contacto)
values (@nombre, @apellido, @numidentidad, @direccion, @telefono, @movil, @correo, @fecha_nac, @departamento, @pais, @ciudad, @sexo, @nom_contacto, @tel_contacto)
go

/* Procedimiento para editar clientes*/
create procedure editar_cliente
@clienteid integer,
@nombre varchar(50),
@apellido varchar(50),
@numidentidad varchar(20),
@direccion varchar(100),
@telefono varchar(9),
@movil varchar(9),
@correo varchar(50),
@fecha_nac date,
@departamento varchar(30),
@pais varchar (30),
@ciudad varchar(30),
@sexo varchar(1),
@nom_contacto varchar(30),
@tel_contacto varchar(9)
as
update cliente set nombre= @nombre,
apellido=@apellido,
numidentidad= @numidentidad,
direccion=@direccion,
telefono=@telefono,
movil=@movil,
correo=@correo,
fecha_nac=@fecha_nac,
departamento=@departamento,
pais=@pais,
ciudad=@ciudad,
sexo=@sexo,
nom_contacto=@nom_contacto,
tel_contacto=@tel_contacto
where clienteid=@clienteid
go

/* Procedimiento para eliminar clientes*/
create procedure eliminar_cliente
@clienteid integer
as
delete from cliente where clienteid = @clienteid
go

/************************ PROCEDIMIENTOS DE TIPO DISCO **********************/
/*Procedimiento para mostrar tipo de disco*/
create procedure mostrar_tipo 
as
select * from tipo_disco order by discoid desc
go

/* Procedimiento para insertar tipo de disco */
create procedure insertar_tipo
@tipoDisco varchar(50)
as
insert into tipo_disco (tipoDisco)
values (@tipoDisco)
go
 exec mostrar_tipo
/*Procedimiento para editar tipo de disco */

create procedure editar_tipo
@discoid integer,
@tipoDisco varchar(50)
as
update tipo_disco set tipoDisco = @tipoDisco 
where discoid = @discoid
go

/* Procedimiento para eliminar tipo de disco*/
create procedure eliminar_tipo
@discoid integer
as
delete from tipo_disco where discoid=@discoid
go

/************************ PROCEDIMIENTOS DE PROVEEDORES **********************/
/* Procedimiento para mostrar proveedor*/
alter procedure mostrar_proveedor
as
select p.idProveedor, p.idDisco, d.nombre_disco as 'Nombre_de_disco', p.nom_proveedor as 'Nombre_de_proveedor', p.nom_contacto as 'Nombre_de_contacto', p.cargo_contacto as 'Cargo_de_contacto', p.direccion as 'Dirección', p.ciudad as 'Ciudad', p.departamento as 'Departamento', p.pais as 'País', p.telefono as 'Teléfono', p.correo as 'Correo', p.terminos_pago as 'Términos_de_pago' from proveedor p
inner join discos d
on d.discoid= p.idDisco
go

/* Procedimiento para insertar proveedor */
alter procedure insertar_proveedor
@idDisco int,
@nom_proveedor varchar(50),
@nom_contacto varchar(50),
@cargo_contacto varchar(50),
@direccion varchar(100),
@ciudad varchar(50),
@departamento varchar(50),
@pais varchar(50),
@telefono varchar(9),
@correo varchar(50),
@terminos_pago varchar(50)
as
insert into proveedor (idDisco, nom_proveedor, nom_contacto, cargo_contacto, direccion, ciudad, departamento, pais, telefono, correo, terminos_pago)
values (@idDisco,@nom_proveedor, @nom_contacto, @cargo_contacto, @direccion, @ciudad, @departamento, @pais, @telefono, @correo, @terminos_pago)
go

/*Procedimiento para editar proveedor */
create procedure editar_proveedor
@idProveedor integer,
@idDisco integer,
@nom_proveedor varchar(50),
@nom_contacto varchar(50),
@cargo_contacto varchar(50),
@direccion varchar(30),
@ciudad varchar(50),
@departamento varchar(50),
@pais varchar(50),
@telefono varchar(9),
@correo varchar(50),
@terminos_pago varchar(50)
as
update Proveedor set nom_proveedor = @nom_proveedor,
nom_contacto = @nom_contacto,
cargo_contacto = @cargo_contacto,
direccion = @direccion,
ciudad = @ciudad,
departamento = @departamento,
pais = @pais,
telefono = @telefono,
correo = @correo,
terminos_pago = @terminos_pago 
where idProveedor = @idProveedor
go

/* Procedimiento para eliminar proveedor*/
create procedure eliminar_proveedor
@idProveedor integer
as
delete from proveedor where idProveedor=@idProveedor
go

/************************ PROCEDIMIENTOS DE USUARIOS **********************/
/* Procedimiento para mostrar usuario*/
create procedure mostrar_usuario
as
select idUsuario, nombreUsuario as 'Nombre', apellidoUsuario as 'Apellido', numidentidad as 'DNI', direccion as 'Dirección', telefono as 'Teléfono', correo as 'Correo', login as 'Login', password as 'Password', acceso as 'Acceso' from usuarios
go

/* Procedimiento para insertar usuario */
create procedure insertar_usuario
@nombreUsuario varchar(50),
@apellidoUsuario varchar(50),
@numidentidad varchar(20),
@direccion varchar(100),
@telefono varchar(9),
@correo varchar(50),
@login varchar(9),
@password varchar(50),
@acceso varchar(1)
as
insert into usuarios (nombreUsuario, apellidoUsuario, numidentidad, direccion, telefono, correo, login, password, acceso)
values (@nombreUsuario, @apellidoUsuario, @numidentidad, @direccion, @telefono, @correo, @login, @password, @acceso)
go

/*Procedimiento para editar usuario */

create procedure editar_usuario
@idUsuario integer,
@nombreUsuario varchar(50),
@apellidoUsuario varchar(50),
@numidentidad varchar(20),
@direccion varchar(100),
@telefono varchar(9),
@correo varchar(50),
@login varchar(9),
@password varchar(50),
@acceso varchar(1)
as
update usuarios set nombreUsuario = @nombreUsuario,
apellidoUsuario = @apellidoUsuario,
numidentidad = @numidentidad,
direccion = @direccion,
telefono = @telefono,
correo = @correo,
login = @login,
password = @password,
acceso = @acceso 
where idUsuario = @idUsuario
go


/* Procedimiento para eliminar usuario*/
create procedure eliminar_usuario
@idUsuario integer
as
delete from usuarios where idUsuario=@idUsuario
go

/*Procedimiento para validar le acceso al sistema de los usuarios*/
create proc validar_usuario
@login varchar(50),
@password varchar(50)
as 
select * from usuarios
where login = @login and password = @password and acceso = '1'
go

/************************ PROCEDIMIENTOS DE PRODUCTOS **********************/
/* Procedimiento para mostrar producto*/
alter procedure mostrar_producto
as
select discos.idDisco,
discos.discoid,
tipo_disco.tipoDisco as 'Tipo_de_disco',
discos.nombre_disco as 'Nombre_de_disco',
discos.descripcion as 'Descripción',
discos.capacidad as 'Capacidad',
discos.nom_proveedor as 'Nombre_de_proveedor',
discos.precio_venta as 'Precio_de_venta',
discos.precio_compra as 'Precio_de_compra',
discos.stock as 'Stock',
discos.marca as 'Marca',
discos.imagen as 'Imagen'
from discos inner join
tipo_disco on discos.discoid= tipo_disco.discoid
order by discos.idDisco desc
go

/* Procedimiento para insertar producto */
alter procedure insertar_producto
@discoid int,
@nombre_disco varchar(50),
@descripcion varchar(255),
@capacidad varchar(50),
@nom_proveedor varchar(50),
@precio_venta decimal(18,2),
@precio_compra decimal(18,2),
@stock int,
@marca varchar(50),
@imagen image
as
insert into discos (discoid ,nombre_disco, descripcion, capacidad, nom_proveedor, precio_venta, precio_compra, stock, marca, imagen)
values (@discoid,@nombre_disco, @descripcion, @capacidad, @nom_proveedor, @precio_venta, @precio_compra, @stock, @marca, @imagen)
go

exec insertar_producto 1, 'Kingston SSD', 'Discos nuevos', '250 GB', 'Camilo', 900, 800, 10, 'Kingston', null
exec mostrar_producto
/*Procedimiento para editar producto */

create procedure editar_producto
@idDisco integer,
@discoid int,
@nombre_disco varchar(50),
@descripcion varchar(255),
@capacidad varchar(50),
@nom_proveedor varchar(50),
@precio_venta decimal(18,2),
@precio_compra decimal(18,2),
@stock int,
@marca varchar(50),
@imagen image
as
update discos set discoid = @discoid,
nombre_disco = @nombre_disco,
descripcion = @descripcion,
capacidad = @capacidad,
nom_proveedor = @nom_proveedor,
precio_venta = @precio_venta,
precio_compra = @precio_compra,
stock = @stock,
marca = @marca,
imagen = @imagen
where idDisco = @idDisco
go

/* Procedimiento para eliminar producto*/
create procedure eliminar_producto
@idDisco integer
as
delete from discos where idDisco=@idDisco
go

/************************ PROCEDIMIENTOS DE BACKUP **********************/

create proc backup_base
as
BACKUP DATABASE sistema_discos
to DISK=N'C:\SistemaDiscos\Respaldo\sistema_discos.bak'
with DESCRIPTION=N'Respaldo de la Base de Datos',
NOFORMAT,
INIT,
NAME=N'sistema_discos',
skip,
NOREWIND,
NOUNLOAD,
STATS=10,
CHECKSUM
go

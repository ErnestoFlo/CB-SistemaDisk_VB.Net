
create database sistema_discos
go

use sistema_discos
go

create table cliente (
clienteid int identity (1,1) primary key,
nombre varchar(50) not null,
apellido varchar(50) not null,
numidentidad varchar(20) not null,
direccion varchar(100) null,
telefono varchar(9) null,
movil varchar(9) null,
correo varchar(50) not null,
fecha_nac date not null,
departamento varchar(30) not null,
pais varchar (30) not null,
ciudad varchar(30) not null,
sexo varchar(1) not null,
nom_contacto varchar(30) not null,
tel_contacto varchar(9) not null)
go

create table tipo_disco (
discoid int identity(1,1) primary key,
tipoDisco varchar(50) not null)
go

create table discos (
idDisco int identity(1,1) primary key,
discoid int not null,
nombre_disco varchar(50) not null,
descripcion varchar(255) not null,
capacidad varchar(50) not null,
nom_proveedor varchar(50) not null,
precio_venta decimal(18,2) not null,
precio_compra decimal(18,2) not null,
stock int not null,
marca varchar(50) not null,
imagen image)
go

create table Proveedor (
idProveedor int identity(1,1) primary key,
idDisco int not null,
nom_proveedor varchar(50) not null,
nom_contacto varchar(50) not null,
cargo_contacto varchar(50) not null,
direccion varchar(100) not null,
ciudad varchar(50) not null,
departamento varchar(50) not null,
pais varchar(50) not null,
telefono varchar(9) not null,
correo varchar(50) not null,
terminos_pago varchar(50) not null)
go

create table usuarios (
idUsuario int identity(1,1) primary key,
nombreUsuario varchar(50) not null,
apellidoUsuario varchar(50) not null,
numidentidad varchar(20) not null,
direccion varchar(100) not null,
telefono varchar(9) not null,
correo varchar(50) not null,
login varchar(9) not null,
password varchar(50) not null,
acceso varchar(1) not null)
go


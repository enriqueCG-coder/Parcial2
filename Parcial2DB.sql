-- --------------------------------------------
-- INTEGRANTES
-- --------------------------------------------
-- ENRIQUE JOSÉ CARDONA GUARDADO
-- PEDRO ARTURO GUTIERREZ CARDONA 
-- NESTOR OSWALDO ALVAREZ CRUZ
-- CARLOS BENJAMIN GARCÍA GANUZA
-- --------------------------------------------

create database parcial2;
use parcial2;

create table Clientes
(
	IDCliente int primary key auto_increment,
    Cliente nvarchar(60) not null
);

create table Movimientos
(
	IDMovimiento int primary key auto_increment,
    Fecha nvarchar(15) not null,
    IDCliente int not null,
    foreign key (IDCliente)  references Clientes(IDCliente) ,
    Concepto nvarchar(15) not null,
    Monto nvarchar(6) not null,
    Flujo nvarchar(6) not null
);
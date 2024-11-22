/* Crear las Tablas */

--Tabla Medida 
create table Medida (
IdMedida	int primary key identity(1,1), 
NomMedida	varchar(50) not null,
Abreviatura	varchar(4) not null, -- und kg (und: unidad - kg: kilogramos) Equivalente	varchar(4) not null, -- und g (und: unidad - g: gramos como unidad básica)
Valor	int not null	-- 1	1000 (1--> unidad, kilogramos --> 1000)
)
go

--Tabla Categoria 
create table Categoria (
IdCategoria	int primary key identity(1,1), 
NombreCategoria varchar(50) not null,
IdMedida	int references Medida(IdMedida), 
Activo	bit default 1
)
go


--Tabla Producto 
create table Producto (
IdProducto	int primary key identity(1,1), IdCategoria int references Categoria(IdCategoria), Codigo		varchar(50) not null,
Descripcion varchar(150) not null, PrecioCompra decimal(10,2) not null, PrecioVenta decimal(10,2) not null, Cantidad	int not null,
Activo	bit default 1
)
go



--Tabla Rol 
create table Rol (
IdRol	int primary key identity(1,1), NombreRol varchar(50) not null
)
go

--Tabla Usuario 
create table Usuario (
IdUsuario	int primary key identity(1,1), IdRol	int references Rol(IdRol), NombreCompleto varchar(50) not null,
Correo	varchar(50) not null, NombreUsuario	varchar(50) not null unique, Clave	varchar(100) not null, ResetearClave	bit default 1,
Activo	bit default 1
)
go


--Tabla CorrelativoVenta 
create table CorrelativoVenta (
Serie varchar(3) not null, Numero int not null, Activo bit default 1 primary key (Serie,Numero)
)
go
 
--Tabla Venta 
create table Venta (
IdVenta	int primary key identity(1,1),
NumeroVenta	varchar(10), -- Formato: 001-000001, lo cual cambiaría: 001-000002, 001-000003, 001-000004, 001-00000N
IdUsuarioRegistro int references Usuario(IdUsuario), NombreCliente	varchar(60),
PrecioTotal	decimal(10,2) not null, PagoCon	decimal(10,2),
Cambio	decimal(10,2), FechaRegistro	datetime default getdate(), Activo		bit default 1
)
go

--Tabla DetalleVenta 
create table DetalleVenta (
IdDetalleVenta int primary key identity(1,1), IdVenta	int references Venta(IdVenta), IdProducto	int references Producto(IdProducto), Cantidad	int,
PrecioVenta	decimal(10,2),
PrecioTotal	decimal(10,2) -- Multiplicación cantidad x precio
)
go

--Tabla Negocio 
create table Negocio (
IdNegocio	int primary key identity(1,1), RazonSocial	varchar(100),
RUC	varchar(20), Direccion	varchar(100), Celular	varchar(10),
Corrreo	varchar(30), SimboloMoneda varchar(5), NombreLogo	varchar(100), UrlLogo		varchar(200)
)
go
--Tabla Menú

create table Menu (
IdMenu	int primary key identity(1,1), NombreMenu varchar(50) not null, IdMenuPadre int default 0 not null,

-- Comentarios--
/* IdMenuPadre: nuestro Menú va ser tmb SubMenú, Ejemplo:
Ventas	--1	--> 0	MenuPadre(Ventas) 0 xq no tiene padre
-Nuevo	-- 2	--> 1	MenuHijo
-Historial -- 3	--> 1  MenuHijo El submenu 2 y el 3 son hijos del 1 */
)
go

--Tabla MenuRol : para poder relacionarl el Menú con el Rol 
create table MenuRol
(
IdMenuRol int primary key identity(1,1), IdMenu	int references Menu(IdMenu), IdRol	int references Rol(IdRol), Activo	bit default 1
)

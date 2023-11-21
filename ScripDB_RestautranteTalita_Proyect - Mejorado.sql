USE MASTER
GO

CREATE DATABASE dbRestauranteTalita
GO

USE dbRestauranteTalita
GO

--tbl one
CREATE TABLE HLR_tblAdministrador(

	--FUNCIONAL
	Administrador_ID VARCHAR(8) PRIMARY KEY,
	admNombres VARCHAR(40) not null,
	admApPaterno VARCHAR(40) not null,
	admApMaterno VARCHAR(40) null,
	admTelefono VARCHAR(9) not null,
	admEmail VARCHAR(100) not null,
	admDireccion VARCHAR(80) not null,
	admSexo VARCHAR(1) not null,
	admSueldo MONEY not null,

	--AUDITORIA CREACIÓN
	HLR_admUsuarioID_C VARCHAR(15),
	HLR_admFecha_C DATE,
	HLR_admHora_C TIME,
	HLR_admLugar_C VARCHAR(50),

	--AUDITORIA ACTUALIZACIÓN
	HLR_admUsuarioID_A VARCHAR(15),
	HLR_admFecha_A DATE,
	HLR_admHora_A TIME,
	HLR_admLugar_A VARCHAR(50)
)


--tbl two
CREATE TABLE HLR_tblPago(

	--FUNCIONAL
	Pago_ID VARCHAR(8) PRIMARY KEY,
	pagTipo VARCHAR(80) not null,
	pagNumero VARCHAR(30) null,
	pagMonto MONEY not null,

	--AUDITORIA CREACIÓN
	HLR_pagUsuarioID_C VARCHAR(15),
	HLR_pagFecha_C DATE,
	HLR_pagHora_C TIME,
	HLR_pagLugar_C VARCHAR(50),

	--AUDITORIA ACTUALIZACIÓN
	HLR_pagUsuarioID_A VARCHAR(15),
	HLR_pagFecha_A DATE,
	HLR_pagHora_A TIME,
	HLR_pagLugar_A VARCHAR(50)
)

--tbl three
CREATE TABLE HLR_tblMenu(

	--FUNCIONAL
	Menu_ID VARCHAR(8) PRIMARY KEY,
	MenuNombre VARCHAR(40) not null,
	MenuDescripcion VARCHAR(120) not null,
	MenuTipo VARCHAR(80) not null,
	MenuCantidad INT not null,
	MenuPrecio MONEY not null,

	--AUDITORIA CREACIÓN
	HLR_MenuUsuarioID_C VARCHAR(15),
	HLR_MenuFecha_C DATE,
	HLR_MenuHora_C TIME,
	HLR_MenuLugar_C VARCHAR(50),

	--AUDITORIA ACTUALIZACIÓN
	HLR_MenuUsuarioID_A VARCHAR(15),
	HLR_MenuFecha_A DATE,
	HLR_MenuHora_A TIME,
	HLR_MenuLugar_A VARCHAR(50)
)

--tbl four
CREATE TABLE HLR_tblComprobante
(
	--FUNCIONAL
	Comprobante_ID VARCHAR(8) PRIMARY KEY,
	comNumPedido VARCHAR(8) not null,
	comNumPago VARCHAR(8) not null,
	comCliente VARCHAR(80) not null,
	comDNI VARCHAR(10) not null,
	comPlatillo VARCHAR(40) not null,
	comCantidad INT not null,
	comPUnitario MONEY not null,
	comTipoPago VARCHAR(80) not null,
	comNumero VARCHAR(30) not null,
	comTotal MONEY not null,
	comFecha DATE not null,
	comTipo VARCHAR(8) not null,

	--AUDITORIA CREACIÓN
	HLR_ComprobanteUsuarioID_C VARCHAR(15),
	HLR_ComprobanteFecha_C DATE,
	HLR_ComprobanteHora_C TIME,
	HLR_ComprobanteLugar_C VARCHAR(50),

	--AUDITORIA ACTUALIZACIÓN
	HLR_ComprobanteUsuarioID_A VARCHAR(15),
	HLR_ComprobanteFecha_A DATE,
	HLR_ComprobanteHora_A TIME,
	HLR_Comprobante_A VARCHAR(50)

)

--tbl four
CREATE TABLE HLR_tblTipoPersonal(

	--FUNCIONAL
	TipoPersonal_ID VARCHAR(8) PRIMARY KEY,
	TipPersonalNombres VARCHAR(40) not null,
	TipPersonalApPaterno VARCHAR(40) not null,
	TipPersonalApMaterno VARCHAR(40) null,
	TipPersonalAsignado VARCHAR(60) not null,

	Administrador_ID_FK VARCHAR(8) not null,

	FOREIGN KEY (Administrador_ID_FK) REFERENCES HLR_tblAdministrador(Administrador_ID),

	--AUDITORIA CREACIÓN
	HLR_TipPersonalUsuarioID_C VARCHAR(15),
	HLR_TipPersonalFecha_C DATE,
	HLR_TipPersonalHora_C TIME,
	HLR_TipPersonalLugar_C VARCHAR(50),

	--AUDITORIA ACTUALIZACIÓN
	HLR_TipPersonalUsuarioID_A VARCHAR(15),
	HLR_TipPersonalFecha_A DATE,
	HLR_TipPersonalHora_A TIME,
	HLR_TipPersonalLugar_A VARCHAR(50)
)

--tbl five
CREATE TABLE HLR_tblCliente(

	--FUNCIONAL
	cli_ID VARCHAR(8) PRIMARY KEY,
	cliNombres VARCHAR(40) not null,
	cliApPaterno VARCHAR(40) not null,
	cliApMaterno VARCHAR(40) null,
	cliTipo VARCHAR(40) not null,
	cliTelefono VARCHAR(9) not null,
	cliEmail VARCHAR(100) not null,
	cliDireccion VARCHAR(100) not null,
	cliSexo VARCHAR(2) not null,

	--AUDITORIA CREACIÓN
	HLR_cliUsuarioID_C VARCHAR(15),
	HLR_cliFecha_C DATE,
	HLR_cliHora_C TIME,
	HLR_cliLugar_C VARCHAR(50),

	--AUDITORIA ACTUALIZACIÓN
	HLR_cliUsuarioID_A VARCHAR(15),
	HLR_cliFecha_A DATE,
	HLR_cliHora_A TIME,
	HLR_cliLugar_A VARCHAR(50)
)

--tbl six
CREATE TABLE HLR_tblPersonal(

	--FUNCIONAL
	Personal_ID VARCHAR(8) PRIMARY KEY,
	perNombres VARCHAR(40) not null,
	perApPaterno VARCHAR(40) not null,
	perApMaterno VARCHAR(40) null,
	perTelefono VARCHAR(9) not null,
	perEmail VARCHAR(100) not null,
	perDireccion VARCHAR(120) not null,
	perSexo VARCHAR(2) not null,
	perSueldo MONEY not null,

	TipoPersonal_ID_FK VARCHAR(8) not null,

	FOREIGN KEY (TipoPersonal_ID_FK) REFERENCES HLR_tblTipoPersonal(TipoPersonal_ID),

	--AUDITORIA CREACIÓN
	HLR_perUsuarioID_C VARCHAR(15),
	HLR_perFecha_C DATE,
	HLR_perHora_C TIME,
	HLR_perLugar_C VARCHAR(50),

	--AUDITORIA ACTUALIZACIÓN
	HLR_perUsuarioID_A VARCHAR(15),
	HLR_perFecha_A DATE,
	HLR_perHora_A TIME,
	HLR_perLugar_A VARCHAR(50)
)

--tbl seven
CREATE TABLE HLR_tblVenta(

	--FUNCIONAL
	Venta_ID VARCHAR(8) PRIMARY KEY,
	venDetalle VARCHAR(80) not null,
	venFecha DATE not null,
	venPrecioUnitario MONEY not null,
	venCantidad INT not null,
	venTipoComprobante VARCHAR(15) not null,
	venMontoTotal MONEY not null,

	Personal_ID_FK VARCHAR(8) not null,
	Comprobante_ID_FK VARCHAR(8) not null,

	FOREIGN KEY (Personal_ID_FK) REFERENCES HLR_tblPersonal(Personal_ID),
	FOREIGN KEY (Comprobante_ID_FK) REFERENCES HLR_tblComprobante(Comprobante_ID),

	--AUDITORIA CREACION
	HLR_venUsuarioID_C VARCHAR(15),
	HLR_venFecha_C DATE,
	HLR_venHora_C TIME,
	HLR_venLugar_C VARCHAR(50),

	--AUDITORIA ACTUALIZACIÓN
	HLR_venUsuarioID_A VARCHAR(15),
	HLR_venFecha_A DATE,
	HLR_venHora_A TIME,
	HLR_venLugar_A VARCHAR(50)
)

--tbl eight ACÁ PUSE LA RELACIÓN DE PAGO CON PEDIDO Y QUITE ESA RELACION DE CLIENTE
CREATE TABLE HLR_tblPedido(

	--FUNCIONAL
	Pedido_ID VARCHAR(8) PRIMARY KEY,
	pedNomCliente VARCHAR(80) not null,
	pedCliDNI VARCHAR(10) not null,
	pedFecha DATE not null,
	pedPlatillo VARCHAR(40) not null,
	pedCantidad INT not null,
	pedMonto MONEY not null,

	Pago_ID_FK VARCHAR(8),

	FOREIGN KEY (Pago_ID_FK) REFERENCES HLR_tblPago(Pago_ID),

	--AUDITORIA CREACIÓN
	HLR_pedUsuarioID_C VARCHAR(15),
	HLR_pedFecha_C DATE,
	HLR_pedHora_C TIME,
	HLR_pedLugar_C VARCHAR(50),

	--AUDITORIA ACTUALIZACIÓN
	HLR_pedUsuarioID_A VARCHAR(15),
	HLR_pedFecha_A DATE,
	HLR_pedHora_A TIME,
	HLR_pedLugar_A VARCHAR(50)
)

CREATE TABLE HLR_VentaxPedido(
	Pedido_ID_FK VARCHAR(8) not null,
	Venta_ID_FK VARCHAR(8) not null,

	FOREIGN KEY (Pedido_ID_FK) REFERENCES HLR_tblPedido(Pedido_ID),
	FOREIGN KEY (Venta_ID_FK) REFERENCES HLR_tblVenta(Venta_ID),
	PRIMARY KEY (Pedido_ID_FK, Venta_ID_FK)
)

--tbl nine
CREATE TABLE HLR_ClientexPedido(
	--FUNCIONAL
	cli_ID_FK VARCHAR(8) not null,
	Pedido_ID_FK VARCHAR(8) not null,

	FOREIGN KEY (cli_ID_FK) REFERENCES HLR_tblCliente(cli_ID),
	FOREIGN KEY (Pedido_ID_FK) REFERENCES HLR_tblPedido(Pedido_ID),
	PRIMARY KEY (cli_ID_FK, Pedido_ID_FK)
)

--tbl ten
CREATE TABLE HLR_MenuxPedido(
	--FUNCIONAL
	Menu_ID_FK VARCHAR(8) not null,
	Pedido_ID_FK VARCHAR(8) not null,

	FOREIGN KEY (Menu_ID_FK) REFERENCES HLR_tblMenu(Menu_ID),
	FOREIGN KEY (Pedido_ID_FK) REFERENCES HLR_tblPedido(Pedido_ID),
	PRIMARY KEY (Menu_ID_FK, Pedido_ID_FK)
)
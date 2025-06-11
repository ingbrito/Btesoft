
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/07/2025 14:16:16
-- Generated from EDMX file: C:\Users\hensel.brito\Downloads\Sistema Dental\DentSoft Update General\GruDent\DentSoft\Model\GrudentAdo.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [GRUDENT];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__RolesPerm__IdPer__40F9A68C]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolesPermisos] DROP CONSTRAINT [FK__RolesPerm__IdPer__40F9A68C];
GO
IF OBJECT_ID(N'[dbo].[FK__RolesPerm__IdRol__40058253]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolesPermisos] DROP CONSTRAINT [FK__RolesPerm__IdRol__40058253];
GO
IF OBJECT_ID(N'[dbo].[FK_Citas_Doctor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Citas] DROP CONSTRAINT [FK_Citas_Doctor];
GO
IF OBJECT_ID(N'[dbo].[FK_Citas_Paciente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Citas] DROP CONSTRAINT [FK_Citas_Paciente];
GO
IF OBJECT_ID(N'[dbo].[FK_PermisosRol_Permisos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PermisosRol] DROP CONSTRAINT [FK_PermisosRol_Permisos];
GO
IF OBJECT_ID(N'[dbo].[FK_PermisosRol_Roles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PermisosRol] DROP CONSTRAINT [FK_PermisosRol_Roles];
GO
IF OBJECT_ID(N'[dbo].[FK_Usuario_Roles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Usuario] DROP CONSTRAINT [FK_Usuario_Roles];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Citas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Citas];
GO
IF OBJECT_ID(N'[dbo].[Consulta]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Consulta];
GO
IF OBJECT_ID(N'[dbo].[Diagnostico]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Diagnostico];
GO
IF OBJECT_ID(N'[dbo].[Doctores]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Doctores];
GO
IF OBJECT_ID(N'[dbo].[Empresa]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Empresa];
GO
IF OBJECT_ID(N'[dbo].[Facturas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Facturas];
GO
IF OBJECT_ID(N'[dbo].[HistoricoPago]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HistoricoPago];
GO
IF OBJECT_ID(N'[dbo].[Paciente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Paciente];
GO
IF OBJECT_ID(N'[dbo].[PacienteN]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PacienteN];
GO
IF OBJECT_ID(N'[dbo].[Permisos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Permisos];
GO
IF OBJECT_ID(N'[dbo].[PermisosRol]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PermisosRol];
GO
IF OBJECT_ID(N'[dbo].[Procedimientos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Procedimientos];
GO
IF OBJECT_ID(N'[dbo].[Procesos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Procesos];
GO
IF OBJECT_ID(N'[dbo].[Roles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Roles];
GO
IF OBJECT_ID(N'[dbo].[RolesPermisos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RolesPermisos];
GO
IF OBJECT_ID(N'[dbo].[Usuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuario];
GO
IF OBJECT_ID(N'[GRUDENTModelStoreContainer].[Cotizacion]', 'U') IS NOT NULL
    DROP TABLE [GRUDENTModelStoreContainer].[Cotizacion];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Consulta'
CREATE TABLE [dbo].[Consulta] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [IdDoctor] int  NULL,
    [IdPaciente] int  NULL,
    [NombrePaciente] varchar(100)  NULL,
    [Edad] varchar(100)  NULL,
    [Sexo] varchar(100)  NULL,
    [Fecha] datetime  NULL,
    [NombreDoctor] varchar(100)  NULL,
    [Motivo] varchar(150)  NULL,
    [Diagnostico] varchar(150)  NULL,
    [Procedimiento] varchar(150)  NULL,
    [Observaciones] varchar(150)  NULL,
    [Indicaciones] varchar(150)  NULL,
    [Foto] varbinary(max)  NULL,
    [Plan_Tratamiento] varchar(150)  NULL,
    [imagen_odontograma] varbinary(max)  NULL
);
GO

-- Creating table 'Diagnostico'
CREATE TABLE [dbo].[Diagnostico] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Nombre] varchar(150)  NULL,
    [Descripcion] varchar(150)  NULL
);
GO

-- Creating table 'Doctores'
CREATE TABLE [dbo].[Doctores] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Nombres] varchar(50)  NULL,
    [PrimerApellido] varchar(50)  NULL,
    [SegundoApellido] varchar(50)  NOT NULL,
    [CorreoElectronico] varchar(50)  NULL,
    [Especialidad] varchar(100)  NULL,
    [Telefono] varchar(20)  NULL,
    [Celular] varchar(20)  NULL,
    [Direccion] varchar(100)  NULL
);
GO

-- Creating table 'PacienteN'
CREATE TABLE [dbo].[PacienteN] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Documento] varchar(50)  NULL,
    [Nombres] varchar(50)  NULL,
    [PrimerApellido] varchar(50)  NULL,
    [SegundoApellido] varchar(50)  NOT NULL,
    [Sexo] varchar(50)  NULL,
    [FechaDeNacimiento] datetime  NULL,
    [EstadoCivil] varchar(50)  NULL,
    [GrupoSanguineo] varchar(50)  NULL,
    [ARS] varchar(50)  NULL,
    [NSS] varchar(50)  NULL,
    [CorreoElectronico] varchar(50)  NULL,
    [Telefono] varchar(20)  NULL,
    [Celular] varchar(20)  NULL,
    [Direccion] varchar(100)  NULL,
    [Foto] varbinary(max)  NULL,
    [TutorNombre] varchar(100)  NULL,
    [TutorTelefono] varchar(15)  NULL,
    [TutorCedula] varchar(20)  NULL
);
GO

-- Creating table 'Procedimientos'
CREATE TABLE [dbo].[Procedimientos] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Nombre] varchar(150)  NULL,
    [Descripcion] varchar(150)  NULL,
    [Costo] float  NULL
);
GO

-- Creating table 'Procesos'
CREATE TABLE [dbo].[Procesos] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [IdPaciente] int  NULL,
    [IdDoctor] int  NULL,
    [IdProceso] int  NULL,
    [Fecha] datetime  NULL,
    [Proceso] varchar(500)  NULL,
    [Costo] float  NULL,
    [Pago] float  NULL,
    [Pendiente] float  NULL,
    [NombrePaciente] varchar(150)  NULL,
    [NombreDoctor] varchar(150)  NULL,
    [Estatus] varchar(150)  NULL
);
GO

-- Creating table 'Facturas'
CREATE TABLE [dbo].[Facturas] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [IdCliente] int  NULL,
    [NombreCliente] varchar(50)  NULL,
    [EdadCliente] int  NULL,
    [SexoCliente] varchar(150)  NULL,
    [NombreDoctor] varchar(150)  NULL,
    [EspecialidadDoctor] varchar(150)  NULL,
    [Procesos] varchar(150)  NULL,
    [Costo] float  NULL,
    [Descuento] float  NULL,
    [Pago] float  NULL,
    [Total] float  NULL,
    [Estatus] varchar(50)  NULL,
    [Fecha] datetime  NULL
);
GO

-- Creating table 'HistoricoPago'
CREATE TABLE [dbo].[HistoricoPago] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [IdFactura] int  NULL,
    [Deuda] float  NULL,
    [Abono] float  NULL,
    [Resto] float  NULL,
    [Fecha] datetime  NULL,
    [Comentario] varchar(250)  NULL
);
GO

-- Creating table 'Usuario'
CREATE TABLE [dbo].[Usuario] (
    [UserID] int IDENTITY(1,1) NOT NULL,
    [LoginName] nvarchar(100)  NOT NULL,
    [Password] nvarchar(100)  NOT NULL,
    [Nombre] nvarchar(100)  NOT NULL,
    [Apellido] nvarchar(100)  NOT NULL,
    [Email] nvarchar(150)  NOT NULL,
    [IdRol] int  NULL
);
GO

-- Creating table 'Paciente'
CREATE TABLE [dbo].[Paciente] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Documento] varchar(50)  NULL,
    [Nombres] varchar(50)  NULL,
    [PrimerApellido] varchar(50)  NULL,
    [SegundoApellido] varchar(50)  NOT NULL,
    [Sexo] varchar(20)  NULL,
    [FechaDeNacimiento] datetime  NULL,
    [EstadoCivil] varchar(50)  NULL,
    [GrupoSanguineo] varchar(50)  NULL,
    [ARS] varchar(50)  NULL,
    [NSS] varchar(50)  NULL,
    [CorreoElectronico] varchar(50)  NULL,
    [Telefono] varchar(20)  NULL,
    [Celular] varchar(20)  NULL,
    [Direccion] varchar(100)  NULL,
    [Foto] varbinary(max)  NULL
);
GO

-- Creating table 'Citas'
CREATE TABLE [dbo].[Citas] (
    [IdCita] int IDENTITY(1,1) NOT NULL,
    [IdPaciente] int  NOT NULL,
    [IdDoctor] int  NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Hora] time  NOT NULL,
    [Observacion] nvarchar(500)  NULL,
    [EstadoCita] nvarchar(50)  NULL,
    [FechaRegistro] datetime  NULL
);
GO

-- Creating table 'Empresa'
CREATE TABLE [dbo].[Empresa] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nombre] varchar(50)  NULL,
    [direccion] varchar(150)  NULL,
    [telefono] varchar(15)  NULL,
    [correo] nvarchar(50)  NULL,
    [rnc] varchar(15)  NULL
);
GO

-- Creating table 'Permisos'
CREATE TABLE [dbo].[Permisos] (
    [IdPermiso] int IDENTITY(1,1) NOT NULL,
    [NombreFuncion] varchar(50)  NOT NULL
);
GO

-- Creating table 'Roles'
CREATE TABLE [dbo].[Roles] (
    [IdRol] int IDENTITY(1,1) NOT NULL,
    [NombreRol] varchar(50)  NOT NULL
);
GO

-- Creating table 'Cotizacion'
CREATE TABLE [dbo].[Cotizacion] (
    [ID] int  NULL,
    [numeroCotizacion] int IDENTITY(1,1) NOT NULL,
    [nombrePaciente] varchar(50)  NULL,
    [correo] varchar(50)  NULL,
    [telefono] varchar(50)  NULL,
    [fecha] datetime  NULL,
    [descripcion] varchar(50)  NULL,
    [cantidad] int  NULL,
    [precio] float  NULL,
    [subtotal] float  NULL,
    [descuento] int  NULL,
    [total] float  NULL
);
GO

-- Creating table 'RolesPermisos'
CREATE TABLE [dbo].[RolesPermisos] (
    [Permisos_IdPermiso] int  NOT NULL,
    [Roles_IdRol] int  NOT NULL
);
GO

-- Creating table 'PermisosRol'
CREATE TABLE [dbo].[PermisosRol] (
    [PermisosRol_Roles_IdPermiso] int  NOT NULL,
    [PermisosRol_Permisos_IdRol] int  NOT NULL
);
GO

-- Creating table 'RolPermiso'
CREATE TABLE [dbo].[RolPermiso] (
    [RolPermiso_Roles_IdPermiso] int  NOT NULL,
    [RolPermiso_Permisos_IdRol] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'Consulta'
ALTER TABLE [dbo].[Consulta]
ADD CONSTRAINT [PK_Consulta]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Diagnostico'
ALTER TABLE [dbo].[Diagnostico]
ADD CONSTRAINT [PK_Diagnostico]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Doctores'
ALTER TABLE [dbo].[Doctores]
ADD CONSTRAINT [PK_Doctores]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'PacienteN'
ALTER TABLE [dbo].[PacienteN]
ADD CONSTRAINT [PK_PacienteN]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Procedimientos'
ALTER TABLE [dbo].[Procedimientos]
ADD CONSTRAINT [PK_Procedimientos]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Procesos'
ALTER TABLE [dbo].[Procesos]
ADD CONSTRAINT [PK_Procesos]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Facturas'
ALTER TABLE [dbo].[Facturas]
ADD CONSTRAINT [PK_Facturas]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'HistoricoPago'
ALTER TABLE [dbo].[HistoricoPago]
ADD CONSTRAINT [PK_HistoricoPago]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [UserID] in table 'Usuario'
ALTER TABLE [dbo].[Usuario]
ADD CONSTRAINT [PK_Usuario]
    PRIMARY KEY CLUSTERED ([UserID] ASC);
GO

-- Creating primary key on [ID] in table 'Paciente'
ALTER TABLE [dbo].[Paciente]
ADD CONSTRAINT [PK_Paciente]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [IdCita] in table 'Citas'
ALTER TABLE [dbo].[Citas]
ADD CONSTRAINT [PK_Citas]
    PRIMARY KEY CLUSTERED ([IdCita] ASC);
GO

-- Creating primary key on [id] in table 'Empresa'
ALTER TABLE [dbo].[Empresa]
ADD CONSTRAINT [PK_Empresa]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [IdPermiso] in table 'Permisos'
ALTER TABLE [dbo].[Permisos]
ADD CONSTRAINT [PK_Permisos]
    PRIMARY KEY CLUSTERED ([IdPermiso] ASC);
GO

-- Creating primary key on [IdRol] in table 'Roles'
ALTER TABLE [dbo].[Roles]
ADD CONSTRAINT [PK_Roles]
    PRIMARY KEY CLUSTERED ([IdRol] ASC);
GO

-- Creating primary key on [numeroCotizacion] in table 'Cotizacion'
ALTER TABLE [dbo].[Cotizacion]
ADD CONSTRAINT [PK_Cotizacion]
    PRIMARY KEY CLUSTERED ([numeroCotizacion] ASC);
GO

-- Creating primary key on [Permisos_IdPermiso], [Roles_IdRol] in table 'RolesPermisos'
ALTER TABLE [dbo].[RolesPermisos]
ADD CONSTRAINT [PK_RolesPermisos]
    PRIMARY KEY CLUSTERED ([Permisos_IdPermiso], [Roles_IdRol] ASC);
GO

-- Creating primary key on [PermisosRol_Roles_IdPermiso], [PermisosRol_Permisos_IdRol] in table 'PermisosRol'
ALTER TABLE [dbo].[PermisosRol]
ADD CONSTRAINT [PK_PermisosRol]
    PRIMARY KEY CLUSTERED ([PermisosRol_Roles_IdPermiso], [PermisosRol_Permisos_IdRol] ASC);
GO

-- Creating primary key on [RolPermiso_Roles_IdPermiso], [RolPermiso_Permisos_IdRol] in table 'RolPermiso'
ALTER TABLE [dbo].[RolPermiso]
ADD CONSTRAINT [PK_RolPermiso]
    PRIMARY KEY CLUSTERED ([RolPermiso_Roles_IdPermiso], [RolPermiso_Permisos_IdRol] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdDoctor] in table 'Citas'
ALTER TABLE [dbo].[Citas]
ADD CONSTRAINT [FK_Citas_Doctor]
    FOREIGN KEY ([IdDoctor])
    REFERENCES [dbo].[Doctores]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Citas_Doctor'
CREATE INDEX [IX_FK_Citas_Doctor]
ON [dbo].[Citas]
    ([IdDoctor]);
GO

-- Creating foreign key on [IdPaciente] in table 'Citas'
ALTER TABLE [dbo].[Citas]
ADD CONSTRAINT [FK_Citas_Paciente]
    FOREIGN KEY ([IdPaciente])
    REFERENCES [dbo].[Paciente]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Citas_Paciente'
CREATE INDEX [IX_FK_Citas_Paciente]
ON [dbo].[Citas]
    ([IdPaciente]);
GO

-- Creating foreign key on [IdRol] in table 'Usuario'
ALTER TABLE [dbo].[Usuario]
ADD CONSTRAINT [FK_Usuario_Roles]
    FOREIGN KEY ([IdRol])
    REFERENCES [dbo].[Roles]
        ([IdRol])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Usuario_Roles'
CREATE INDEX [IX_FK_Usuario_Roles]
ON [dbo].[Usuario]
    ([IdRol]);
GO

-- Creating foreign key on [Permisos_IdPermiso] in table 'RolesPermisos'
ALTER TABLE [dbo].[RolesPermisos]
ADD CONSTRAINT [FK_RolesPermisos_Permisos]
    FOREIGN KEY ([Permisos_IdPermiso])
    REFERENCES [dbo].[Permisos]
        ([IdPermiso])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Roles_IdRol] in table 'RolesPermisos'
ALTER TABLE [dbo].[RolesPermisos]
ADD CONSTRAINT [FK_RolesPermisos_Roles]
    FOREIGN KEY ([Roles_IdRol])
    REFERENCES [dbo].[Roles]
        ([IdRol])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RolesPermisos_Roles'
CREATE INDEX [IX_FK_RolesPermisos_Roles]
ON [dbo].[RolesPermisos]
    ([Roles_IdRol]);
GO

-- Creating foreign key on [PermisosRol_Roles_IdPermiso] in table 'PermisosRol'
ALTER TABLE [dbo].[PermisosRol]
ADD CONSTRAINT [FK_PermisosRol_Permisos]
    FOREIGN KEY ([PermisosRol_Roles_IdPermiso])
    REFERENCES [dbo].[Permisos]
        ([IdPermiso])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [PermisosRol_Permisos_IdRol] in table 'PermisosRol'
ALTER TABLE [dbo].[PermisosRol]
ADD CONSTRAINT [FK_PermisosRol_Roles]
    FOREIGN KEY ([PermisosRol_Permisos_IdRol])
    REFERENCES [dbo].[Roles]
        ([IdRol])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PermisosRol_Roles'
CREATE INDEX [IX_FK_PermisosRol_Roles]
ON [dbo].[PermisosRol]
    ([PermisosRol_Permisos_IdRol]);
GO

-- Creating foreign key on [RolPermiso_Roles_IdPermiso] in table 'RolPermiso'
ALTER TABLE [dbo].[RolPermiso]
ADD CONSTRAINT [FK_RolPermiso_Permisos]
    FOREIGN KEY ([RolPermiso_Roles_IdPermiso])
    REFERENCES [dbo].[Permisos]
        ([IdPermiso])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [RolPermiso_Permisos_IdRol] in table 'RolPermiso'
ALTER TABLE [dbo].[RolPermiso]
ADD CONSTRAINT [FK_RolPermiso_Roles]
    FOREIGN KEY ([RolPermiso_Permisos_IdRol])
    REFERENCES [dbo].[Roles]
        ([IdRol])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RolPermiso_Roles'
CREATE INDEX [IX_FK_RolPermiso_Roles]
ON [dbo].[RolPermiso]
    ([RolPermiso_Permisos_IdRol]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
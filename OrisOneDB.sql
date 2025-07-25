USE [master]
GO
/****** Object:  Database [GRUDENT]    Script Date: 6/20/2025 10:02:14 PM ******/
CREATE DATABASE [GRUDENT]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GRUDENT', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\GRUDENT.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GRUDENT_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\GRUDENT_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [GRUDENT] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GRUDENT].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GRUDENT] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GRUDENT] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GRUDENT] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GRUDENT] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GRUDENT] SET ARITHABORT OFF 
GO
ALTER DATABASE [GRUDENT] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GRUDENT] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GRUDENT] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GRUDENT] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GRUDENT] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GRUDENT] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GRUDENT] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GRUDENT] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GRUDENT] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GRUDENT] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GRUDENT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GRUDENT] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GRUDENT] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GRUDENT] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GRUDENT] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GRUDENT] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GRUDENT] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GRUDENT] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GRUDENT] SET  MULTI_USER 
GO
ALTER DATABASE [GRUDENT] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GRUDENT] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GRUDENT] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GRUDENT] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GRUDENT] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'GRUDENT', N'ON'
GO
ALTER DATABASE [GRUDENT] SET QUERY_STORE = OFF
GO
USE [GRUDENT]
GO
/****** Object:  Table [dbo].[Citas]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Citas](
	[IdCita] [int] IDENTITY(1,1) NOT NULL,
	[IdPaciente] [int] NOT NULL,
	[IdDoctor] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Hora] [time](7) NOT NULL,
	[Observacion] [nvarchar](500) NULL,
	[EstadoCita] [nvarchar](50) NULL,
	[FechaRegistro] [datetime] NULL,
 CONSTRAINT [PK_Citas] PRIMARY KEY CLUSTERED 
(
	[IdCita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Consulta]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Consulta](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IdDoctor] [int] NULL,
	[IdPaciente] [int] NULL,
	[NombrePaciente] [varchar](100) NULL,
	[Edad] [varchar](100) NULL,
	[Sexo] [varchar](100) NULL,
	[Fecha] [datetime] NULL,
	[NombreDoctor] [varchar](100) NULL,
	[Motivo] [varchar](150) NULL,
	[Diagnostico] [varchar](150) NULL,
	[Procedimiento] [varchar](150) NULL,
	[Observaciones] [varchar](150) NULL,
	[Indicaciones] [varchar](150) NULL,
	[Foto] [varbinary](max) NULL,
	[Plan_Tratamiento] [varchar](150) NULL,
	[imagen_odontograma] [varbinary](max) NULL,
 CONSTRAINT [PK_Consulta] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cotizacion]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cotizacion](
	[ID] [int] NULL,
	[numeroCotizacion] [int] IDENTITY(1,1) NOT NULL,
	[nombrePaciente] [varchar](50) NULL,
	[correo] [varchar](50) NULL,
	[telefono] [varchar](50) NULL,
	[fecha] [date] NULL,
	[descripcion] [varchar](50) NULL,
	[cantidad] [int] NULL,
	[precio] [float] NULL,
	[subtotal] [float] NULL,
	[descuento] [int] NULL,
	[total] [float] NULL,
 CONSTRAINT [PK_Cotizacion] PRIMARY KEY CLUSTERED 
(
	[numeroCotizacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diagnostico]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diagnostico](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](150) NULL,
	[Descripcion] [varchar](150) NULL,
 CONSTRAINT [PK_Diagnostico] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctores]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctores](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [varchar](50) NULL,
	[PrimerApellido] [varchar](50) NULL,
	[SegundoApellido] [varchar](50) NOT NULL,
	[CorreoElectronico] [varchar](50) NULL,
	[Especialidad] [varchar](100) NULL,
	[Telefono] [varchar](20) NULL,
	[Celular] [varchar](20) NULL,
	[Direccion] [varchar](100) NULL,
 CONSTRAINT [PK_Doctores] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empresa]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empresa](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[direccion] [varchar](150) NULL,
	[telefono] [varchar](15) NULL,
	[correo] [nvarchar](50) NULL,
	[rnc] [varchar](15) NULL,
 CONSTRAINT [PK_Empresa] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facturas]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NULL,
	[NombreCliente] [varchar](50) NULL,
	[EdadCliente] [int] NULL,
	[SexoCliente] [varchar](150) NULL,
	[NombreDoctor] [varchar](150) NULL,
	[EspecialidadDoctor] [varchar](150) NULL,
	[Procesos] [varchar](150) NULL,
	[Costo] [float] NULL,
	[Descuento] [float] NULL,
	[Pago] [float] NULL,
	[Total] [float] NULL,
	[Estatus] [varchar](50) NULL,
	[Fecha] [datetime] NULL,
 CONSTRAINT [PK_Facturas] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HistoricoPago]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HistoricoPago](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IdFactura] [int] NULL,
	[Deuda] [float] NULL,
	[Abono] [float] NULL,
	[Resto] [float] NULL,
	[Fecha] [datetime] NULL,
	[Comentario] [varchar](250) NULL,
 CONSTRAINT [PK_HistoricoPago] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paciente]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paciente](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Documento] [varchar](50) NULL,
	[Nombres] [varchar](50) NULL,
	[PrimerApellido] [varchar](50) NULL,
	[SegundoApellido] [varchar](50) NOT NULL,
	[Sexo] [varchar](20) NULL,
	[FechaDeNacimiento] [datetime] NULL,
	[EstadoCivil] [varchar](50) NULL,
	[GrupoSanguineo] [varchar](50) NULL,
	[ARS] [varchar](50) NULL,
	[NSS] [varchar](50) NULL,
	[CorreoElectronico] [varchar](50) NULL,
	[Telefono] [varchar](20) NULL,
	[Celular] [varchar](20) NULL,
	[Direccion] [varchar](100) NULL,
	[Foto] [varbinary](max) NULL,
 CONSTRAINT [PK_Paciente] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PacienteN]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PacienteN](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Documento] [varchar](50) NULL,
	[Nombres] [varchar](50) NULL,
	[PrimerApellido] [varchar](50) NULL,
	[SegundoApellido] [varchar](50) NOT NULL,
	[Sexo] [varchar](50) NULL,
	[FechaDeNacimiento] [datetime] NULL,
	[EstadoCivil] [varchar](50) NULL,
	[GrupoSanguineo] [varchar](50) NULL,
	[ARS] [varchar](50) NULL,
	[NSS] [varchar](50) NULL,
	[CorreoElectronico] [varchar](50) NULL,
	[Telefono] [varchar](20) NULL,
	[Celular] [varchar](20) NULL,
	[Direccion] [varchar](100) NULL,
	[Foto] [varbinary](max) NULL,
	[TutorNombre] [varchar](100) NULL,
	[TutorTelefono] [varchar](15) NULL,
	[TutorCedula] [varchar](20) NULL,
 CONSTRAINT [PK_PacienteN] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permisos]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permisos](
	[IdPermiso] [int] IDENTITY(1,1) NOT NULL,
	[NombreFuncion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Permisos] PRIMARY KEY CLUSTERED 
(
	[IdPermiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PermisosRol]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PermisosRol](
	[PermisosRol_Roles_IdPermiso] [int] NOT NULL,
	[PermisosRol_Permisos_IdRol] [int] NOT NULL,
 CONSTRAINT [PK_PermisosRol] PRIMARY KEY CLUSTERED 
(
	[PermisosRol_Roles_IdPermiso] ASC,
	[PermisosRol_Permisos_IdRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Procedimientos]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Procedimientos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](150) NULL,
	[Descripcion] [varchar](150) NULL,
	[Costo] [float] NULL,
 CONSTRAINT [PK_Procedimientos] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Procesos]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Procesos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IdPaciente] [int] NULL,
	[IdDoctor] [int] NULL,
	[IdProceso] [int] NULL,
	[Fecha] [datetime] NULL,
	[Proceso] [varchar](500) NULL,
	[Costo] [float] NULL,
	[Pago] [float] NULL,
	[Pendiente] [float] NULL,
	[NombrePaciente] [varchar](150) NULL,
	[NombreDoctor] [varchar](150) NULL,
	[Estatus] [varchar](150) NULL,
 CONSTRAINT [PK_Procesos] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[IdRol] [int] IDENTITY(1,1) NOT NULL,
	[NombreRol] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[IdRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RolesPermisos]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RolesPermisos](
	[Permisos_IdPermiso] [int] NOT NULL,
	[Roles_IdRol] [int] NOT NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_RolesPermisos] PRIMARY KEY CLUSTERED 
(
	[Permisos_IdPermiso] ASC,
	[Roles_IdRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[LoginName] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Apellido] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](150) NOT NULL,
	[IdRol] [int] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Citas_Doctor]    Script Date: 6/20/2025 10:02:14 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Citas_Doctor] ON [dbo].[Citas]
(
	[IdDoctor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Citas_Paciente]    Script Date: 6/20/2025 10:02:14 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Citas_Paciente] ON [dbo].[Citas]
(
	[IdPaciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_PermisosRol_Roles]    Script Date: 6/20/2025 10:02:14 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_PermisosRol_Roles] ON [dbo].[PermisosRol]
(
	[PermisosRol_Permisos_IdRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_RolesPermisos_Roles]    Script Date: 6/20/2025 10:02:14 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_RolesPermisos_Roles] ON [dbo].[RolesPermisos]
(
	[Roles_IdRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Usuario_Roles]    Script Date: 6/20/2025 10:02:14 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Usuario_Roles] ON [dbo].[Usuario]
(
	[IdRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[RolesPermisos] ADD  DEFAULT ((1)) FOR [Activo]
GO
ALTER TABLE [dbo].[Citas]  WITH CHECK ADD  CONSTRAINT [FK_Citas_Doctor] FOREIGN KEY([IdDoctor])
REFERENCES [dbo].[Doctores] ([ID])
GO
ALTER TABLE [dbo].[Citas] CHECK CONSTRAINT [FK_Citas_Doctor]
GO
ALTER TABLE [dbo].[Citas]  WITH CHECK ADD  CONSTRAINT [FK_Citas_Paciente] FOREIGN KEY([IdPaciente])
REFERENCES [dbo].[Paciente] ([ID])
GO
ALTER TABLE [dbo].[Citas] CHECK CONSTRAINT [FK_Citas_Paciente]
GO
ALTER TABLE [dbo].[PermisosRol]  WITH CHECK ADD  CONSTRAINT [FK_PermisosRol_Permisos] FOREIGN KEY([PermisosRol_Roles_IdPermiso])
REFERENCES [dbo].[Permisos] ([IdPermiso])
GO
ALTER TABLE [dbo].[PermisosRol] CHECK CONSTRAINT [FK_PermisosRol_Permisos]
GO
ALTER TABLE [dbo].[PermisosRol]  WITH CHECK ADD  CONSTRAINT [FK_PermisosRol_Roles] FOREIGN KEY([PermisosRol_Permisos_IdRol])
REFERENCES [dbo].[Roles] ([IdRol])
GO
ALTER TABLE [dbo].[PermisosRol] CHECK CONSTRAINT [FK_PermisosRol_Roles]
GO
ALTER TABLE [dbo].[RolesPermisos]  WITH CHECK ADD  CONSTRAINT [FK_RolesPermisos_Permisos] FOREIGN KEY([Permisos_IdPermiso])
REFERENCES [dbo].[Permisos] ([IdPermiso])
GO
ALTER TABLE [dbo].[RolesPermisos] CHECK CONSTRAINT [FK_RolesPermisos_Permisos]
GO
ALTER TABLE [dbo].[RolesPermisos]  WITH CHECK ADD  CONSTRAINT [FK_RolesPermisos_Roles] FOREIGN KEY([Roles_IdRol])
REFERENCES [dbo].[Roles] ([IdRol])
GO
ALTER TABLE [dbo].[RolesPermisos] CHECK CONSTRAINT [FK_RolesPermisos_Roles]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Roles] FOREIGN KEY([IdRol])
REFERENCES [dbo].[Roles] ([IdRol])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Roles]
GO
/****** Object:  StoredProcedure [dbo].[sp_DelDiagnostico]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_DelDiagnostico] (
@cod int
)
as
delete from Diagnostico where ID=@cod

GO
/****** Object:  StoredProcedure [dbo].[sp_DelDoctores]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_DelDoctores](
@cod int
)
as
delete from Doctores where ID=@cod

GO
/****** Object:  StoredProcedure [dbo].[sp_DelFactura]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_DelFactura](
@cod int
)
as
delete from Facturas where ID=@cod
GO
/****** Object:  StoredProcedure [dbo].[sp_DelPaciente]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_DelPaciente](
@cod int
)
as 
delete from Paciente where ID = @cod

GO
/****** Object:  StoredProcedure [dbo].[sp_DelPacienteN]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_DelPacienteN](
@cod int
)
as 
delete from PacienteN where ID = @cod
GO
/****** Object:  StoredProcedure [dbo].[sp_DelPago]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_DelPago](
@cod int
)
as
delete from HistoricoPago where ID=@cod
GO
/****** Object:  StoredProcedure [dbo].[sp_DelProcedimientos]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_DelProcedimientos](
@cod int
)
as
delete from Procedimientos where ID=@cod

GO
/****** Object:  StoredProcedure [dbo].[sp_DelUsuario]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_DelUsuario](
@cod int
)
as 
delete from Usuario where UserID = @cod
GO
/****** Object:  StoredProcedure [dbo].[sp_HistCons]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_HistCons](
  @idb int
  )
  as
  select ID,NombrePaciente,Edad,Sexo,NombreDoctor,Motivo,Diagnostico,Procedimiento,Observaciones,Indicaciones,Fecha from Consulta where IdPaciente = @idb
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarCita]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertarCita]
    @IdPaciente INT,
    @IdDoctor INT,
    @Fecha DATE,
    @Hora TIME,
    @Observacion NVARCHAR(300),
    @EstadoCita NVARCHAR(50),
    @FechaRegistro DATETIME
AS
BEGIN
    INSERT INTO Citas (IdPaciente, IdDoctor, Fecha, Hora, Observacion, EstadoCita, FechaRegistro)
    VALUES (@IdPaciente, @IdDoctor, @Fecha, @Hora, @Observacion, @EstadoCita, @FechaRegistro)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertCotizacion]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_InsertCotizacion](
@numeroCotizacion int,
@nombrePaciente varchar(250),
@correo varchar(250),
@telefono varchar(250),
@fecha datetime,
@descripcion varchar(250),
@cantidad int,
@precio float,
@subtotal float,
@descuento int,
@total float
)
as
insert into Cotizacion values (@numeroCotizacion,@nombrePaciente,@correo,@telefono,@fecha,@descripcion,@cantidad,@precio,@subtotal,@descuento,@total);
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertDiagnostico]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_InsertDiagnostico] (
@nom varchar(50),
@descp varchar(100)
)
as
insert into Diagnostico values (@nom,@descp)

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertDoctores]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_InsertDoctores](
	@nom varchar(50),
	@papellido varchar(50),
	@sapellido varchar(50),
	@email varchar(50),
	@esp varchar(50),
	@tel varchar(50),
	@cel varchar(50),
	@dir varchar(50))

as insert into Doctores values (@nom,@papellido,@sapellido,@email,@esp,@tel,@tel,@dir)
GO
/****** Object:  StoredProcedure [dbo].[Sp_InsertFactura]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Sp_InsertFactura](
@idcte int,
@nomcte varchar(150),
@edad int,
@sexo varchar(150),
@nomdoctor varchar(150),
@especialidad varchar(150),
@procesos varchar(500),
@costo float,
@descuento float,
@pago float,
@total float,
@estatus varchar(150),
@fecha datetime
)
as
insert into Facturas values (@idcte,@nomcte,@edad,@sexo,@nomdoctor,@especialidad,@procesos,@costo,@descuento,@pago,@total,@estatus,@fecha);
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertfichaConsult]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertfichaConsult]
    @nombre NVARCHAR(50),
    @edad INT,
    @sexo NVARCHAR(10),
    @fechaconsulta DATE,
    @motivo NVARCHAR(255),
    @plan_tratamiento NVARCHAR(MAX),
    @fichaconsulta NVARCHAR(MAX),
    @indicacion NVARCHAR(MAX),
    @process NVARCHAR(MAX),
    @diagnosti NVARCHAR(MAX),
    @imagen_odontograma VARBINARY(MAX) -- 👈 Nuevo parámetro
AS
BEGIN
    INSERT INTO FichaConsulta
    (
        nombre, edad, sexo, fechaconsulta, motivo,
        plan_tratamiento, fichaconsulta, indicacion,
        process, diagnosti, imagen_odontograma
    )
    VALUES
    (
        @nombre, @edad, @sexo, @fechaconsulta, @motivo,
        @plan_tratamiento, @fichaconsulta, @indicacion,
        @process, @diagnosti, @imagen_odontograma
    )
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertPaciente]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_InsertPaciente](
@doc varchar (50),
@nom varchar (50),
@papellido varchar (50),
@sapellido varchar (50),
@sexo varchar (50),
@fechanac datetime,
@estadoc varchar (50),
@gposanguineo varchar (50),
@ars varchar (50),
@nss varchar (50),
@email varchar (50),
@telefono varchar (50),
@celular varchar (50),
@direccion varchar (50)
)
as 
insert into Paciente(Documento,Nombres,PrimerApellido,SegundoApellido,Sexo,FechaDeNacimiento,EstadoCivil,GrupoSanguineo,ARS,NSS,CorreoElectronico,Telefono,Celular,Direccion)
values (@doc ,@nom ,@papellido ,@sapellido ,@sexo,@fechanac ,@estadoc,@gposanguineo,@ars ,@nss ,@email ,@telefono , @celular ,@direccion)

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertPacienteN]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_InsertPacienteN](
@doc varchar (50),
@nom varchar (50),
@papellido varchar (50),
@sapellido varchar (50),
@sexo varchar (50),
@fechanac datetime,
@estadoc varchar (50),
@gposanguineo varchar (50),
@ars varchar (50),
@nss varchar (50),
@email varchar (50),
@telefono varchar (50),
@celular varchar (50),
@direccion varchar (50),
@tutorn varchar(50),
@tutorc varchar(15),
@tutort varchar(20)
)
as 
insert into PacienteN(Documento,Nombres,PrimerApellido,SegundoApellido,Sexo,FechaDeNacimiento,EstadoCivil,GrupoSanguineo,ARS,NSS,CorreoElectronico,Telefono,Celular,Direccion,TutorNombre,TutorCedula,TutorTelefono)
values (@doc,@nom,@papellido,@sapellido,@sexo,@fechanac,@estadoc,@gposanguineo,@ars,@nss,@email,@telefono,@celular,@direccion,@tutorn,@tutorc,@tutort)

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertPago]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_InsertPago](
@idfactura int,
@deuda float,
@abono float,
@resto float,
@fecha datetime,
@comentario varchar(250)
)
as
insert into HistoricoPago values (@idfactura,@deuda,@abono,@resto,@fecha,@comentario);
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertProcedimientos]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_InsertProcedimientos](
@nom varchar (50),
@descp varchar (50),
@costo float
)
as
insert into Procedimientos values (@nom,@descp,@costo)
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertUsuario]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_InsertUsuario](
@loginName varchar (50),
@password varchar (50),
@nombre varchar (50),
@apellido varchar (50),
@email varchar (50),
@position varchar (50)
)
as 
insert into Usuario(LoginName,Password,Nombre,Apellido,Email,Position)
values (@loginName,@password,@nombre,@apellido,@email,@position)
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectConsulta]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_SelectConsulta]
as
select ID,NombrePaciente,Edad,Sexo,Fecha,NombreDoctor,Motivo,Observaciones,Diagnostico,Procedimiento,Indicaciones  from Consulta 
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectDiagnostico]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_SelectDiagnostico]
as
select * from Diagnostico

GO
/****** Object:  StoredProcedure [dbo].[sp_SelectDoctores]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_SelectDoctores]
as 
select * from Doctores

GO
/****** Object:  StoredProcedure [dbo].[sp_SelectEmpresa]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_SelectEmpresa]
as
select * from Empresa
GO
/****** Object:  StoredProcedure [dbo].[Sp_SelectFacturas]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Sp_SelectFacturas]
  as
select ID,IdCliente,NombreCliente,EdadCliente,SexoCliente,
NombreDoctor,EspecialidadDoctor,Procesos,Costo,Descuento,Pago,Total,Estatus,Fecha from Facturas
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectHistorico]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_SelectHistorico](
  @idb int
  )
  as
  select Deuda,Abono,Resto,Fecha,Comentario from HistoricoPago where IdFactura = @idb
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectHistoricoConsulta]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_SelectHistoricoConsulta]
as
SELECT        Consulta.ID, Consulta.IdDoctor, Consulta.IdPaciente, Paciente.Documento, Consulta.NombrePaciente, Paciente.FechaDeNacimiento, Consulta.Sexo, Paciente.Telefono, Paciente.Direccion, Consulta.Fecha, 
                         Consulta.NombreDoctor, Consulta.Motivo, Consulta.Observaciones, Consulta.Diagnostico, Consulta.Procedimiento, Consulta.Indicaciones, Consulta.Foto
FROM            Consulta INNER JOIN
                         Paciente ON Consulta.IdPaciente= Paciente.ID

GO
/****** Object:  StoredProcedure [dbo].[sp_SelectPaciente]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_SelectPaciente]
as 
select ID,Documento,Nombres,PrimerApellido,SegundoApellido,Sexo,FechaDeNacimiento,EstadoCivil,GrupoSanguineo,ARS,NSS,CorreoElectronico,Telefono,Celular,Direccion from Paciente

GO
/****** Object:  StoredProcedure [dbo].[sp_SelectPacienteN]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_SelectPacienteN]
as 
select ID,Documento,Nombres,PrimerApellido,SegundoApellido,Sexo,FechaDeNacimiento,EstadoCivil,GrupoSanguineo,ARS,NSS,CorreoElectronico,Telefono,Celular,Direccion,TutorNombre,TutorCedula,TutorTelefono from PacienteN

GO
/****** Object:  StoredProcedure [dbo].[sp_SelectPago]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_SelectPago]
as
select * from HistoricoPago
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectProcedimientos]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_SelectProcedimientos]
as 
select  ID,Nombre,Descripcion,Costo  from Procedimientos

GO
/****** Object:  StoredProcedure [dbo].[sp_SelectUsuario]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_SelectUsuario]
as 
select UserID,LoginName,Password,Nombre,Apellido,Email,Position from Usuario

GO
/****** Object:  StoredProcedure [dbo].[sp_SF]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE procedure [dbo].[sp_SF](
  @idc int,
  @idf int
  )
  as
  select * from Facturas where IdCliente = @idc and ID=@idf
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateDiagnostico]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_UpdateDiagnostico] (
@cod int,
@nom varchar(50),
@descp varchar(100)
)
as
update Diagnostico set Nombre=@nom,Descripcion=@descp where ID=@cod

GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateDoctores]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_UpdateDoctores](
@cod int,
@nom varchar (50),
@papellido varchar (50),
@sapellido varchar (50),
@email varchar (50),
@esp varchar (50),
@tel varchar (50),
@cel varchar (50),
@dir varchar (100)
)
as
update Doctores set Nombres=@nom,PrimerApellido=@papellido,SegundoApellido=@sapellido,CorreoElectronico=@email,Especialidad=@esp,Telefono=@tel,Celular=@cel,Direccion=@dir where ID=@cod

GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateEmpresa]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_UpdateEmpresa]
(
@cod int,
@nombre varchar(150),
@direccion varchar(150),
@telefono varchar(50),
@correo varchar(150),
@rnc varchar(50)

)
as
update Empresa set Nombre=@nombre, Direccion=@direccion,Telefono=@telefono, Correo=@correo, RNC=@rnc where ID=@cod
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateFactura]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_UpdateFactura] (
@cod int,
@pago float,
@total float,
@estatus varchar(150)
)
as
update Facturas set Pago=@pago,Total=@total,Estatus=@estatus  where ID=@cod
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdatePaciente]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_UpdatePaciente] (
@cod int,
@doc varchar (50),
@nom varchar (50),
@papellido varchar (50),
@sapellido varchar (50),
@sexo varchar (50),
@fechanac datetime,
@estadoc varchar (50),
@gposanguineo varchar (50),
@ars varchar (50),
@nss varchar (50),
@email varchar (50),
@telefono varchar (50),
@celular varchar (50),
@direccion varchar (50)
)
as
update Paciente set Nombres=@nom, PrimerApellido=@papellido, SegundoApellido=@sapellido,Sexo=@sexo,
FechaDeNacimiento=@fechanac,EstadoCivil=@estadoc,GrupoSanguineo=@gposanguineo,
ARS=@ars,NSS=@nss,CorreoElectronico=@email,Telefono=@telefono,Celular=@celular,Direccion=@direccion where ID=@cod

GO
/****** Object:  StoredProcedure [dbo].[sp_UpdatePacienteN]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_UpdatePacienteN](
@cod int,
@doc varchar (50),
@nom varchar (50),
@papellido varchar (50),
@sapellido varchar (50),
@sexo varchar (50),
@fechanac datetime,
@estadoc varchar (50),
@gposanguineo varchar (50),
@ars varchar (50),
@nss varchar (50),
@email varchar (50),
@telefono varchar (50),
@celular varchar (50),
@direccion varchar (50),
@tutorn varchar (100),
@tutorc varchar (100),
@tutort varchar (100)
)
as
update PacienteN set Nombres=@nom, PrimerApellido=@papellido, SegundoApellido=@sapellido,Sexo=@sexo,FechaDeNacimiento=@fechanac,EstadoCivil=@estadoc,GrupoSanguineo=@gposanguineo,ARS=@ars,NSS=@nss,CorreoElectronico=@email,Telefono=@telefono,Celular=@celular,Direccion=@direccion,TutorNombre=@tutorn,TutorCedula=@tutorc,TutorTelefono=@tutort where ID=@cod
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateProcedimientos]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_UpdateProcedimientos](
@cod int,
@nom varchar(50),
@descp varchar (50),
@costo float
)
as
update Procedimientos set Nombre=@nom,Descripcion=@descp, Costo=@costo where ID=@cod
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateUsuario]    Script Date: 6/20/2025 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_UpdateUsuario] (
@cod int,
@loginName varchar (50),
@password varchar (50),
@nombre varchar (50),
@apellido varchar (50),
@email varchar (50),
@position varchar (50)
)
as
update Usuario set LoginName=@loginName, Password=@password, Nombre=@nombre,Apellido=@apellido,
Email=@email,Position=@position where UserID=@cod
GO
USE [master]
GO
ALTER DATABASE [GRUDENT] SET  READ_WRITE 
GO

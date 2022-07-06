USE [master]
GO
/****** Object:  Database [Bolsa_de_Empleados]    Script Date: 06/07/2022 16:09:44 ******/
CREATE DATABASE [Bolsa_de_Empleados]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Bolsa_de_Empleados', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Bolsa_de_Empleados.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Bolsa_de_Empleados_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Bolsa_de_Empleados_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Bolsa_de_Empleados] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Bolsa_de_Empleados].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Bolsa_de_Empleados] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Bolsa_de_Empleados] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Bolsa_de_Empleados] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Bolsa_de_Empleados] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Bolsa_de_Empleados] SET ARITHABORT OFF 
GO
ALTER DATABASE [Bolsa_de_Empleados] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Bolsa_de_Empleados] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Bolsa_de_Empleados] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Bolsa_de_Empleados] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Bolsa_de_Empleados] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Bolsa_de_Empleados] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Bolsa_de_Empleados] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Bolsa_de_Empleados] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Bolsa_de_Empleados] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Bolsa_de_Empleados] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Bolsa_de_Empleados] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Bolsa_de_Empleados] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Bolsa_de_Empleados] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Bolsa_de_Empleados] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Bolsa_de_Empleados] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Bolsa_de_Empleados] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Bolsa_de_Empleados] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Bolsa_de_Empleados] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Bolsa_de_Empleados] SET  MULTI_USER 
GO
ALTER DATABASE [Bolsa_de_Empleados] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Bolsa_de_Empleados] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Bolsa_de_Empleados] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Bolsa_de_Empleados] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Bolsa_de_Empleados] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Bolsa_de_Empleados] SET QUERY_STORE = OFF
GO
USE [Bolsa_de_Empleados]
GO
/****** Object:  Table [dbo].[ADMINISTRADOR]    Script Date: 06/07/2022 16:09:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ADMINISTRADOR](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Correo_Administrador] [varchar](100) NOT NULL,
	[Contraseña_Administrador] [varchar](60) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Correo_Administrador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CATEGORIAS]    Script Date: 06/07/2022 16:09:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORIAS](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[CATEGORIA] [varchar](60) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DATOS_VACANTE]    Script Date: 06/07/2022 16:09:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DATOS_VACANTE](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Compañia] [varchar](60) NOT NULL,
	[Tipo] [varchar](60) NOT NULL,
	[Posicion] [varchar](100) NOT NULL,
	[Ubicacion] [varchar](100) NOT NULL,
	[Categoria] [varchar](60) NOT NULL,
	[Descripcion_Trabajo] [text] NOT NULL,
	[Como_Aplicar] [text] NOT NULL,
	[Email] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NUMERO_DE_PAGINACION]    Script Date: 06/07/2022 16:09:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NUMERO_DE_PAGINACION](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Numero_de_Paginas] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[POSTER]    Script Date: 06/07/2022 16:09:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[POSTER](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Correo_Poster] [varchar](100) NOT NULL,
	[Contraseña_Poster] [varchar](60) NOT NULL,
	[Nombre_de_Compañia] [varchar](60) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Nombre_de_Compañia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Correo_Poster] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Bolsa_de_Empleados] SET  READ_WRITE 
GO

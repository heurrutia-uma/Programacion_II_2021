﻿USE [master]
GO
CREATE DATABASE [UMA2021]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'UMA2021', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\UMA2021.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'UMA2021_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\UMA2021_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [UMA2021] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [UMA2021].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [UMA2021] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [UMA2021] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [UMA2021] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [UMA2021] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [UMA2021] SET ARITHABORT OFF 
GO
ALTER DATABASE [UMA2021] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [UMA2021] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [UMA2021] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [UMA2021] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [UMA2021] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [UMA2021] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [UMA2021] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [UMA2021] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [UMA2021] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [UMA2021] SET  ENABLE_BROKER 
GO
ALTER DATABASE [UMA2021] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [UMA2021] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [UMA2021] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [UMA2021] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [UMA2021] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [UMA2021] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [UMA2021] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [UMA2021] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [UMA2021] SET  MULTI_USER 
GO
ALTER DATABASE [UMA2021] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [UMA2021] SET DB_CHAINING OFF 
GO
ALTER DATABASE [UMA2021] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [UMA2021] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [UMA2021] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [UMA2021] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [UMA2021] SET QUERY_STORE = OFF
GO
USE [UMA2021]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bodega](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Sucursal] [bigint] NOT NULL,
	[Tipo] [bigint] NOT NULL,
	[Nombre] [nvarchar](50) NULL,
 CONSTRAINT [PK_Bodega] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BodegaTipo](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_BodegaTipo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sucursal](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Direccion] [nvarchar](50) NULL,
	[Ciudad] [nvarchar](50) NULL,
	[Municipio] [nvarchar](30) NULL,
	[Telefono] [nvarchar](10) NULL,
 CONSTRAINT [PK_Sucursal] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Bodega] ON 
GO
INSERT [dbo].[Bodega] ([Id], [Sucursal], [Tipo], [Nombre]) VALUES (1, 1, 1, N'Principal')
GO
INSERT [dbo].[Bodega] ([Id], [Sucursal], [Tipo], [Nombre]) VALUES (2, 1, 1, N'Bodega A')
GO
INSERT [dbo].[Bodega] ([Id], [Sucursal], [Tipo], [Nombre]) VALUES (3, 1, 2, N'Cuarto Frio')
GO
INSERT [dbo].[Bodega] ([Id], [Sucursal], [Tipo], [Nombre]) VALUES (4, 1, 3, N'En Transito')
GO
SET IDENTITY_INSERT [dbo].[Bodega] OFF
GO
SET IDENTITY_INSERT [dbo].[BodegaTipo] ON 
GO
INSERT [dbo].[BodegaTipo] ([Id], [Nombre]) VALUES (1, N'Almacen')
GO
INSERT [dbo].[BodegaTipo] ([Id], [Nombre]) VALUES (2, N'Cuarto Frio')
GO
INSERT [dbo].[BodegaTipo] ([Id], [Nombre]) VALUES (3, N'Transito')
GO
INSERT [dbo].[BodegaTipo] ([Id], [Nombre]) VALUES (4, N'Virtual')
GO
SET IDENTITY_INSERT [dbo].[BodegaTipo] OFF
GO
SET IDENTITY_INSERT [dbo].[Sucursal] ON 
GO
INSERT [dbo].[Sucursal] ([Id], [Nombre], [Direccion], [Ciudad], [Municipio], [Telefono]) VALUES (1, N'Casa Matriz', N'3ra Calle y 6ta Av', N'Santa Ana', N'Santa Ana', N'2440-5555')
GO
SET IDENTITY_INSERT [dbo].[Sucursal] OFF
GO
ALTER TABLE [dbo].[Bodega]  WITH CHECK ADD  CONSTRAINT [FK_Bodega_BodegaTipo] FOREIGN KEY([Tipo])
REFERENCES [dbo].[BodegaTipo] ([Id])
GO
ALTER TABLE [dbo].[Bodega] CHECK CONSTRAINT [FK_Bodega_BodegaTipo]
GO
ALTER TABLE [dbo].[Bodega]  WITH CHECK ADD  CONSTRAINT [FK_Bodega_Sucursal] FOREIGN KEY([Sucursal])
REFERENCES [dbo].[Sucursal] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Bodega] CHECK CONSTRAINT [FK_Bodega_Sucursal]
GO
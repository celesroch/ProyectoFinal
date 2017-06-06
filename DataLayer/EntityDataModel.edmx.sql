
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/06/2017 23:30:44
-- Generated from EDMX file: C:\Users\Celeste\Desktop\ProyectoFinalBueno\DataLayer\EntityDataModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [AlquilerLibros];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Libros]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Libros];
GO
IF OBJECT_ID(N'[dbo].[Prestamos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Prestamos];
GO
IF OBJECT_ID(N'[dbo].[Usuarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuarios];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Libros'
CREATE TABLE [dbo].[Libros] (
    [idLibro] int IDENTITY(1,1) NOT NULL,
    [nomLibro] nvarchar(100)  NULL,
    [ISBN] nvarchar(15)  NULL,
    [autor] nvarchar(100)  NULL,
    [editorial] nchar(80)  NULL,
    [comentario] varchar(max)  NULL
);
GO

-- Creating table 'Usuarios'
CREATE TABLE [dbo].[Usuarios] (
    [idUsuario] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(70)  NULL,
    [Apellidos] nvarchar(100)  NULL,
    [NomUsuario] nvarchar(50)  NULL,
    [Password] nvarchar(150)  NULL,
    [Email] nvarchar(150)  NULL
);
GO

-- Creating table 'Prestamos'
CREATE TABLE [dbo].[Prestamos] (
    [idLibro] int  NOT NULL,
    [idUsuario] int  NOT NULL,
    [Fecha] datetime  NULL,
    [Observaciones] varchar(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [idLibro] in table 'Libros'
ALTER TABLE [dbo].[Libros]
ADD CONSTRAINT [PK_Libros]
    PRIMARY KEY CLUSTERED ([idLibro] ASC);
GO

-- Creating primary key on [idUsuario] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [PK_Usuarios]
    PRIMARY KEY CLUSTERED ([idUsuario] ASC);
GO

-- Creating primary key on [idLibro], [idUsuario] in table 'Prestamos'
ALTER TABLE [dbo].[Prestamos]
ADD CONSTRAINT [PK_Prestamos]
    PRIMARY KEY CLUSTERED ([idLibro], [idUsuario] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
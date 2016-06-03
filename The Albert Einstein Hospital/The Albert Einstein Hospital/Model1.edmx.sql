
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/03/2016 11:30:01
-- Generated from EDMX file: C:\Users\Utilizador\Documents\Visual Studio 2015\Projects\The Albert Einstein Hospital\The Albert Einstein Hospital\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [EinsteinBD];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[UtilizadorSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UtilizadorSet];
GO
IF OBJECT_ID(N'[dbo].[PacienteSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PacienteSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UtilizadorSet'
CREATE TABLE [dbo].[UtilizadorSet] (
    [Id] int  NOT NULL,
    [nome] nvarchar(50)  NULL,
    [morada] nvarchar(50)  NULL,
    [dataNascimento] datetime  NULL,
    [sexo] nvarchar(50)  NULL,
    [codigoPostal] nvarchar(50)  NULL,
    [tipoUtilizador] nvarchar(50)  NULL,
    [username] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PacienteSet'
CREATE TABLE [dbo].[PacienteSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nome] nvarchar(max)  NOT NULL,
    [morada] nvarchar(max)  NOT NULL,
    [dataNascimento] datetime  NOT NULL,
    [sexo] nvarchar(max)  NOT NULL,
    [codigoPostal] nvarchar(max)  NOT NULL,
    [medicacao] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'UtilizadorSet'
ALTER TABLE [dbo].[UtilizadorSet]
ADD CONSTRAINT [PK_UtilizadorSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PacienteSet'
ALTER TABLE [dbo].[PacienteSet]
ADD CONSTRAINT [PK_PacienteSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
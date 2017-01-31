
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/31/2017 17:38:14
-- Generated from EDMX file: C:\Users\mud\Documents\Visual Studio 2013\Projects\TaskManager\TaskManager\DataModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TaskManagerDatabase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_TasksUsers_Tasks]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TasksUsers] DROP CONSTRAINT [FK_TasksUsers_Tasks];
GO
IF OBJECT_ID(N'[dbo].[FK_TasksUsers_Users]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TasksUsers] DROP CONSTRAINT [FK_TasksUsers_Users];
GO
IF OBJECT_ID(N'[dbo].[FK_TeamsUsers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UsersSet] DROP CONSTRAINT [FK_TeamsUsers];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[TasksSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TasksSet];
GO
IF OBJECT_ID(N'[dbo].[TasksUsers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TasksUsers];
GO
IF OBJECT_ID(N'[dbo].[TeamsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TeamsSet];
GO
IF OBJECT_ID(N'[dbo].[UsersSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UsersSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'TeamsSet'
CREATE TABLE [dbo].[TeamsSet] (
    [TeamId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'UsersSet'
CREATE TABLE [dbo].[UsersSet] (
    [UserId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Role] smallint  NOT NULL,
    [Seniority] smallint  NOT NULL,
    [Team] nvarchar(max)  NOT NULL,
    [TeamsTeamId] int  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [SecondName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TasksSet'
CREATE TABLE [dbo].[TasksSet] (
    [TaskId] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Status] smallint  NOT NULL
);
GO

-- Creating table 'TasksUsers'
CREATE TABLE [dbo].[TasksUsers] (
    [Tasks_TaskId] int  NOT NULL,
    [Users_UserId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [TeamId] in table 'TeamsSet'
ALTER TABLE [dbo].[TeamsSet]
ADD CONSTRAINT [PK_TeamsSet]
    PRIMARY KEY CLUSTERED ([TeamId] ASC);
GO

-- Creating primary key on [UserId] in table 'UsersSet'
ALTER TABLE [dbo].[UsersSet]
ADD CONSTRAINT [PK_UsersSet]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- Creating primary key on [TaskId] in table 'TasksSet'
ALTER TABLE [dbo].[TasksSet]
ADD CONSTRAINT [PK_TasksSet]
    PRIMARY KEY CLUSTERED ([TaskId] ASC);
GO

-- Creating primary key on [Tasks_TaskId], [Users_UserId] in table 'TasksUsers'
ALTER TABLE [dbo].[TasksUsers]
ADD CONSTRAINT [PK_TasksUsers]
    PRIMARY KEY CLUSTERED ([Tasks_TaskId], [Users_UserId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [TeamsTeamId] in table 'UsersSet'
ALTER TABLE [dbo].[UsersSet]
ADD CONSTRAINT [FK_TeamsUsers]
    FOREIGN KEY ([TeamsTeamId])
    REFERENCES [dbo].[TeamsSet]
        ([TeamId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TeamsUsers'
CREATE INDEX [IX_FK_TeamsUsers]
ON [dbo].[UsersSet]
    ([TeamsTeamId]);
GO

-- Creating foreign key on [Tasks_TaskId] in table 'TasksUsers'
ALTER TABLE [dbo].[TasksUsers]
ADD CONSTRAINT [FK_TasksUsers_Tasks]
    FOREIGN KEY ([Tasks_TaskId])
    REFERENCES [dbo].[TasksSet]
        ([TaskId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Users_UserId] in table 'TasksUsers'
ALTER TABLE [dbo].[TasksUsers]
ADD CONSTRAINT [FK_TasksUsers_Users]
    FOREIGN KEY ([Users_UserId])
    REFERENCES [dbo].[UsersSet]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TasksUsers_Users'
CREATE INDEX [IX_FK_TasksUsers_Users]
ON [dbo].[TasksUsers]
    ([Users_UserId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
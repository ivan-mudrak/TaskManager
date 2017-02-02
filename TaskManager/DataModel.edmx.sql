
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/02/2017 11:46:22
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


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'TeamsEntitySet'
CREATE TABLE [dbo].[TeamsEntitySet] (
    [TeamId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'UsersEntitySet'
CREATE TABLE [dbo].[UsersEntitySet] (
    [UserId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Role] smallint  NOT NULL,
    [Seniority] smallint  NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [SecondName] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [TeamsEntityTeamId] int  NOT NULL
);
GO

-- Creating table 'TasksEntitySet'
CREATE TABLE [dbo].[TasksEntitySet] (
    [TaskId] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Status] smallint  NOT NULL
);
GO

-- Creating table 'TasksEntityUsersEntity'
CREATE TABLE [dbo].[TasksEntityUsersEntity] (
    [TasksEntity_TaskId] int  NOT NULL,
    [UsersEntity_UserId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [TeamId] in table 'TeamsEntitySet'
ALTER TABLE [dbo].[TeamsEntitySet]
ADD CONSTRAINT [PK_TeamsEntitySet]
    PRIMARY KEY CLUSTERED ([TeamId] ASC);
GO

-- Creating primary key on [UserId] in table 'UsersEntitySet'
ALTER TABLE [dbo].[UsersEntitySet]
ADD CONSTRAINT [PK_UsersEntitySet]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- Creating primary key on [TaskId] in table 'TasksEntitySet'
ALTER TABLE [dbo].[TasksEntitySet]
ADD CONSTRAINT [PK_TasksEntitySet]
    PRIMARY KEY CLUSTERED ([TaskId] ASC);
GO

-- Creating primary key on [TasksEntity_TaskId], [UsersEntity_UserId] in table 'TasksEntityUsersEntity'
ALTER TABLE [dbo].[TasksEntityUsersEntity]
ADD CONSTRAINT [PK_TasksEntityUsersEntity]
    PRIMARY KEY CLUSTERED ([TasksEntity_TaskId], [UsersEntity_UserId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [TeamsEntityTeamId] in table 'UsersEntitySet'
ALTER TABLE [dbo].[UsersEntitySet]
ADD CONSTRAINT [FK_TeamsEntityUsersEntity]
    FOREIGN KEY ([TeamsEntityTeamId])
    REFERENCES [dbo].[TeamsEntitySet]
        ([TeamId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TeamsEntityUsersEntity'
CREATE INDEX [IX_FK_TeamsEntityUsersEntity]
ON [dbo].[UsersEntitySet]
    ([TeamsEntityTeamId]);
GO

-- Creating foreign key on [TasksEntity_TaskId] in table 'TasksEntityUsersEntity'
ALTER TABLE [dbo].[TasksEntityUsersEntity]
ADD CONSTRAINT [FK_TasksEntityUsersEntity_TasksEntity]
    FOREIGN KEY ([TasksEntity_TaskId])
    REFERENCES [dbo].[TasksEntitySet]
        ([TaskId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [UsersEntity_UserId] in table 'TasksEntityUsersEntity'
ALTER TABLE [dbo].[TasksEntityUsersEntity]
ADD CONSTRAINT [FK_TasksEntityUsersEntity_UsersEntity]
    FOREIGN KEY ([UsersEntity_UserId])
    REFERENCES [dbo].[UsersEntitySet]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TasksEntityUsersEntity_UsersEntity'
CREATE INDEX [IX_FK_TasksEntityUsersEntity_UsersEntity]
ON [dbo].[TasksEntityUsersEntity]
    ([UsersEntity_UserId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
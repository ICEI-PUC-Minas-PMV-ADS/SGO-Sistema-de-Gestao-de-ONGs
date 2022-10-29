IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221025214733_V00')
BEGIN
    CREATE TABLE [Doadores] (
        [Id] int NOT NULL IDENTITY,
        [Nome] nvarchar(max) NOT NULL,
        [Telefone] int NOT NULL,
        [Email] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Doadores] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221025214733_V00')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221025214733_V00', N'6.0.10');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221025222553_V01')
BEGIN
    CREATE TABLE [Voluntários] (
        [Id] int NOT NULL IDENTITY,
        [Funcao] int NOT NULL,
        [Disponivel] int NOT NULL,
        [Nome] nvarchar(max) NOT NULL,
        [Telefone] int NOT NULL,
        [Email] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Voluntários] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221025222553_V01')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221025222553_V01', N'6.0.10');
END;
GO

COMMIT;
GO


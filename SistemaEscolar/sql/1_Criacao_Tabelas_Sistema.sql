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

CREATE TABLE [Alunos] (
    [Id] uniqueidentifier NOT NULL,
    [Nome] varchar(100) NOT NULL,
    [Cpf] varchar(11) NOT NULL,
    [DataNascimento] date NOT NULL,
    [Sexo] int NOT NULL,
    [Email] varchar(100) NULL,
    [Telefone] varchar(20) NULL,
    [DataMatricula] date NOT NULL,
    [DataSaida] date NULL,
    [Foto] varchar(200) NULL,
    CONSTRAINT [PK_Alunos] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Enderecos] (
    [Id] uniqueidentifier NOT NULL,
    [AlunoId] uniqueidentifier NOT NULL,
    [Rua] varchar(200) NOT NULL,
    [Numero] varchar(50) NOT NULL,
    [Complemento] varchar(250) NOT NULL,
    [Cep] varchar(8) NOT NULL,
    [Bairro] varchar(100) NOT NULL,
    [Cidade] varchar(100) NOT NULL,
    [Estado] varchar(50) NOT NULL,
    CONSTRAINT [PK_Enderecos] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Aluno_Endereco] FOREIGN KEY ([AlunoId]) REFERENCES [Alunos] ([Id])
);
GO

CREATE UNIQUE INDEX [IX_Endereco_AlunoId] ON [Enderecos] ([AlunoId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230407185159_EstruturaInicial', N'6.0.15');
GO

COMMIT;
GO


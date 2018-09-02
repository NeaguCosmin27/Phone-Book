USE [Server_Abonati_1]
GO

/****** Object: Table [dbo].[Abonati] Script Date: 3/9/2018 6:53:16 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Abonati] (
    [Index]   VARCHAR (50)  NOT NULL,
    [Nume]    NVARCHAR (50) NULL,
    [Prenume] NVARCHAR (50) NULL,
    [Telefon] VARCHAR (50)  NULL,
    [Retea]   NVARCHAR (50) NULL
);



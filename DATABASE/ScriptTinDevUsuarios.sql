USE [TINDEV]
GO

/****** Object:  Table [dbo].[USUARIOS]    Script Date: 06/06/2021 17:00:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[USUARIOS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TIPO_USUARIO] [varchar](100) NULL,
	[NOME] [varchar](100) NULL,
	[EMAIL] [varchar](100) NULL,
	[FONE] [varchar](100) NULL,
	[USUARIO] [varchar](100) NULL,
	[SENHA] [varchar](100) NULL,
	[PERFIL] [varchar](100) NULL,
	[APRESENTACAO] [varchar](255) NULL
) ON [PRIMARY]
GO


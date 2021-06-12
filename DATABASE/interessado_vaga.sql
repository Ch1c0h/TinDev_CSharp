USE [TINDEV]
GO

/****** Object:  Table [dbo].[Interessados_vagas]    Script Date: 12/06/2021 13:27:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Interessados_vagas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CodVaga] [int] NOT NULL,
	[codInteressado] [int] NOT NULL,
	[Aprovado] [nchar](10) NULL
) ON [PRIMARY]
GO


USE [tinDevDB]
GO

/****** Object:  Table [dbo].[TinDevVagas]    Script Date: 10/06/2021 02:34:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TinDevVagas](
	[idVagas] [int] IDENTITY(1,1) NOT NULL,
	[tituloTrabalho] [varchar](max) NOT NULL,
	[descricaoTrabalho] [varchar](max) NOT NULL,
	[tipoSistema] [varchar](max) NOT NULL,
	[idContratante] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idVagas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


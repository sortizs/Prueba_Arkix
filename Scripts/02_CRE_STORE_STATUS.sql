USE [PRUEBA_SEBASTIAN]
GO

/****** Object:  Table [Store].[Status]    Script Date: 7/24/2019 00:36:54 ******/
DROP TABLE IF EXISTS [Store].[Status]
GO

/****** Object:  Table [Store].[Status]    Script Date: 7/24/2019 00:36:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [Store].[Status](
	[Id] [smallint] IDENTITY(0,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Description] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


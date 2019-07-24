USE [PRUEBA_SEBASTIAN]
GO

/****** Object:  Table [Store].[Client]    Script Date: 7/24/2019 00:37:19 ******/
DROP TABLE IF EXISTS [Store].[Client]
GO

/****** Object:  Table [Store].[Client]    Script Date: 7/24/2019 00:37:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [Store].[Client](
	[Id] [smallint] IDENTITY(0,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Last_Name] [varchar](100) NULL,
	[Telephone] [varchar](20) NULL,
	[Address] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [PRUEBA_SEBASTIAN]
GO

/****** Object:  Table [Store].[Author]    Script Date: 7/24/2019 00:34:53 ******/
DROP TABLE IF EXISTS [Store].[Author]
GO

/****** Object:  Table [Store].[Author]    Script Date: 7/24/2019 00:34:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [Store].[Author](
	[Id] [smallint] IDENTITY(0,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Last_Name] [varchar](100) NOT NULL,
	[Born_Date] [date] NULL,
	[Death_Date] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


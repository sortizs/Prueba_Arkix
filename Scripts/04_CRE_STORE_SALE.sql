USE [PRUEBA_SEBASTIAN]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Store].[Sale]') AND type in (N'U'))
ALTER TABLE [Store].[Sale] DROP CONSTRAINT IF EXISTS [FK__Sale__ClientId__52593CB8]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Store].[Sale]') AND type in (N'U'))
ALTER TABLE [Store].[Sale] DROP CONSTRAINT IF EXISTS [FK__Sale__BookId__534D60F1]
GO

/****** Object:  Table [Store].[Sale]    Script Date: 7/24/2019 00:37:49 ******/
DROP TABLE IF EXISTS [Store].[Sale]
GO

/****** Object:  Table [Store].[Sale]    Script Date: 7/24/2019 00:37:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [Store].[Sale](
	[Id] [smallint] IDENTITY(0,1) NOT NULL,
	[ClientId] [smallint] NOT NULL,
	[BookId] [smallint] NOT NULL,
	[Sale_Date] [date] NOT NULL,
	[Sale_Value] [int] NOT NULL,
	[Salesman] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [Store].[Sale]  WITH CHECK ADD FOREIGN KEY([BookId])
REFERENCES [Store].[Book] ([Id])
GO

ALTER TABLE [Store].[Sale]  WITH CHECK ADD FOREIGN KEY([ClientId])
REFERENCES [Store].[Client] ([Id])
GO


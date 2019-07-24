USE [PRUEBA_SEBASTIAN]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Store].[Book]') AND type in (N'U'))
ALTER TABLE [Store].[Book] DROP CONSTRAINT IF EXISTS [FK__Book__Status__5441852A]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Store].[Book]') AND type in (N'U'))
ALTER TABLE [Store].[Book] DROP CONSTRAINT IF EXISTS [FK__Book__AuthorId__4BAC3F29]
GO

/****** Object:  Table [Store].[Book]    Script Date: 7/24/2019 00:36:16 ******/
DROP TABLE IF EXISTS [Store].[Book]
GO

/****** Object:  Table [Store].[Book]    Script Date: 7/24/2019 00:36:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [Store].[Book](
	[Id] [smallint] IDENTITY(0,1) NOT NULL,
	[Title] [varchar](200) NOT NULL,
	[AuthorId] [smallint] NOT NULL,
	[Editor] [varchar](200) NULL,
	[Pub_Date] [date] NOT NULL,
	[Edition] [smallint] NOT NULL,
	[Price] [int] NOT NULL,
	[Retail_Price] [int] NOT NULL,
	[Status] [smallint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [Store].[Book]  WITH CHECK ADD FOREIGN KEY([AuthorId])
REFERENCES [Store].[Author] ([Id])
GO

ALTER TABLE [Store].[Book]  WITH CHECK ADD FOREIGN KEY([Status])
REFERENCES [Store].[Status] ([Id])
GO


USE [PRUEBA_SEBASTIAN]
GO
TRUNCATE TABLE [Store].[Status]
GO
INSERT [Store].[Status] ([Name], [Description]) VALUES (N'Extraordinario', NULL)
GO
INSERT [Store].[Status] ([Name], [Description]) VALUES (N'Excelente', NULL)
GO
INSERT [Store].[Status] ([Name], [Description]) VALUES (N'Bueno', NULL)
GO
INSERT [Store].[Status] ([Name], [Description]) VALUES (N'Dañado', NULL)
GO
SET IDENTITY_INSERT [Store].[Status] OFF
GO

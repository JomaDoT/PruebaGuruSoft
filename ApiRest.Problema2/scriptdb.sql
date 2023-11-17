USE [master]
GO
CREATE DATABASE [prueba_gurusoft]
GO
USE [prueba_gurusoft]
GO
CREATE TABLE [dbo].[persistense](
	[id] [int] NOT NULL PRIMARY KEY,
	[request] [varchar](250) NOT NULL,
	[request_date] [datetime] NOT NULL,
	[response] [varchar](250) NOT NULL,
	[response_date] [datetime] NOT NULL,
	[user_name] [varchar](100) NOT NULL)
GO
USE [prueba_gurusoft]
GO


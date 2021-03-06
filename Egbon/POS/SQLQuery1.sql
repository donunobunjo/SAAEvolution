USE [master]
GO
/****** Object:  Database [pos]    Script Date: 04/25/2017 20:51:07 ******/
CREATE DATABASE [pos] ON  PRIMARY 
( NAME = N'pos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\pos.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'pos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\pos_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [pos] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [pos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [pos] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [pos] SET ANSI_NULLS OFF
GO
ALTER DATABASE [pos] SET ANSI_PADDING OFF
GO
ALTER DATABASE [pos] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [pos] SET ARITHABORT OFF
GO
ALTER DATABASE [pos] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [pos] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [pos] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [pos] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [pos] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [pos] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [pos] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [pos] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [pos] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [pos] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [pos] SET  DISABLE_BROKER
GO
ALTER DATABASE [pos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [pos] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [pos] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [pos] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [pos] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [pos] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [pos] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [pos] SET  READ_WRITE
GO
ALTER DATABASE [pos] SET RECOVERY FULL
GO
ALTER DATABASE [pos] SET  MULTI_USER
GO
ALTER DATABASE [pos] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [pos] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'pos', N'ON'
GO
USE [pos]
GO
/****** Object:  Table [dbo].[controls]    Script Date: 04/25/2017 20:51:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[controls](
	[controlName] [nchar](10) NOT NULL,
	[controlText] [nchar](30) NOT NULL,
	[controlCollor] [nchar](10) NOT NULL,
	[tabName] [nchar](10) NOT NULL,
	[tabText] [nchar](30) NOT NULL,
	[tabColor] [nchar](10) NOT NULL,
 CONSTRAINT [PK_controls] PRIMARY KEY CLUSTERED 
(
	[controlName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[controls] ([controlName], [controlText], [controlCollor], [tabName], [tabText], [tabColor]) VALUES (N'button1   ', N'first                         ', N'red       ', N'tabPage1  ', N'tabPage1                      ', N'f0f0f0    ')
INSERT [dbo].[controls] ([controlName], [controlText], [controlCollor], [tabName], [tabText], [tabColor]) VALUES (N'button2   ', N'second                        ', N'f0f0fd    ', N'tabPage1  ', N'tabPage1                      ', N'f0f0f0    ')
INSERT [dbo].[controls] ([controlName], [controlText], [controlCollor], [tabName], [tabText], [tabColor]) VALUES (N'button3   ', N'third                         ', N'blue      ', N'tabPage1  ', N'tabpage1                      ', N'f0f0f0    ')

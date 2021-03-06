USE [master]
GO
/****** Object:  Database [SAAEvo]    Script Date: 12/30/2015 05:10:02 ******/
CREATE DATABASE [SAAEvo] ON  PRIMARY 
( NAME = N'SAAEvo', FILENAME = N'c:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\SAAEvo.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SAAEvo_log', FILENAME = N'c:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\SAAEvo_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SAAEvo] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SAAEvo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SAAEvo] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [SAAEvo] SET ANSI_NULLS OFF
GO
ALTER DATABASE [SAAEvo] SET ANSI_PADDING OFF
GO
ALTER DATABASE [SAAEvo] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [SAAEvo] SET ARITHABORT OFF
GO
ALTER DATABASE [SAAEvo] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [SAAEvo] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [SAAEvo] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [SAAEvo] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [SAAEvo] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [SAAEvo] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [SAAEvo] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [SAAEvo] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [SAAEvo] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [SAAEvo] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [SAAEvo] SET  DISABLE_BROKER
GO
ALTER DATABASE [SAAEvo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [SAAEvo] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [SAAEvo] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [SAAEvo] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [SAAEvo] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [SAAEvo] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [SAAEvo] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [SAAEvo] SET  READ_WRITE
GO
ALTER DATABASE [SAAEvo] SET RECOVERY SIMPLE
GO
ALTER DATABASE [SAAEvo] SET  MULTI_USER
GO
ALTER DATABASE [SAAEvo] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [SAAEvo] SET DB_CHAINING OFF
GO
USE [SAAEvo]
GO
/****** Object:  Table [dbo].[VendorNumberCheck]    Script Date: 12/30/2015 05:10:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VendorNumberCheck](
	[VendorNumber] [int] NOT NULL,
 CONSTRAINT [PK_VendorNumberCheck] PRIMARY KEY CLUSTERED 
(
	[VendorNumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vendor]    Script Date: 12/30/2015 05:10:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vendor](
	[VendorNumber] [nchar](10) NOT NULL,
	[VendorName] [nchar](80) NULL,
	[Company] [nchar](100) NULL,
	[Website] [nchar](80) NULL,
	[Address] [nchar](200) NULL,
	[Email] [nchar](80) NULL,
	[Phone] [nchar](20) NULL,
	[Fax] [nchar](80) NULL,
	[Street] [nchar](20) NULL,
	[State] [nchar](20) NULL,
	[Acccount] [nchar](50) NULL,
	[OpeningBalance] [numeric](18, 2) NULL,
	[CreditLimit] [numeric](18, 2) NULL,
	[EmailPreference] [bit] NULL,
	[SMSPreference] [bit] NULL,
	[Active] [bit] NULL,
	[Classification] [nchar](50) NULL,
 CONSTRAINT [PK_Vendor] PRIMARY KEY CLUSTERED 
(
	[VendorNumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 12/30/2015 05:10:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[userID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nchar](50) NULL,
	[password] [nchar](10) NULL,
	[Role] [nchar](30) NULL,
	[DateCreated] [date] NULL,
	[Active] [bit] NULL,
	[Location] [nchar](80) NULL,
	[Store] [nchar](80) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[userID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserFunctions]    Script Date: 12/30/2015 05:10:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserFunctions](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nchar](50) NULL,
	[AssignFunctions] [nchar](50) NULL,
 CONSTRAINT [PK_UserFunctions] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[subNames]    Script Date: 12/30/2015 05:10:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[subNames](
	[subName] [varchar](50) NOT NULL,
	[subCode] [nchar](10) NULL,
	[postingCode] [nchar](10) NULL,
	[notes] [nchar](10) NULL,
	[codeSno] [nchar](10) NULL,
	[groupName] [nchar](10) NULL,
 CONSTRAINT [PK_subNames] PRIMARY KEY CLUSTERED 
(
	[subName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Store]    Script Date: 12/30/2015 05:10:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Store](
	[StoreID] [int] IDENTITY(1,1) NOT NULL,
	[StoreName] [nchar](50) NULL,
	[LocationName] [nchar](50) NULL,
	[Storemanager] [nchar](50) NULL,
	[DateOpened] [date] NULL,
	[Prefixx] [nchar](10) NULL,
 CONSTRAINT [PK_Store] PRIMARY KEY CLUSTERED 
(
	[StoreID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SONumberCheck]    Script Date: 12/30/2015 05:10:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SONumberCheck](
	[SONumber] [int] NOT NULL,
 CONSTRAINT [PK_SONumberCheck] PRIMARY KEY CLUSTERED 
(
	[SONumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesRepStore]    Script Date: 12/30/2015 05:10:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesRepStore](
	[SalesRepID] [int] IDENTITY(1,1) NOT NULL,
	[SalesRepName] [nchar](50) NULL,
	[LocationName] [nchar](50) NULL,
	[StoreName] [nchar](50) NULL,
	[DateOpened] [date] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_SalesRepStore] PRIMARY KEY CLUSTERED 
(
	[SalesRepID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesOrderSummary]    Script Date: 12/30/2015 05:10:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesOrderSummary](
	[SONumber] [nchar](10) NOT NULL,
	[Customer] [nchar](50) NULL,
	[SODate] [date] NULL,
	[SOStatus] [nchar](10) NULL,
	[SOAmount] [decimal](18, 2) NULL,
	[SODiscount] [decimal](18, 2) NULL,
	[UserName] [nchar](30) NULL,
	[Comment] [nchar](100) NULL,
	[Location] [nchar](20) NULL,
	[Store] [nchar](20) NULL,
 CONSTRAINT [PK_SalesOrderSummary] PRIMARY KEY CLUSTERED 
(
	[SONumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesOrderDetail]    Script Date: 12/30/2015 05:10:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesOrderDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SalesOrderNumber] [nchar](10) NULL,
	[Customer] [nchar](80) NULL,
	[SODate] [date] NULL,
	[Item] [nchar](80) NULL,
	[Quantity] [decimal](18, 2) NULL,
	[Rate] [decimal](18, 2) NULL,
	[Amount] [decimal](18, 2) NULL,
	[Comment] [nchar](100) NULL,
	[UserName] [nchar](30) NULL,
	[Delivered] [bit] NULL,
	[QtyOrdered] [decimal](18, 2) NULL,
	[QtyDelivered] [decimal](18, 2) NULL,
	[Location] [nchar](50) NULL,
	[Store] [nchar](50) NULL,
	[SalesInvoiceNumber] [nchar](10) NULL,
	[InvDate] [date] NULL,
	[Type] [nchar](10) NULL,
	[Discount] [decimal](18, 2) NULL,
	[Tax] [decimal](18, 2) NULL,
 CONSTRAINT [PK_SalesDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesInvoice]    Script Date: 12/30/2015 05:10:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesInvoice](
	[Iden] [int] IDENTITY(1,1) NOT NULL,
	[SalesInvoiceNumber] [nchar](10) NULL,
	[SalesOrderNumber] [nchar](10) NULL,
	[InvoiceDate] [date] NULL,
	[Customer] [nchar](80) NULL,
	[Item] [nchar](50) NULL,
	[Quantity] [decimal](18, 2) NULL,
	[Rate] [decimal](18, 2) NULL,
	[Amount] [decimal](18, 2) NULL,
	[Location] [nchar](80) NULL,
	[Store] [nchar](80) NULL,
	[Discount] [numeric](18, 2) NULL,
	[Tax] [numeric](18, 2) NULL,
	[UserName] [nchar](80) NULL,
	[Type] [nchar](10) NULL,
 CONSTRAINT [PK_SalesInvoice_1] PRIMARY KEY CLUSTERED 
(
	[Iden] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesInvNumberCheck]    Script Date: 12/30/2015 05:10:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesInvNumberCheck](
	[SaleInvNumber] [int] NOT NULL,
 CONSTRAINT [PK_SalesInvNumberCheck] PRIMARY KEY CLUSTERED 
(
	[SaleInvNumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 12/30/2015 05:10:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[Role] [nchar](50) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchaseOrderSummary]    Script Date: 12/30/2015 05:10:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseOrderSummary](
	[PONumber] [nchar](10) NOT NULL,
	[Vendor] [nchar](50) NULL,
	[PODate] [date] NULL,
	[POStatus] [nchar](10) NULL,
	[POAmount] [decimal](18, 2) NULL,
	[PODiscount] [decimal](18, 2) NULL,
	[UserName] [nchar](30) NULL,
	[Comment] [nchar](100) NULL,
	[Store] [nchar](20) NULL,
	[Location] [nchar](20) NULL,
 CONSTRAINT [PK_PurchaseOrderSummary] PRIMARY KEY CLUSTERED 
(
	[PONumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchaseOrderDetail]    Script Date: 12/30/2015 05:10:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseOrderDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseOrderNumber] [nchar](10) NULL,
	[Vendor] [nchar](80) NULL,
	[PODate] [date] NULL,
	[Item] [nchar](80) NULL,
	[Quantity] [decimal](18, 2) NULL,
	[Rate] [decimal](18, 2) NULL,
	[Amount] [decimal](18, 2) NULL,
	[Comment] [nchar](100) NULL,
	[UserName] [nchar](30) NULL,
	[Recieved] [bit] NULL,
	[QtyOrdered] [decimal](18, 2) NULL,
	[QtyDelivered] [decimal](18, 2) NULL,
	[Location] [nchar](50) NULL,
	[Store] [nchar](50) NULL,
	[PurchaseInvoiceNumber] [nchar](10) NULL,
	[InvDate] [date] NULL,
	[Type] [nchar](10) NULL,
	[Discount] [decimal](18, 2) NULL,
	[Tax] [decimal](18, 2) NULL,
 CONSTRAINT [PK_PurchaseDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchaseInvoice]    Script Date: 12/30/2015 05:10:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseInvoice](
	[Iden] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseInvoiceNumber] [nchar](10) NULL,
	[PurchaseOrderNumber] [nchar](10) NULL,
	[InvoiceDate] [date] NULL,
	[Vendor] [nchar](80) NULL,
	[Item] [nchar](50) NULL,
	[Quantity] [decimal](18, 2) NULL,
	[Rate] [decimal](18, 2) NULL,
	[Amount] [decimal](18, 2) NULL,
	[Location] [nchar](80) NULL,
	[Store] [nchar](80) NULL,
	[Discount] [numeric](18, 2) NULL,
	[Tax] [numeric](18, 2) NULL,
	[UserName] [nchar](80) NULL,
	[Type] [nchar](10) NULL,
 CONSTRAINT [PK_PurchaseInvoice_1] PRIMARY KEY CLUSTERED 
(
	[Iden] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PONumberCheck]    Script Date: 12/30/2015 05:10:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PONumberCheck](
	[PONumber] [int] NOT NULL,
 CONSTRAINT [PK_PONumberCheck] PRIMARY KEY CLUSTERED 
(
	[PONumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NumberChecks]    Script Date: 12/30/2015 05:10:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NumberChecks](
	[Iden] [int] IDENTITY(1,1) NOT NULL,
	[Location] [nchar](80) NULL,
	[Store] [nchar](80) NULL,
	[SO] [int] NULL,
	[SI] [int] NULL,
	[PO] [int] NULL,
	[PI] [int] NULL,
	[CSI] [int] NULL,
	[CPI] [int] NULL,
 CONSTRAINT [PK_NumberChecks] PRIMARY KEY CLUSTERED 
(
	[Iden] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Location]    Script Date: 12/30/2015 05:10:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Location](
	[locationID] [int] IDENTITY(1,1) NOT NULL,
	[LocationName] [nchar](50) NULL,
 CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED 
(
	[locationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemTrans]    Script Date: 12/30/2015 05:10:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemTrans](
	[TransID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nchar](50) NULL,
	[DateTrans] [date] NULL,
	[Price] [numeric](18, 2) NULL,
	[Issued] [numeric](18, 2) NULL,
	[Recieved] [numeric](18, 2) NULL,
	[SalesRepName] [nchar](50) NULL,
	[LocationName] [nchar](50) NULL,
	[StoreName] [nchar](50) NULL,
	[Comment] [nchar](10) NULL,
	[TotalAmount] [numeric](18, 2) NULL,
	[Source] [nchar](50) NULL,
	[Destination] [nchar](50) NULL,
	[UserName] [nchar](50) NULL,
 CONSTRAINT [PK_ItemTrans] PRIMARY KEY CLUSTERED 
(
	[TransID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Items]    Script Date: 12/30/2015 05:10:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Items](
	[FPC] [nchar](10) NOT NULL,
	[Description] [nchar](50) NULL,
	[Brand] [nchar](20) NULL,
	[Price] [numeric](18, 2) NULL,
	[Su] [numeric](18, 2) NULL,
	[CaseCount] [int] NULL,
	[Quantity] [numeric](18, 2) NULL,
	[DateOpened] [date] NULL,
	[SKU] [nchar](50) NULL,
	[UserName] [nchar](50) NULL,
	[SellingPrice] [numeric](18, 2) NULL,
 CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
(
	[FPC] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemCategory]    Script Date: 12/30/2015 05:10:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemCategory](
	[ItemCategoryCode] [int] IDENTITY(1,1) NOT NULL,
	[ItemCategoryName] [nchar](40) NULL,
 CONSTRAINT [PK_ItemCategory] PRIMARY KEY CLUSTERED 
(
	[ItemCategoryCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemBalances]    Script Date: 12/30/2015 05:10:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemBalances](
	[TransID] [int] IDENTITY(1,1) NOT NULL,
	[DateTrans] [date] NULL,
	[Items] [nchar](50) NULL,
	[Price] [numeric](18, 2) NULL,
	[Issued] [numeric](18, 2) NULL,
	[Recieves] [numeric](18, 2) NULL,
	[comment] [nchar](100) NULL,
	[TotalAmount] [numeric](18, 2) NULL,
	[SourceDestination] [nchar](100) NULL,
	[UserName] [nchar](50) NULL,
	[Balance] [numeric](18, 2) NULL,
 CONSTRAINT [PK_ItemBalances] PRIMARY KEY CLUSTERED 
(
	[TransID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 12/30/2015 05:10:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item](
	[ItemCode] [nchar](10) NOT NULL,
	[Description] [nchar](50) NULL,
	[Category] [nchar](50) NULL,
	[QuantityOnHand] [decimal](18, 2) NULL,
	[ReOrderLevel] [decimal](18, 2) NULL,
	[LastUnitPrice] [decimal](18, 2) NULL,
	[AvgUnitPrice] [decimal](18, 2) NULL,
	[LastSellingPrice] [decimal](18, 2) NULL,
	[CurrentSellingPrice] [decimal](18, 2) NULL,
	[IncomeAccount] [nchar](80) NULL,
	[AssetAccount] [nchar](80) NULL,
	[Date] [date] NULL,
	[SKUNumber] [nchar](10) NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[ItemCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[groupNames]    Script Date: 12/30/2015 05:10:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[groupNames](
	[groupName] [varchar](50) NOT NULL,
	[groupCode] [nchar](10) NULL,
	[postingCode] [nchar](10) NULL,
 CONSTRAINT [PK_groupNames] PRIMARY KEY CLUSTERED 
(
	[groupName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[generalLedger]    Script Date: 12/30/2015 05:10:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[generalLedger](
	[accountCode2] [varchar](50) NULL,
	[postingCode] [varchar](50) NULL,
	[accountName] [varchar](50) NULL,
	[accountCode] [varchar](50) NULL,
	[subName] [varchar](50) NULL,
	[subCode] [varchar](50) NULL,
	[groupName] [varchar](50) NULL,
	[groupCode] [varchar](50) NULL,
	[debit] [float] NULL,
	[credit] [float] NULL,
	[amount] [float] NULL,
	[code] [varchar](50) NULL,
	[notes] [varchar](50) NULL,
	[paymentMethod] [varchar](50) NULL,
	[receiptNo] [varchar](50) NULL,
	[surname] [varchar](50) NULL,
	[balance] [float] NULL,
	[address] [varchar](80) NULL,
	[bankName] [varchar](50) NULL,
	[bankAccountNo] [varchar](50) NULL,
	[bankAccountName] [varchar](50) NULL,
	[particulars] [varchar](150) NULL,
	[username] [varchar](50) NULL,
	[dtime] [varchar](50) NULL,
	[authorStatus] [varchar](50) NULL,
	[companyName] [varchar](50) NULL,
	[dfyear] [int] NULL,
	[approved] [varchar](50) NULL,
	[deptName] [varchar](50) NULL,
	[transtype] [varchar](50) NULL,
	[transdate] [datetime] NULL,
	[transdate2] [datetime] NULL,
	[transdate3] [datetime] NULL,
	[transdatePosted] [datetime] NULL,
	[paymentVoucherNo] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Function]    Script Date: 12/30/2015 05:10:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Function](
	[FunctionID] [int] IDENTITY(1,1) NOT NULL,
	[FuctionName] [nchar](80) NULL,
 CONSTRAINT [PK_Function] PRIMARY KEY CLUSTERED 
(
	[FunctionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerNumberCheck]    Script Date: 12/30/2015 05:10:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerNumberCheck](
	[CustomerNumber] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 12/30/2015 05:10:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerNumber] [nchar](10) NOT NULL,
	[CustomerName] [nchar](80) NULL,
	[Company] [nchar](100) NULL,
	[Website] [nchar](80) NULL,
	[Address] [nchar](200) NULL,
	[Email] [nchar](80) NULL,
	[Phone] [nchar](20) NULL,
	[Fax] [nchar](80) NULL,
	[Street] [nchar](20) NULL,
	[State] [nchar](20) NULL,
	[Acccount] [nchar](50) NULL,
	[OpeningBalance] [numeric](18, 2) NULL,
	[CreditLimit] [numeric](18, 2) NULL,
	[EmailPreference] [bit] NULL,
	[SMSPreference] [bit] NULL,
	[Active] [bit] NULL,
	[Classification] [nchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerNumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clasification]    Script Date: 12/30/2015 05:10:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clasification](
	[ClassificationID] [int] IDENTITY(1,1) NOT NULL,
	[Classification] [nchar](50) NULL,
 CONSTRAINT [PK_Clasification] PRIMARY KEY CLUSTERED 
(
	[ClassificationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[chartActs]    Script Date: 12/30/2015 05:10:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[chartActs](
	[accountCode] [varchar](50) NULL,
	[accountName] [varchar](50) NULL,
	[subName] [varchar](50) NULL,
	[subCode] [varchar](50) NULL,
	[groupCode] [varchar](50) NULL,
	[groupName] [varchar](50) NULL,
	[code] [varchar](50) NULL,
	[notes] [varchar](50) NULL,
	[postingCode] [varchar](50) NULL,
	[sortCode] [int] NULL,
	[acctType] [varchar](50) NULL,
	[accountStatus] [varchar](50) NULL,
	[dmonthName] [varchar](50) NULL,
	[bankName] [varchar](50) NULL,
	[accountNo] [varchar](50) NULL,
	[budget] [float] NULL,
	[bankAct] [varchar](50) NULL,
	[userName] [varchar](50) NULL,
	[transdate] [datetime] NULL,
	[datePosted] [datetime] NULL,
	[debit] [float] NULL,
	[credit] [float] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Brand]    Script Date: 12/30/2015 05:10:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brand](
	[BrandID] [int] IDENTITY(1,1) NOT NULL,
	[BrandName] [nchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bank]    Script Date: 12/30/2015 05:10:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bank](
	[BankCode] [int] NOT NULL,
	[BankName] [nchar](80) NULL,
	[BankAcctNum] [nchar](20) NULL,
	[Website] [nchar](80) NULL,
	[Address] [nchar](200) NULL,
	[Email] [nchar](80) NULL,
	[Phone] [nchar](20) NULL,
	[Fax] [nchar](80) NULL,
	[Street] [nchar](20) NULL,
	[State] [nchar](20) NULL,
	[Acccount] [nchar](20) NULL,
	[Contact] [nchar](20) NULL,
 CONSTRAINT [PK_Bank] PRIMARY KEY CLUSTERED 
(
	[BankCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

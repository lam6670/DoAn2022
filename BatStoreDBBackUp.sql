USE [master]
GO
/****** Object:  Database [dbBatStore]    Script Date: 5/18/22 9:54:55 PM ******/
CREATE DATABASE [dbBatStore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbBatStore', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\dbBatStore.mdf' , SIZE = 10240KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dbBatStore_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\dbBatStore_log.ldf' , SIZE = 3456KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [dbBatStore] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbBatStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbBatStore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbBatStore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbBatStore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbBatStore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbBatStore] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbBatStore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbBatStore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbBatStore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbBatStore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbBatStore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbBatStore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbBatStore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbBatStore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbBatStore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbBatStore] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbBatStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbBatStore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbBatStore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbBatStore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbBatStore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbBatStore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbBatStore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbBatStore] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbBatStore] SET  MULTI_USER 
GO
ALTER DATABASE [dbBatStore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbBatStore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbBatStore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbBatStore] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [dbBatStore] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dbBatStore] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'dbBatStore', N'ON'
GO
ALTER DATABASE [dbBatStore] SET QUERY_STORE = OFF
GO
USE [dbBatStore]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 5/18/22 9:54:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[AccountID] [int] IDENTITY(1,1) NOT NULL,
	[Phone] [varchar](13) NULL,
	[Email] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Active] [bit] NOT NULL,
	[FullName] [nvarchar](150) NULL,
	[RoleID] [int] NULL,
	[LastLogin] [datetime] NULL,
	[CreateDate] [datetime] NULL,
 CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
(
	[AccountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Attributes]    Script Date: 5/18/22 9:54:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attributes](
	[AttributeID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Attributes] PRIMARY KEY CLUSTERED 
(
	[AttributeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AttributesPrices]    Script Date: 5/18/22 9:54:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AttributesPrices](
	[AttributesPriceID] [int] IDENTITY(1,1) NOT NULL,
	[AttributeID] [int] NULL,
	[ProductID] [int] NULL,
	[Price] [int] NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_AttributesPrices] PRIMARY KEY CLUSTERED 
(
	[AttributesPriceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 5/18/22 9:54:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CatID] [int] IDENTITY(1,1) NOT NULL,
	[CatName] [nvarchar](250) NULL,
	[Description] [nvarchar](max) NULL,
	[Ordering] [int] NULL,
	[Published] [bit] NOT NULL,
	[Thumb] [nvarchar](250) NULL,
	[Title] [nvarchar](250) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 5/18/22 9:54:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](255) NULL,
	[Birthday] [datetime] NULL,
	[Address] [nvarchar](255) NULL,
	[Email] [nchar](150) NULL,
	[Phone] [varchar](12) NULL,
	[CreateDate] [datetime] NULL,
	[Password] [nvarchar](50) NULL,
	[LastLogin] [datetime] NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 5/18/22 9:54:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderDetailID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NULL,
	[ProductID] [int] NULL,
	[OrderNumber] [int] NULL,
	[Amount] [int] NULL,
	[Discount] [int] NULL,
	[TotalMoney] [int] NULL,
	[CreateDate] [datetime] NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[OrderDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 5/18/22 9:54:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NULL,
	[OrderDate] [datetime] NULL,
	[ShipDate] [datetime] NULL,
	[TransactStatusID] [int] NOT NULL,
	[Paid] [bit] NOT NULL,
	[PaymentDate] [datetime] NULL,
	[TotalMoney] [int] NOT NULL,
	[PaymentID] [int] NULL,
	[Note] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 5/18/22 9:54:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](255) NOT NULL,
	[ShortDesc] [nvarchar](255) NULL,
	[Description] [nvarchar](max) NULL,
	[CatID] [int] NULL,
	[Price] [int] NULL,
	[Discount] [int] NULL,
	[DateCreated] [datetime] NULL,
	[DateModified] [datetime] NULL,
	[BestSellers] [bit] NOT NULL,
	[Active] [bit] NOT NULL,
	[Tags] [nvarchar](max) NULL,
	[Title] [nvarchar](255) NULL,
	[UnitsInStock] [int] NULL,
	[Thumb] [nvarchar](250) NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 5/18/22 9:54:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](50) NULL,
	[Description] [nvarchar](50) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TransactStatus]    Script Date: 5/18/22 9:54:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransactStatus](
	[TransactStatusID] [int] IDENTITY(1,1) NOT NULL,
	[Status] [nvarchar](50) NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_TransactStatus] PRIMARY KEY CLUSTERED 
(
	[TransactStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Accounts] ON 

INSERT [dbo].[Accounts] ([AccountID], [Phone], [Email], [Password], [Active], [FullName], [RoleID], [LastLogin], [CreateDate]) VALUES (1, N'0966658430', N'lamdepzjn@gmail.com', N'Cocomeo_123', 1, N'Zjn Ky', 2, CAST(N'2022-05-18T10:48:23.603' AS DateTime), NULL)
INSERT [dbo].[Accounts] ([AccountID], [Phone], [Email], [Password], [Active], [FullName], [RoleID], [LastLogin], [CreateDate]) VALUES (2, N'0988568490', N'daylamailcuatoi@gmail.com', N';am123123', 1, N'Nguyen Hai Lam', 3, CAST(N'2022-04-17T08:36:06.700' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[Accounts] OFF
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CatID], [CatName], [Description], [Ordering], [Published], [Thumb], [Title]) VALUES (1, N'Apple', N'FlagShip', 100, 1, N'apple.png', N'Apple SmartPhone')
INSERT [dbo].[Categories] ([CatID], [CatName], [Description], [Ordering], [Published], [Thumb], [Title]) VALUES (2, N'SamSung', N'FlagShip', 2000, 1, N'samsung.png', N'SamSung SmartPhones')
INSERT [dbo].[Categories] ([CatID], [CatName], [Description], [Ordering], [Published], [Thumb], [Title]) VALUES (1002, N'Google', N'Các dòng máy camera thuật toán đặc biệt của Google', 50, 1, N'google.png', N'Google SmartPhones')
INSERT [dbo].[Categories] ([CatID], [CatName], [Description], [Ordering], [Published], [Thumb], [Title]) VALUES (1003, N'Asus', N'Điện thoại chuyên gaming mobile', 60, 1, N'asus.png', N'Asus SmartPhones')
INSERT [dbo].[Categories] ([CatID], [CatName], [Description], [Ordering], [Published], [Thumb], [Title]) VALUES (1004, N'Vsmart', N'Điện thoại giá rẻ đến tầm trung của thương hiệu Việt Nam', 70, 1, N'vsmart.jpg', N'Vsmart Phones')
INSERT [dbo].[Categories] ([CatID], [CatName], [Description], [Ordering], [Published], [Thumb], [Title]) VALUES (1005, N'RealMe', N'Điện thoại tầm trung đến từ công ty con của OPPO', 80, 1, N'realme.png', N'RealMe SmartPhones')
INSERT [dbo].[Categories] ([CatID], [CatName], [Description], [Ordering], [Published], [Thumb], [Title]) VALUES (1006, N'NOKIA', N'Thương hiệu lâu đời về điện thoại', 90, 1, N'nokia.png', N'NOKIA SmartPhones')
INSERT [dbo].[Categories] ([CatID], [CatName], [Description], [Ordering], [Published], [Thumb], [Title]) VALUES (1007, N'OPPO', N'Thương hiệu đến từ Trung Quốc với mọi phân khúc sản phẩm', 150, 1, N'oppo.png', N'OPPO SmartPhones')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustomerID], [FullName], [Birthday], [Address], [Email], [Phone], [CreateDate], [Password], [LastLogin], [Active]) VALUES (1, N'Nguyễn Hải Lâm', NULL, N'Ha Noi', N'lamdepzjn2@gmail.com                                                                                                                                  ', N'0966658430', CAST(N'2022-02-26T00:45:58.817' AS DateTime), N'046142824d16b367bee4a7b974adf159', NULL, 1)
INSERT [dbo].[Customers] ([CustomerID], [FullName], [Birthday], [Address], [Email], [Phone], [CreateDate], [Password], [LastLogin], [Active]) VALUES (2, N'Nguyễn Hải Lâm', NULL, N'Hà Nội', N'lamdepzjn3@gmail.com                                                                                                                                  ', N'0986658430', CAST(N'2022-03-27T14:17:37.183' AS DateTime), N'13521a6a4031c927a060d7230cd8b5f8', NULL, 1)
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderDetails] ON 

INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [OrderNumber], [Amount], [Discount], [TotalMoney], [CreateDate], [Price]) VALUES (1, NULL, 1022, NULL, 1, NULL, 7250000, CAST(N'2022-04-16T16:55:19.033' AS DateTime), 7250000)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [OrderNumber], [Amount], [Discount], [TotalMoney], [CreateDate], [Price]) VALUES (2, NULL, 1019, NULL, 1, NULL, 19000000, CAST(N'2022-04-16T16:58:47.070' AS DateTime), 19000000)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [OrderNumber], [Amount], [Discount], [TotalMoney], [CreateDate], [Price]) VALUES (3, NULL, 1022, NULL, 1, NULL, 7250000, CAST(N'2022-04-16T17:04:20.247' AS DateTime), 7250000)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [OrderNumber], [Amount], [Discount], [TotalMoney], [CreateDate], [Price]) VALUES (4, NULL, 1022, NULL, 1, NULL, 7250000, CAST(N'2022-04-16T17:07:26.430' AS DateTime), 7250000)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [OrderNumber], [Amount], [Discount], [TotalMoney], [CreateDate], [Price]) VALUES (5, NULL, 1022, NULL, 1, NULL, 7250000, CAST(N'2022-04-16T17:11:52.103' AS DateTime), 7250000)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [OrderNumber], [Amount], [Discount], [TotalMoney], [CreateDate], [Price]) VALUES (6, NULL, 1022, NULL, 1, NULL, 7250000, CAST(N'2022-04-16T17:24:28.903' AS DateTime), 7250000)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [OrderNumber], [Amount], [Discount], [TotalMoney], [CreateDate], [Price]) VALUES (7, NULL, 1022, NULL, 1, NULL, 7250000, CAST(N'2022-04-17T08:15:30.983' AS DateTime), 7250000)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [OrderNumber], [Amount], [Discount], [TotalMoney], [CreateDate], [Price]) VALUES (8, NULL, 1023, NULL, 1, NULL, 5700000, CAST(N'2022-04-17T08:35:54.653' AS DateTime), 5700000)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [OrderNumber], [Amount], [Discount], [TotalMoney], [CreateDate], [Price]) VALUES (9, NULL, 1015, NULL, 1, NULL, 35000000, CAST(N'2022-05-07T23:04:25.033' AS DateTime), 35000000)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [OrderNumber], [Amount], [Discount], [TotalMoney], [CreateDate], [Price]) VALUES (10, NULL, 1019, NULL, 1, NULL, 19000000, CAST(N'2022-05-07T23:08:50.380' AS DateTime), 19000000)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [OrderNumber], [Amount], [Discount], [TotalMoney], [CreateDate], [Price]) VALUES (11, NULL, 1022, NULL, 1, NULL, 7250000, CAST(N'2022-05-09T00:09:33.703' AS DateTime), 7250000)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [OrderNumber], [Amount], [Discount], [TotalMoney], [CreateDate], [Price]) VALUES (12, NULL, 1021, NULL, 1, NULL, 6700000, CAST(N'2022-05-09T00:28:03.437' AS DateTime), 6700000)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [OrderNumber], [Amount], [Discount], [TotalMoney], [CreateDate], [Price]) VALUES (13, NULL, 1033, NULL, 1, NULL, 4200000, CAST(N'2022-05-18T10:47:45.093' AS DateTime), 4200000)
SET IDENTITY_INSERT [dbo].[OrderDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([OrderID], [CustomerID], [OrderDate], [ShipDate], [TransactStatusID], [Paid], [PaymentDate], [TotalMoney], [PaymentID], [Note], [Address]) VALUES (3, 1, CAST(N'2022-04-10T00:13:00.000' AS DateTime), CAST(N'2022-04-12T00:41:39.163' AS DateTime), 3, 1, CAST(N'2022-04-12T00:41:39.163' AS DateTime), 15000000, 5, N'Test don hang', N'Ha Noi')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [OrderDate], [ShipDate], [TransactStatusID], [Paid], [PaymentDate], [TotalMoney], [PaymentID], [Note], [Address]) VALUES (4, 2, CAST(N'2022-04-06T15:17:00.000' AS DateTime), CAST(N'2022-04-16T15:17:00.000' AS DateTime), 3, 1, CAST(N'2022-04-04T15:18:00.000' AS DateTime), 8500000, NULL, N'Test don hang', N'Ha Noi')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [OrderDate], [ShipDate], [TransactStatusID], [Paid], [PaymentDate], [TotalMoney], [PaymentID], [Note], [Address]) VALUES (5, 2, CAST(N'2022-04-16T16:55:19.020' AS DateTime), NULL, 1, 0, NULL, 7250000, NULL, NULL, N'Ha Noi')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [OrderDate], [ShipDate], [TransactStatusID], [Paid], [PaymentDate], [TotalMoney], [PaymentID], [Note], [Address]) VALUES (6, 2, CAST(N'2022-04-16T16:58:47.070' AS DateTime), NULL, 1, 0, NULL, 19000000, NULL, NULL, N'Ha Noi')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [OrderDate], [ShipDate], [TransactStatusID], [Paid], [PaymentDate], [TotalMoney], [PaymentID], [Note], [Address]) VALUES (7, 2, CAST(N'2022-04-16T17:03:25.500' AS DateTime), NULL, 1, 0, NULL, 7250000, NULL, NULL, N'Ha Noi 23')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [OrderDate], [ShipDate], [TransactStatusID], [Paid], [PaymentDate], [TotalMoney], [PaymentID], [Note], [Address]) VALUES (8, 2, CAST(N'2022-04-16T17:07:26.400' AS DateTime), NULL, 2, 0, NULL, 7250000, NULL, NULL, N'Ha Dong, Ha Noi ')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [OrderDate], [ShipDate], [TransactStatusID], [Paid], [PaymentDate], [TotalMoney], [PaymentID], [Note], [Address]) VALUES (9, 2, CAST(N'2022-04-16T17:11:52.103' AS DateTime), NULL, 1, 0, NULL, 7250000, NULL, NULL, N'123 Ha Dong, Ha Noi ')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [OrderDate], [ShipDate], [TransactStatusID], [Paid], [PaymentDate], [TotalMoney], [PaymentID], [Note], [Address]) VALUES (10, 2, CAST(N'2022-04-16T17:20:24.960' AS DateTime), NULL, 1, 0, NULL, 5700000, NULL, NULL, N'123, Ngo Thi Nham, Ha Cau Ha Dong, Ha Noi ')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [OrderDate], [ShipDate], [TransactStatusID], [Paid], [PaymentDate], [TotalMoney], [PaymentID], [Note], [Address]) VALUES (11, 2, CAST(N'2022-04-16T17:20:29.277' AS DateTime), NULL, 1, 0, NULL, 5700000, NULL, NULL, N'Ha Cau Ha Dong, Ha Noi ')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [OrderDate], [ShipDate], [TransactStatusID], [Paid], [PaymentDate], [TotalMoney], [PaymentID], [Note], [Address]) VALUES (12, 2, CAST(N'2022-04-16T17:20:49.747' AS DateTime), NULL, 1, 0, NULL, 5700000, NULL, NULL, N'Ha Cau Ha Dong, Ha Noi ')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [OrderDate], [ShipDate], [TransactStatusID], [Paid], [PaymentDate], [TotalMoney], [PaymentID], [Note], [Address]) VALUES (13, 2, CAST(N'2022-04-16T17:21:27.090' AS DateTime), NULL, 1, 0, NULL, 6700000, NULL, NULL, N'Ha Cau Ha Dong, Ha Noi ')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [OrderDate], [ShipDate], [TransactStatusID], [Paid], [PaymentDate], [TotalMoney], [PaymentID], [Note], [Address]) VALUES (14, 2, CAST(N'2022-04-16T17:21:30.020' AS DateTime), NULL, 1, 0, NULL, 6700000, NULL, NULL, N'Ha Cau Ha Dong, Ha Noi ')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [OrderDate], [ShipDate], [TransactStatusID], [Paid], [PaymentDate], [TotalMoney], [PaymentID], [Note], [Address]) VALUES (15, 2, CAST(N'2022-04-16T17:22:29.543' AS DateTime), NULL, 1, 0, NULL, 35000000, NULL, NULL, N'Ha Cau Ha Dong, Ha Noi ')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [OrderDate], [ShipDate], [TransactStatusID], [Paid], [PaymentDate], [TotalMoney], [PaymentID], [Note], [Address]) VALUES (17, 2, CAST(N'2022-04-17T08:15:30.953' AS DateTime), NULL, 1, 0, NULL, 7250000, NULL, NULL, N'Ha Tay Ha Dong, Ha Noi nha')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [OrderDate], [ShipDate], [TransactStatusID], [Paid], [PaymentDate], [TotalMoney], [PaymentID], [Note], [Address]) VALUES (18, 2, CAST(N'2022-04-17T08:35:54.630' AS DateTime), CAST(N'2022-04-17T08:36:27.503' AS DateTime), 3, 0, NULL, 5700000, NULL, NULL, N'Ha Dong, Ha Noi ')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [OrderDate], [ShipDate], [TransactStatusID], [Paid], [PaymentDate], [TotalMoney], [PaymentID], [Note], [Address]) VALUES (19, 2, CAST(N'2022-05-07T23:04:25.003' AS DateTime), NULL, 1, 0, NULL, 35000000, NULL, N'Giao hàng giờ hành chính', N'Hà Tây')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [OrderDate], [ShipDate], [TransactStatusID], [Paid], [PaymentDate], [TotalMoney], [PaymentID], [Note], [Address]) VALUES (20, 2, CAST(N'2022-05-07T23:08:50.350' AS DateTime), NULL, 1, 0, NULL, 19000000, NULL, N'Đã đổi sđth', N'TPHCM')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [OrderDate], [ShipDate], [TransactStatusID], [Paid], [PaymentDate], [TotalMoney], [PaymentID], [Note], [Address]) VALUES (21, 2, CAST(N'2022-05-09T00:09:33.673' AS DateTime), NULL, 1, 0, NULL, 7250000, NULL, N'Giao hàng nhanh nhé', N'TPHCM')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [OrderDate], [ShipDate], [TransactStatusID], [Paid], [PaymentDate], [TotalMoney], [PaymentID], [Note], [Address]) VALUES (22, 2, CAST(N'2022-05-09T00:28:03.407' AS DateTime), NULL, 1, 0, NULL, 6700000, NULL, N'Không còn gì nữa', N'TPHCM')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [OrderDate], [ShipDate], [TransactStatusID], [Paid], [PaymentDate], [TotalMoney], [PaymentID], [Note], [Address]) VALUES (23, 2, CAST(N'2022-05-18T10:47:45.060' AS DateTime), NULL, 4, 1, CAST(N'2022-05-18T10:50:24.760' AS DateTime), 4200000, NULL, N'Giao hàng giờ hành chính', N'Hà Nội')
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductID], [ProductName], [ShortDesc], [Description], [CatID], [Price], [Discount], [DateCreated], [DateModified], [BestSellers], [Active], [Tags], [Title], [UnitsInStock], [Thumb]) VALUES (7, N'SamSungS21', N'Điện thoại cao cấp đến từ SamSung', NULL, 2, 25000000, 0, NULL, CAST(N'2022-02-26T21:57:26.653' AS DateTime), 1, 1, N'1', N'Siêu phẩm SamSung', 100, N'samsungs21.png')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ShortDesc], [Description], [CatID], [Price], [Discount], [DateCreated], [DateModified], [BestSellers], [Active], [Tags], [Title], [UnitsInStock], [Thumb]) VALUES (1011, N'Iphone 11', N'Siêu phẩm', N'Hàng sang, công nghệ tân tiến', 1, 35000000, 2, NULL, CAST(N'2022-02-24T21:34:50.080' AS DateTime), 1, 1, NULL, N'NgonCuc dai', 23, N'iphone-11.jpg')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ShortDesc], [Description], [CatID], [Price], [Discount], [DateCreated], [DateModified], [BestSellers], [Active], [Tags], [Title], [UnitsInStock], [Thumb]) VALUES (1015, N'SamSung Zflip 3', N'Điện thoại cao cấp màn hình gập', N'Phân khúc cao cấp', 2, 35000000, 0, CAST(N'2022-03-26T23:56:19.980' AS DateTime), CAST(N'2022-03-26T23:56:19.980' AS DateTime), 1, 1, N'FlagShip', N'FlagShipSamSung', 2000, N'samsung-zflip-3.png')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ShortDesc], [Description], [CatID], [Price], [Discount], [DateCreated], [DateModified], [BestSellers], [Active], [Tags], [Title], [UnitsInStock], [Thumb]) VALUES (1016, N'J7 Prime', N'Điện thoại tầm trung', N'None', 2, 6000000, 0, CAST(N'2022-03-26T23:57:59.397' AS DateTime), CAST(N'2022-03-26T23:57:59.397' AS DateTime), 1, 1, N'Normal', N'MayTamTrung', 200, N'j7-prime.jpg')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ShortDesc], [Description], [CatID], [Price], [Discount], [DateCreated], [DateModified], [BestSellers], [Active], [Tags], [Title], [UnitsInStock], [Thumb]) VALUES (1017, N'Iphone 8 Plus Red Edition', N'Điện thoại cao cấp với phiên bản màu đặc biệt', NULL, 1, 12000000, 0, CAST(N'2022-03-26T23:59:46.977' AS DateTime), CAST(N'2022-03-26T23:59:46.977' AS DateTime), 0, 1, N'FlagShip', N'Old FlagShip', 20, N'iphone-8-plus-red-edition.jpg')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ShortDesc], [Description], [CatID], [Price], [Discount], [DateCreated], [DateModified], [BestSellers], [Active], [Tags], [Title], [UnitsInStock], [Thumb]) VALUES (1018, N'Iphone 13 Pro', N'Điện thoại cao cấp', N'None', 1, 18000000, 2, CAST(N'2022-03-27T00:01:15.763' AS DateTime), CAST(N'2022-03-27T00:01:15.763' AS DateTime), 1, 1, N'FlagShip', N'FlagShip Apple', 100, N'iphone-13-pro.jpg')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ShortDesc], [Description], [CatID], [Price], [Discount], [DateCreated], [DateModified], [BestSellers], [Active], [Tags], [Title], [UnitsInStock], [Thumb]) VALUES (1019, N'Iphone 12 Pro Max', N'Điện thoại cao cấp ', NULL, 1, 19000000, 0, CAST(N'2022-03-27T00:02:31.270' AS DateTime), CAST(N'2022-03-27T00:02:31.270' AS DateTime), 1, 1, N'FlagShip', N'FlagShip Apple', 50, N'iphone-12-pro-max.png')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ShortDesc], [Description], [CatID], [Price], [Discount], [DateCreated], [DateModified], [BestSellers], [Active], [Tags], [Title], [UnitsInStock], [Thumb]) VALUES (1020, N'SamSung A51', N'Điện thoại tầm trung', N'None', 2, 8000000, 5, CAST(N'2022-03-27T00:03:48.963' AS DateTime), CAST(N'2022-03-27T00:03:48.963' AS DateTime), 1, 1, N'Normal', N'Normal', 45, N'samsung-a51.jpg')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ShortDesc], [Description], [CatID], [Price], [Discount], [DateCreated], [DateModified], [BestSellers], [Active], [Tags], [Title], [UnitsInStock], [Thumb]) VALUES (1021, N'Oppo Reno4 Pro', N'Điện thoại tầm trung với 4 camera phục vụ mọi nhu câuuf', N'Phân khúc tầm trung', 1007, 6700000, 0, CAST(N'2022-04-12T00:27:40.880' AS DateTime), CAST(N'2022-04-12T00:27:40.880' AS DateTime), 0, 1, N'Normal', N'Điện thoại oppo siêu camera', 250, N'oppo-reno4-pro.jpg')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ShortDesc], [Description], [CatID], [Price], [Discount], [DateCreated], [DateModified], [BestSellers], [Active], [Tags], [Title], [UnitsInStock], [Thumb]) VALUES (1022, N'Oppo A15', N'Điện thoại tầm trung', N'Phù hợp cho mọi lứa tuổi', 1007, 7250000, 5, CAST(N'2022-04-12T00:28:44.000' AS DateTime), CAST(N'2022-04-12T00:29:05.430' AS DateTime), 0, 1, N'Normal', N'Điện thoại tầm trung', 150, N'oppo-a15.jpg')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ShortDesc], [Description], [CatID], [Price], [Discount], [DateCreated], [DateModified], [BestSellers], [Active], [Tags], [Title], [UnitsInStock], [Thumb]) VALUES (1023, N'RealMe 8 Pro', N'Điện thoại tầm trung', N'Phù hợp cho mọi lứa tuổi', 1005, 5700000, 0, CAST(N'2022-04-12T00:30:49.367' AS DateTime), CAST(N'2022-04-12T00:30:49.367' AS DateTime), 0, 1, N'Normal', N'Điện thoại tầm trung', 146, N'realme-8-pro.jpg')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ShortDesc], [Description], [CatID], [Price], [Discount], [DateCreated], [DateModified], [BestSellers], [Active], [Tags], [Title], [UnitsInStock], [Thumb]) VALUES (1024, N'One Plus 1', N'Điện thoại tầm trung', N'Phù hợp cho mọi lứa tuổi', 1002, 8700000, 0, CAST(N'2022-05-18T01:19:59.397' AS DateTime), CAST(N'2022-05-18T01:19:59.397' AS DateTime), 0, 1, N'Normal', N'Normal Phone', 300, N'one-plus-1.jpg')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ShortDesc], [Description], [CatID], [Price], [Discount], [DateCreated], [DateModified], [BestSellers], [Active], [Tags], [Title], [UnitsInStock], [Thumb]) VALUES (1027, N'One Plus 9', N'Phân khúc tầm trung', N'Phù hợp cho mọi lứa tuổi', 1002, 10000000, 0, CAST(N'2022-05-18T01:24:24.940' AS DateTime), CAST(N'2022-05-18T01:24:24.940' AS DateTime), 1, 1, N'Normal', N'Normal Phone', 250, N'one-plus-9.jpg')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ShortDesc], [Description], [CatID], [Price], [Discount], [DateCreated], [DateModified], [BestSellers], [Active], [Tags], [Title], [UnitsInStock], [Thumb]) VALUES (1028, N'ROG Phone 3', N'Điện thoại cao cấp dành cho game thủ', N'Điện thoại cao cấp dành cho game thủ', 1003, 26000000, 0, CAST(N'2022-05-18T01:39:46.753' AS DateTime), CAST(N'2022-05-18T01:39:46.750' AS DateTime), 0, 1, N'FlagShip', N'FlagShip', 50, N'rog-phone-3.jpg')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ShortDesc], [Description], [CatID], [Price], [Discount], [DateCreated], [DateModified], [BestSellers], [Active], [Tags], [Title], [UnitsInStock], [Thumb]) VALUES (1029, N'ROG Phone 5', N'Điện thoại cao cấp dành cho game thủ', N'Điện thoại cao cấp dành cho game thủ', 1003, 31000000, 0, CAST(N'2022-05-18T01:41:43.000' AS DateTime), CAST(N'2022-05-18T21:47:03.447' AS DateTime), 0, 1, N'FlagShip', N'FlagShip', 20, N'rog-phone-5.jpg')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ShortDesc], [Description], [CatID], [Price], [Discount], [DateCreated], [DateModified], [BestSellers], [Active], [Tags], [Title], [UnitsInStock], [Thumb]) VALUES (1030, N'ROG Phone 2', N'Điện thoại cao cấp dành cho game thủ', N'Điện thoại cao cấp dành cho game thủ', 1003, 21000000, 0, CAST(N'2022-05-18T01:42:31.883' AS DateTime), CAST(N'2022-05-18T01:42:31.883' AS DateTime), 1, 1, N'FlagShip', N'FlagShip', 12, N'rog-phone-2.jpg')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ShortDesc], [Description], [CatID], [Price], [Discount], [DateCreated], [DateModified], [BestSellers], [Active], [Tags], [Title], [UnitsInStock], [Thumb]) VALUES (1031, N'Vsmart Star 4', N'Phân khúc tầm trung', N'Phù hợp cho mọi lứa tuổi', 1004, 4500000, 0, CAST(N'2022-05-18T01:53:08.357' AS DateTime), CAST(N'2022-05-18T01:53:08.357' AS DateTime), 0, 1, N'Normal', N'Normal Phone', 40, N'vsmart-star-4.jpg')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ShortDesc], [Description], [CatID], [Price], [Discount], [DateCreated], [DateModified], [BestSellers], [Active], [Tags], [Title], [UnitsInStock], [Thumb]) VALUES (1032, N'Vsmart Joy 4', N'Điện thoại tầm trung', N'Phù hợp cho mọi lứa tuổi', 1004, 3899000, 0, CAST(N'2022-05-18T01:58:03.550' AS DateTime), CAST(N'2022-05-18T01:58:03.550' AS DateTime), 0, 1, N'Normal', N'Normal Phone', 45, N'vsmart-joy-4.png')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ShortDesc], [Description], [CatID], [Price], [Discount], [DateCreated], [DateModified], [BestSellers], [Active], [Tags], [Title], [UnitsInStock], [Thumb]) VALUES (1033, N'Vsmart Active 3', N'Điện thoại tầm trung', N'Phù hợp cho mọi lứa tuổi', 1004, 4200000, 0, CAST(N'2022-05-18T02:00:26.257' AS DateTime), CAST(N'2022-05-18T02:00:26.257' AS DateTime), 0, 1, N'Normal', N'Normal Phone', 120, N'vsmart-active-3.png')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ShortDesc], [Description], [CatID], [Price], [Discount], [DateCreated], [DateModified], [BestSellers], [Active], [Tags], [Title], [UnitsInStock], [Thumb]) VALUES (1034, N'Vsmart Live 4', N'Điện thoại tầm trung', N'Phù hợp cho mọi lứa tuổi', 1004, 5100000, 0, CAST(N'2022-05-18T02:03:09.143' AS DateTime), CAST(N'2022-05-18T02:03:09.143' AS DateTime), 0, 1, N'Normal', N'Normal Phone', 56, N'vsmart-live-4.jpg')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ShortDesc], [Description], [CatID], [Price], [Discount], [DateCreated], [DateModified], [BestSellers], [Active], [Tags], [Title], [UnitsInStock], [Thumb]) VALUES (1035, N'NoKia 5', N'Điện thoại tầm trung', NULL, 1006, 7500000, 0, CAST(N'2022-05-18T10:49:24.840' AS DateTime), CAST(N'2022-05-18T10:49:24.840' AS DateTime), 0, 1, N'Normal', N'Normal', 200, N'nokia-5.png')
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([RoleID], [RoleName], [Description]) VALUES (2, N'Staff', N'Nhân viên')
INSERT [dbo].[Roles] ([RoleID], [RoleName], [Description]) VALUES (3, N'Admin', N'Quản lý')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[TransactStatus] ON 

INSERT [dbo].[TransactStatus] ([TransactStatusID], [Status], [Description]) VALUES (1, N'Cho thanh toan', N'Don hang da duoc dat nhung chua thanh toan')
INSERT [dbo].[TransactStatus] ([TransactStatusID], [Status], [Description]) VALUES (2, N'Da thanh toan', N'Don hang da duoc thanh toan')
INSERT [dbo].[TransactStatus] ([TransactStatusID], [Status], [Description]) VALUES (3, N'Da giao cho don vi van chuyen', N'Don hang duoc giao cho don vi van chuyen')
INSERT [dbo].[TransactStatus] ([TransactStatusID], [Status], [Description]) VALUES (4, N'Don hang hoan thanh', N'Don hang da duoc giao vao thanh toan thanh cong')
SET IDENTITY_INSERT [dbo].[TransactStatus] OFF
GO
ALTER TABLE [dbo].[Accounts]  WITH CHECK ADD  CONSTRAINT [FK_Accounts_Roles] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Roles] ([RoleID])
GO
ALTER TABLE [dbo].[Accounts] CHECK CONSTRAINT [FK_Accounts_Roles]
GO
ALTER TABLE [dbo].[AttributesPrices]  WITH CHECK ADD  CONSTRAINT [FK_AttributesPrices_Attributes] FOREIGN KEY([AttributeID])
REFERENCES [dbo].[Attributes] ([AttributeID])
GO
ALTER TABLE [dbo].[AttributesPrices] CHECK CONSTRAINT [FK_AttributesPrices_Attributes]
GO
ALTER TABLE [dbo].[AttributesPrices]  WITH CHECK ADD  CONSTRAINT [FK_AttributesPrices_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[AttributesPrices] CHECK CONSTRAINT [FK_AttributesPrices_Products]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Products]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_TransactStatus] FOREIGN KEY([TransactStatusID])
REFERENCES [dbo].[TransactStatus] ([TransactStatusID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_TransactStatus]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([CatID])
REFERENCES [dbo].[Categories] ([CatID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
USE [master]
GO
ALTER DATABASE [dbBatStore] SET  READ_WRITE 
GO

USE [master]
GO
/****** Object:  Database [LKSMart]    Script Date: 12/09/2022 18:41:33 ******/
CREATE DATABASE [LKSMart]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LKSMart', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\LKSMart.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LKSMart_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\LKSMart_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [LKSMart] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LKSMart].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LKSMart] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LKSMart] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LKSMart] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LKSMart] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LKSMart] SET ARITHABORT OFF 
GO
ALTER DATABASE [LKSMart] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LKSMart] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LKSMart] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LKSMart] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LKSMart] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LKSMart] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LKSMart] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LKSMart] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LKSMart] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LKSMart] SET  ENABLE_BROKER 
GO
ALTER DATABASE [LKSMart] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LKSMart] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LKSMart] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LKSMart] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LKSMart] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LKSMart] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LKSMart] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LKSMart] SET RECOVERY FULL 
GO
ALTER DATABASE [LKSMart] SET  MULTI_USER 
GO
ALTER DATABASE [LKSMart] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LKSMart] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LKSMart] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LKSMart] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LKSMart] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LKSMart] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'LKSMart', N'ON'
GO
ALTER DATABASE [LKSMart] SET QUERY_STORE = OFF
GO
USE [LKSMart]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 12/09/2022 18:41:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[parent_id] [int] NULL,
	[name] [varchar](200) NOT NULL,
	[created_at] [datetime] NOT NULL,
	[last_updated_at] [datetime] NULL,
	[deleted_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 12/09/2022 18:41:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](200) NOT NULL,
	[phone_number] [varchar](200) NOT NULL,
	[email] [varchar](200) NOT NULL,
	[pin_number] [varchar](6) NOT NULL,
	[date_of_birth] [date] NULL,
	[address] [varchar](200) NULL,
	[gender] [varchar](10) NULL,
	[point] [int] NOT NULL,
	[profile_image_name] [varchar](200) NULL,
	[created_at] [datetime] NOT NULL,
	[last_updated_at] [datetime] NULL,
	[deleted_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[phone_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetailTransaction]    Script Date: 12/09/2022 18:41:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetailTransaction](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[header_transaction_id] [int] NOT NULL,
	[product_id] [int] NOT NULL,
	[price] [decimal](10, 2) NOT NULL,
	[quantity] [int] NOT NULL,
	[created_at] [datetime] NOT NULL,
	[last_updated_at] [datetime] NULL,
	[deleted_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HeaderTransaction]    Script Date: 12/09/2022 18:41:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HeaderTransaction](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[customer_id] [int] NOT NULL,
	[payment_type_id] [int] NOT NULL,
	[datetime] [datetime] NOT NULL,
	[sub_total] [decimal](10, 2) NOT NULL,
	[point_used] [int] NOT NULL,
	[payment_code] [varchar](200) NOT NULL,
	[created_at] [datetime] NOT NULL,
	[last_updated_at] [datetime] NULL,
	[deleted_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentType]    Script Date: 12/09/2022 18:41:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentType](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](200) NOT NULL,
	[created_at] [datetime] NOT NULL,
	[last_updated_at] [datetime] NULL,
	[deleted_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PointHistory]    Script Date: 12/09/2022 18:41:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PointHistory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[customer_id] [int] NOT NULL,
	[header_transaction_id] [int] NULL,
	[point_gained] [int] NULL,
	[point_deducted] [int] NULL,
	[point_before] [int] NOT NULL,
	[point_after] [int] NOT NULL,
	[created_at] [datetime] NOT NULL,
	[last_updated_at] [datetime] NULL,
	[deleted_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 12/09/2022 18:41:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[category_id] [int] NOT NULL,
	[name] [varchar](200) NOT NULL,
	[price] [decimal](10, 2) NOT NULL,
	[stock] [int] NOT NULL,
	[image_name] [varchar](200) NULL,
	[created_at] [datetime] NOT NULL,
	[last_updated_at] [datetime] NULL,
	[deleted_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Category] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[Customer] ADD  DEFAULT ((0)) FOR [point]
GO
ALTER TABLE [dbo].[Customer] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[DetailTransaction] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[HeaderTransaction] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[PaymentType] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[PointHistory] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[Product] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[Category]  WITH CHECK ADD FOREIGN KEY([parent_id])
REFERENCES [dbo].[Category] ([id])
GO
ALTER TABLE [dbo].[DetailTransaction]  WITH CHECK ADD FOREIGN KEY([header_transaction_id])
REFERENCES [dbo].[HeaderTransaction] ([id])
GO
ALTER TABLE [dbo].[DetailTransaction]  WITH CHECK ADD FOREIGN KEY([product_id])
REFERENCES [dbo].[Product] ([id])
GO
ALTER TABLE [dbo].[HeaderTransaction]  WITH CHECK ADD FOREIGN KEY([customer_id])
REFERENCES [dbo].[Customer] ([id])
GO
ALTER TABLE [dbo].[HeaderTransaction]  WITH CHECK ADD FOREIGN KEY([payment_type_id])
REFERENCES [dbo].[PaymentType] ([id])
GO
ALTER TABLE [dbo].[PointHistory]  WITH CHECK ADD FOREIGN KEY([customer_id])
REFERENCES [dbo].[Customer] ([id])
GO
ALTER TABLE [dbo].[PointHistory]  WITH CHECK ADD FOREIGN KEY([header_transaction_id])
REFERENCES [dbo].[HeaderTransaction] ([id])
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([category_id])
REFERENCES [dbo].[Category] ([id])
GO
USE [master]
GO
ALTER DATABASE [LKSMart] SET  READ_WRITE 
GO

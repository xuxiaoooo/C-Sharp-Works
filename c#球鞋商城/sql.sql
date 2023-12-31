USE [master]
GO
/****** Object:  Database [shoe]    Script Date: 2021/7/9 11:15:20 ******/
CREATE DATABASE [shoe]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'shoe', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\shoe.ndf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'shoe_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\shoe_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [shoe] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [shoe].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [shoe] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [shoe] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [shoe] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [shoe] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [shoe] SET ARITHABORT OFF 
GO
ALTER DATABASE [shoe] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [shoe] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [shoe] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [shoe] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [shoe] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [shoe] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [shoe] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [shoe] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [shoe] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [shoe] SET  ENABLE_BROKER 
GO
ALTER DATABASE [shoe] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [shoe] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [shoe] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [shoe] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [shoe] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [shoe] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [shoe] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [shoe] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [shoe] SET  MULTI_USER 
GO
ALTER DATABASE [shoe] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [shoe] SET DB_CHAINING OFF 
GO
ALTER DATABASE [shoe] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [shoe] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [shoe] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [shoe] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [shoe] SET QUERY_STORE = OFF
GO
USE [shoe]
GO
/****** Object:  Table [dbo].[car]    Script Date: 2021/7/9 11:15:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[car](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NULL,
	[size] [int] NULL,
	[price] [money] NULL,
	[userid] [nvarchar](255) NULL,
	[ispay] [int] NOT NULL,
	[payway] [varchar](255) NULL,
	[buytime] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[info]    Script Date: 2021/7/9 11:15:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[info](
	[id] [int] NOT NULL,
	[isnew] [bit] NOT NULL,
	[image] [varchar](255) NULL,
	[minusmoney] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[shouhou]    Script Date: 2021/7/9 11:15:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[shouhou](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[userid] [varchar](1) NULL,
	[content] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[store]    Script Date: 2021/7/9 11:15:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[store](
	[id] [int] NOT NULL,
	[name] [varchar](255) NULL,
	[num] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user]    Script Date: 2021/7/9 11:15:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[id] [nvarchar](1) NOT NULL,
	[password] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[car] ON 

INSERT [dbo].[car] ([id], [name], [size], [price], [userid], [ispay], [payway], [buytime]) VALUES (1, N'NIKO奥利奥限定', 35, 799.0000, N'1', 1, N'微信支付', CAST(N'2021-07-09T01:54:34.000' AS DateTime))
INSERT [dbo].[car] ([id], [name], [size], [price], [userid], [ispay], [payway], [buytime]) VALUES (2, N'Abibas关羽限定', 36, 999.0000, N'1', 1, N'微信支付', CAST(N'2021-07-09T01:54:34.000' AS DateTime))
INSERT [dbo].[car] ([id], [name], [size], [price], [userid], [ispay], [payway], [buytime]) VALUES (3, N'NIKO奥利奥限定', 36, 799.0000, N'1', 1, N'微信支付', CAST(N'2021-07-09T01:54:34.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[car] OFF
GO
INSERT [dbo].[info] ([id], [isnew], [image], [minusmoney]) VALUES (1, 1, N'../image1.jpg', 0)
GO
SET IDENTITY_INSERT [dbo].[shouhou] ON 

INSERT [dbo].[shouhou] ([id], [userid], [content]) VALUES (1, N'1', N't')
INSERT [dbo].[shouhou] ([id], [userid], [content]) VALUES (2, N'1', N'1111')
SET IDENTITY_INSERT [dbo].[shouhou] OFF
GO
INSERT [dbo].[store] ([id], [name], [num]) VALUES (1, N'NIKO奥利奥限定', 109)
INSERT [dbo].[store] ([id], [name], [num]) VALUES (2, N'NIKO绿钩足球鞋', 98)
INSERT [dbo].[store] ([id], [name], [num]) VALUES (3, N'匡威兔八哥限定', 56)
INSERT [dbo].[store] ([id], [name], [num]) VALUES (4, N'Abibas关羽限定', 80)
GO
INSERT [dbo].[user] ([id], [password]) VALUES (N'1', N'1')
INSERT [dbo].[user] ([id], [password]) VALUES (N'2', N'2')
INSERT [dbo].[user] ([id], [password]) VALUES (N'3', N'3')
GO
ALTER TABLE [dbo].[car] ADD  DEFAULT ((0)) FOR [ispay]
GO
ALTER TABLE [dbo].[info] ADD  DEFAULT ((0)) FOR [isnew]
GO
ALTER TABLE [dbo].[info] ADD  DEFAULT ((0)) FOR [minusmoney]
GO
USE [master]
GO
ALTER DATABASE [shoe] SET  READ_WRITE 
GO

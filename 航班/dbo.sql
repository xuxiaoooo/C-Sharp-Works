/*
 Navicat Premium Data Transfer

 Source Server         : localhost
 Source Server Type    : SQL Server
 Source Server Version : 15002000
 Source Host           : localhost:1433
 Source Catalog        : MyTicket
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 15002000
 File Encoding         : 65001

 Date: 02/09/2021 15:27:21
*/


-- ----------------------------
-- Table structure for airwaysInfo
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[airwaysInfo]') AND type IN ('U'))
	DROP TABLE [dbo].[airwaysInfo]
GO

CREATE TABLE [dbo].[airwaysInfo] (
  [id] int  IDENTITY(1,1) NOT NULL,
  [airways] nvarchar(50) COLLATE Chinese_PRC_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[airwaysInfo] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of airwaysInfo
-- ----------------------------
SET IDENTITY_INSERT [dbo].[airwaysInfo] ON
GO

INSERT INTO [dbo].[airwaysInfo] ([id], [airways]) VALUES (N'1', N'中国国航')
GO

INSERT INTO [dbo].[airwaysInfo] ([id], [airways]) VALUES (N'2', N'上海航空')
GO

INSERT INTO [dbo].[airwaysInfo] ([id], [airways]) VALUES (N'3', N'海南航空')
GO

INSERT INTO [dbo].[airwaysInfo] ([id], [airways]) VALUES (N'4', N'东方航空')
GO

INSERT INTO [dbo].[airwaysInfo] ([id], [airways]) VALUES (N'5', N'山东航空')
GO

INSERT INTO [dbo].[airwaysInfo] ([id], [airways]) VALUES (N'6', N'四川航空')
GO

INSERT INTO [dbo].[airwaysInfo] ([id], [airways]) VALUES (N'7', N'深圳航空')
GO

INSERT INTO [dbo].[airwaysInfo] ([id], [airways]) VALUES (N'8', N'厦门航空')
GO

SET IDENTITY_INSERT [dbo].[airwaysInfo] OFF
GO


-- ----------------------------
-- Table structure for cityInfo
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[cityInfo]') AND type IN ('U'))
	DROP TABLE [dbo].[cityInfo]
GO

CREATE TABLE [dbo].[cityInfo] (
  [id] int  IDENTITY(1,1) NOT NULL,
  [cityName] nvarchar(50) COLLATE Chinese_PRC_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[cityInfo] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of cityInfo
-- ----------------------------
SET IDENTITY_INSERT [dbo].[cityInfo] ON
GO

INSERT INTO [dbo].[cityInfo] ([id], [cityName]) VALUES (N'1', N'北京')
GO

INSERT INTO [dbo].[cityInfo] ([id], [cityName]) VALUES (N'2', N'上海')
GO

INSERT INTO [dbo].[cityInfo] ([id], [cityName]) VALUES (N'3', N'三亚')
GO

INSERT INTO [dbo].[cityInfo] ([id], [cityName]) VALUES (N'4', N'沈阳')
GO

INSERT INTO [dbo].[cityInfo] ([id], [cityName]) VALUES (N'5', N'深圳')
GO

INSERT INTO [dbo].[cityInfo] ([id], [cityName]) VALUES (N'6', N'南京')
GO

INSERT INTO [dbo].[cityInfo] ([id], [cityName]) VALUES (N'7', N'长沙')
GO

INSERT INTO [dbo].[cityInfo] ([id], [cityName]) VALUES (N'8', N'成都')
GO

SET IDENTITY_INSERT [dbo].[cityInfo] OFF
GO


-- ----------------------------
-- Table structure for flightInfo
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[flightInfo]') AND type IN ('U'))
	DROP TABLE [dbo].[flightInfo]
GO

CREATE TABLE [dbo].[flightInfo] (
  [flightNo] nvarchar(50) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [airwaysId] int  NOT NULL,
  [leaveCity] int  NOT NULL,
  [destinationCity] int  NOT NULL,
  [leaveTime] nvarchar(50) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [landTime] nvarchar(50) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [price] money  NOT NULL
)
GO

ALTER TABLE [dbo].[flightInfo] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of flightInfo
-- ----------------------------
INSERT INTO [dbo].[flightInfo] ([flightNo], [airwaysId], [leaveCity], [destinationCity], [leaveTime], [landTime], [price]) VALUES (N'CA1337', N'1', N'1', N'5', N'08:30', N'11:30', N'1200.0000')
GO

INSERT INTO [dbo].[flightInfo] ([flightNo], [airwaysId], [leaveCity], [destinationCity], [leaveTime], [landTime], [price]) VALUES (N'CA1345', N'1', N'1', N'3', N'15:05', N'18:45', N'1300.0000')
GO

INSERT INTO [dbo].[flightInfo] ([flightNo], [airwaysId], [leaveCity], [destinationCity], [leaveTime], [landTime], [price]) VALUES (N'CA1603', N'1', N'1', N'8', N'08:05', N'09:40', N'1300.0000')
GO

INSERT INTO [dbo].[flightInfo] ([flightNo], [airwaysId], [leaveCity], [destinationCity], [leaveTime], [landTime], [price]) VALUES (N'CA984', N'1', N'1', N'2', N'07:20', N'09:30', N'360.0000')
GO

INSERT INTO [dbo].[flightInfo] ([flightNo], [airwaysId], [leaveCity], [destinationCity], [leaveTime], [landTime], [price]) VALUES (N'CZ3157', N'4', N'1', N'5', N'09:00', N'11:45', N'1200.0000')
GO

INSERT INTO [dbo].[flightInfo] ([flightNo], [airwaysId], [leaveCity], [destinationCity], [leaveTime], [landTime], [price]) VALUES (N'CZ5102', N'4', N'1', N'2', N'08:00', N'10:00', N'390.0000')
GO

INSERT INTO [dbo].[flightInfo] ([flightNo], [airwaysId], [leaveCity], [destinationCity], [leaveTime], [landTime], [price]) VALUES (N'CZ6657', N'4', N'1', N'8', N'07:40', N'09:40', N'1100.0000')
GO

INSERT INTO [dbo].[flightInfo] ([flightNo], [airwaysId], [leaveCity], [destinationCity], [leaveTime], [landTime], [price]) VALUES (N'CZ6718', N'4', N'1', N'3', N'09:00', N'12:50', N'1300.0000')
GO

INSERT INTO [dbo].[flightInfo] ([flightNo], [airwaysId], [leaveCity], [destinationCity], [leaveTime], [landTime], [price]) VALUES (N'HU7129', N'3', N'1', N'8', N'09:40', N'11:20', N'1300.0000')
GO

INSERT INTO [dbo].[flightInfo] ([flightNo], [airwaysId], [leaveCity], [destinationCity], [leaveTime], [landTime], [price]) VALUES (N'HU7279', N'3', N'1', N'3', N'10:22', N'14:55', N'1420.0000')
GO

INSERT INTO [dbo].[flightInfo] ([flightNo], [airwaysId], [leaveCity], [destinationCity], [leaveTime], [landTime], [price]) VALUES (N'HU7605', N'3', N'1', N'2', N'08:40', N'10:50', N'480.0000')
GO

INSERT INTO [dbo].[flightInfo] ([flightNo], [airwaysId], [leaveCity], [destinationCity], [leaveTime], [landTime], [price]) VALUES (N'MU5102', N'4', N'1', N'2', N'08:00', N'10:00', N'390.0000')
GO

INSERT INTO [dbo].[flightInfo] ([flightNo], [airwaysId], [leaveCity], [destinationCity], [leaveTime], [landTime], [price]) VALUES (N'MU7130', N'4', N'1', N'5', N'09:00', N'11:45', N'1200.0000')
GO

INSERT INTO [dbo].[flightInfo] ([flightNo], [airwaysId], [leaveCity], [destinationCity], [leaveTime], [landTime], [price]) VALUES (N'ZH9890', N'7', N'1', N'5', N'08:40', N'11:40', N'1200.0000')
GO


-- ----------------------------
-- Table structure for LoginIn
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[LoginIn]') AND type IN ('U'))
	DROP TABLE [dbo].[LoginIn]
GO

CREATE TABLE [dbo].[LoginIn] (
  [useId] nchar(10) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [psWord] nchar(10) COLLATE Chinese_PRC_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[LoginIn] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of LoginIn
-- ----------------------------
INSERT INTO [dbo].[LoginIn] ([useId], [psWord]) VALUES (N'1         ', N'1         ')
GO

INSERT INTO [dbo].[LoginIn] ([useId], [psWord]) VALUES (N't         ', N't         ')
GO

INSERT INTO [dbo].[LoginIn] ([useId], [psWord]) VALUES (N'123       ', N'123       ')
GO

INSERT INTO [dbo].[LoginIn] ([useId], [psWord]) VALUES (N'111       ', N'111       ')
GO

INSERT INTO [dbo].[LoginIn] ([useId], [psWord]) VALUES (N'123       ', N'123       ')
GO


-- ----------------------------
-- Table structure for orderInfo
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[orderInfo]') AND type IN ('U'))
	DROP TABLE [dbo].[orderInfo]
GO

CREATE TABLE [dbo].[orderInfo] (
  [orderId] int  NOT NULL,
  [flightNo] nvarchar(50) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [leaveDate] nvarchar(50) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [landTime] nvarchar(50) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [price] money  NOT NULL,
  [Number] int  NOT NULL,
  [leavePlace] nchar(10) COLLATE Chinese_PRC_CI_AS  NULL,
  [landPlace] nchar(10) COLLATE Chinese_PRC_CI_AS  NULL,
  [useId] nchar(10) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[orderInfo] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of orderInfo
-- ----------------------------
INSERT INTO [dbo].[orderInfo] ([orderId], [flightNo], [leaveDate], [landTime], [price], [Number], [leavePlace], [landPlace], [useId]) VALUES (N'5433031', N'CA984', N'2021/6/23', N'09:30', N'360.0000', N'1', N'北京        ', N'上海        ', N't         ')
GO

INSERT INTO [dbo].[orderInfo] ([orderId], [flightNo], [leaveDate], [landTime], [price], [Number], [leavePlace], [landPlace], [useId]) VALUES (N'9213930', N'CA984', N'2021/6/22', N'09:30', N'360.0000', N'1', N'北京        ', N'上海        ', N'1         ')
GO

INSERT INTO [dbo].[orderInfo] ([orderId], [flightNo], [leaveDate], [landTime], [price], [Number], [leavePlace], [landPlace], [useId]) VALUES (N'9743084', N'CA984', N'2021/6/29', N'09:30', N'360.0000', N'2', N'北京        ', N'上海        ', N'1         ')
GO

INSERT INTO [dbo].[orderInfo] ([orderId], [flightNo], [leaveDate], [landTime], [price], [Number], [leavePlace], [landPlace], [useId]) VALUES (N'8482055', N'CA984', N'2021/9/10', N'09:30', N'360.0000', N'1', N'北京        ', N'上海        ', N'111       ')
GO

INSERT INTO [dbo].[orderInfo] ([orderId], [flightNo], [leaveDate], [landTime], [price], [Number], [leavePlace], [landPlace], [useId]) VALUES (N'8256577', N'MU5102', N'2021/9/24', N'10:00', N'390.0000', N'1', N'北京        ', N'上海        ', N'123       ')
GO


-- ----------------------------
-- Auto increment value for airwaysInfo
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[airwaysInfo]', RESEED, 8)
GO


-- ----------------------------
-- Primary Key structure for table airwaysInfo
-- ----------------------------
ALTER TABLE [dbo].[airwaysInfo] ADD CONSTRAINT [PK_airwaysInfo_id] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for cityInfo
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[cityInfo]', RESEED, 8)
GO


-- ----------------------------
-- Primary Key structure for table cityInfo
-- ----------------------------
ALTER TABLE [dbo].[cityInfo] ADD CONSTRAINT [PK_id] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table flightInfo
-- ----------------------------
ALTER TABLE [dbo].[flightInfo] ADD CONSTRAINT [PK_flightInfo_flightNo] PRIMARY KEY CLUSTERED ([flightNo])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Foreign Keys structure for table flightInfo
-- ----------------------------
ALTER TABLE [dbo].[flightInfo] ADD CONSTRAINT [FK_flightInfo_airwaysId] FOREIGN KEY ([airwaysId]) REFERENCES [dbo].[airwaysInfo] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[flightInfo] ADD CONSTRAINT [FK_flightInfo_leaveCity] FOREIGN KEY ([leaveCity]) REFERENCES [dbo].[cityInfo] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[flightInfo] ADD CONSTRAINT [FK_flightInfo_destinationCity] FOREIGN KEY ([destinationCity]) REFERENCES [dbo].[cityInfo] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


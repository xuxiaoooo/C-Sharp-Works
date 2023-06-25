/*
 Navicat Premium Data Transfer

 Source Server         : localhost
 Source Server Type    : SQL Server
 Source Server Version : 15002000
 Source Host           : localhost:1433
 Source Catalog        : db_library_Data
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 15002000
 File Encoding         : 65001

 Date: 28/12/2021 11:04:28
*/


-- ----------------------------
-- Table structure for book
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[book]') AND type IN ('U'))
	DROP TABLE [dbo].[book]
GO

CREATE TABLE [dbo].[book] (
  [bno] int  IDENTITY(1,1) NOT NULL,
  [kno] int  NULL,
  [bookname] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [author] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [price] money  NULL,
  [publishtime] datetime2(7)  NULL,
  [press] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [translator] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[book] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of book
-- ----------------------------
SET IDENTITY_INSERT [dbo].[book] ON
GO

INSERT INTO [dbo].[book] ([bno], [kno], [bookname], [author], [price], [publishtime], [press], [translator]) VALUES (N'1', N'1', N'1', N'1', N'1.0000', N'2021-12-28 02:33:31.0000000', N'1', N'11')
GO

SET IDENTITY_INSERT [dbo].[book] OFF
GO


-- ----------------------------
-- Table structure for bookkind
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[bookkind]') AND type IN ('U'))
	DROP TABLE [dbo].[bookkind]
GO

CREATE TABLE [dbo].[bookkind] (
  [no] int  NOT NULL,
  [kindname] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [canborrowdate] nvarchar(1) COLLATE Chinese_PRC_CI_AS  NULL,
  [penalty] money  NULL
)
GO

ALTER TABLE [dbo].[bookkind] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of bookkind
-- ----------------------------
INSERT INTO [dbo].[bookkind] ([no], [kindname], [canborrowdate], [penalty]) VALUES (N'1', N'玄幻', N'3', N'2.0000')
GO

INSERT INTO [dbo].[bookkind] ([no], [kindname], [canborrowdate], [penalty]) VALUES (N'2', N'名著', N'5', N'2.0000')
GO


-- ----------------------------
-- Table structure for borrowinfo
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[borrowinfo]') AND type IN ('U'))
	DROP TABLE [dbo].[borrowinfo]
GO

CREATE TABLE [dbo].[borrowinfo] (
  [no] int  IDENTITY(1,1) NOT NULL,
  [readerno] nvarchar(1) COLLATE Chinese_PRC_CI_AS  NULL,
  [operatorno] int  NULL,
  [bookno] int  NULL,
  [isreturned] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [returntime] datetime2(7)  NULL,
  [borrowtime] datetime2(7)  NULL
)
GO

ALTER TABLE [dbo].[borrowinfo] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of borrowinfo
-- ----------------------------
SET IDENTITY_INSERT [dbo].[borrowinfo] ON
GO

INSERT INTO [dbo].[borrowinfo] ([no], [readerno], [operatorno], [bookno], [isreturned], [returntime], [borrowtime]) VALUES (N'1', N'1', N'1', N'1', N'1', N'2021-12-28 08:29:28.0000000', N'2021-12-28 08:16:18.0000000')
GO

INSERT INTO [dbo].[borrowinfo] ([no], [readerno], [operatorno], [bookno], [isreturned], [returntime], [borrowtime]) VALUES (N'2', N'1', N'1', N'1', N'0', NULL, N'2021-12-28 08:40:25.0000000')
GO

SET IDENTITY_INSERT [dbo].[borrowinfo] OFF
GO


-- ----------------------------
-- Table structure for inventory
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[inventory]') AND type IN ('U'))
	DROP TABLE [dbo].[inventory]
GO

CREATE TABLE [dbo].[inventory] (
  [no] int  NOT NULL,
  [num] int  NULL
)
GO

ALTER TABLE [dbo].[inventory] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of inventory
-- ----------------------------

-- ----------------------------
-- Table structure for operator
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[operator]') AND type IN ('U'))
	DROP TABLE [dbo].[operator]
GO

CREATE TABLE [dbo].[operator] (
  [no] int  IDENTITY(1,1) NOT NULL,
  [name] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [sex] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [age] int  NULL,
  [phone] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [idcard] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [isadmin] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [workdate] datetime2(7)  NULL,
  [code] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[operator] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of operator
-- ----------------------------
SET IDENTITY_INSERT [dbo].[operator] ON
GO

INSERT INTO [dbo].[operator] ([no], [name], [sex], [age], [phone], [idcard], [isadmin], [workdate], [code]) VALUES (N'1', N'tsoft', NULL, NULL, NULL, NULL, N'1', NULL, N'1')
GO

INSERT INTO [dbo].[operator] ([no], [name], [sex], [age], [phone], [idcard], [isadmin], [workdate], [code]) VALUES (N'2', N'1', NULL, NULL, NULL, NULL, N'1', NULL, N'1')
GO

SET IDENTITY_INSERT [dbo].[operator] OFF
GO


-- ----------------------------
-- Table structure for order
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[order]') AND type IN ('U'))
	DROP TABLE [dbo].[order]
GO

CREATE TABLE [dbo].[order] (
  [no] int  IDENTITY(1,1) NOT NULL,
  [orderdate] datetime2(7)  NULL,
  [bno] int  NULL,
  [num] int  NULL,
  [operator] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [ischecked] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [discount] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[order] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of order
-- ----------------------------
SET IDENTITY_INSERT [dbo].[order] ON
GO

SET IDENTITY_INSERT [dbo].[order] OFF
GO


-- ----------------------------
-- Table structure for reader
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[reader]') AND type IN ('U'))
	DROP TABLE [dbo].[reader]
GO

CREATE TABLE [dbo].[reader] (
  [code] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [name] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [sex] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [age] int  NULL,
  [phone] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [guarantee-deposit] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [birthday] datetime  NULL,
  [job] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [IDnumber] int  NULL,
  [maxborrownum] int  NULL,
  [dateofregistration] datetime2(7)  NULL,
  [IDkind] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[reader] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of reader
-- ----------------------------
INSERT INTO [dbo].[reader] ([code], [name], [sex], [age], [phone], [guarantee-deposit], [birthday], [job], [IDnumber], [maxborrownum], [dateofregistration], [IDkind]) VALUES (N'1', N'11', N'男', N'111', N'11', N'11', N'2021-12-27 20:06:18.000', N'11', N'11', NULL, N'2021-12-27 20:06:24.0000000', N'111')
GO


-- ----------------------------
-- Auto increment value for book
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[book]', RESEED, 1)
GO


-- ----------------------------
-- Primary Key structure for table book
-- ----------------------------
ALTER TABLE [dbo].[book] ADD CONSTRAINT [PK__book__DE97B98855B31B42] PRIMARY KEY CLUSTERED ([bno])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table bookkind
-- ----------------------------
ALTER TABLE [dbo].[bookkind] ADD CONSTRAINT [PK__bookkind__3213D08017E7ACCC] PRIMARY KEY CLUSTERED ([no])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for borrowinfo
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[borrowinfo]', RESEED, 2)
GO


-- ----------------------------
-- Primary Key structure for table borrowinfo
-- ----------------------------
ALTER TABLE [dbo].[borrowinfo] ADD CONSTRAINT [PK__borrowin__3213D08016CFAFE7] PRIMARY KEY CLUSTERED ([no])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table inventory
-- ----------------------------
ALTER TABLE [dbo].[inventory] ADD CONSTRAINT [PK__inventor__3213D080E670B04B] PRIMARY KEY CLUSTERED ([no])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for operator
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[operator]', RESEED, 2)
GO


-- ----------------------------
-- Primary Key structure for table operator
-- ----------------------------
ALTER TABLE [dbo].[operator] ADD CONSTRAINT [PK__operator__3213D08024C2D506] PRIMARY KEY CLUSTERED ([no])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for order
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[order]', RESEED, 1)
GO


-- ----------------------------
-- Primary Key structure for table order
-- ----------------------------
ALTER TABLE [dbo].[order] ADD CONSTRAINT [PK__order__3213D080FF99E7E7] PRIMARY KEY CLUSTERED ([no])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table reader
-- ----------------------------
ALTER TABLE [dbo].[reader] ADD CONSTRAINT [PK__reader__357D4CF84B27E85C] PRIMARY KEY CLUSTERED ([code])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


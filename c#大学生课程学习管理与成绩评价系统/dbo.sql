/*
 Navicat Premium Data Transfer

 Source Server         : SQLserver
 Source Server Type    : SQL Server
 Source Server Version : 15002000
 Source Host           : 127.0.0.1:1433
 Source Catalog        : stuChooseClassSys
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 15002000
 File Encoding         : 65001

 Date: 11/01/2022 01:57:46
*/


-- ----------------------------
-- Table structure for ClassRoom
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ClassRoom]') AND type IN ('U'))
	DROP TABLE [dbo].[ClassRoom]
GO

CREATE TABLE [dbo].[ClassRoom] (
  [CRNO] int  IDENTITY(1,1) NOT NULL,
  [CRFloor] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [CRCount] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [CRInfo] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[ClassRoom] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of ClassRoom
-- ----------------------------
SET IDENTITY_INSERT [dbo].[ClassRoom] ON
GO

SET IDENTITY_INSERT [dbo].[ClassRoom] OFF
GO


-- ----------------------------
-- Table structure for Course
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Course]') AND type IN ('U'))
	DROP TABLE [dbo].[Course]
GO

CREATE TABLE [dbo].[Course] (
  [CNO] int  IDENTITY(1,1) NOT NULL,
  [CName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [CType] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [CCredit] float(53)  NULL,
  [CTime] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [CTotalCount] int  NULL
)
GO

ALTER TABLE [dbo].[Course] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Course
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Course] ON
GO

INSERT INTO [dbo].[Course] ([CNO], [CName], [CType], [CCredit], [CTime], [CTotalCount]) VALUES (N'1', N'思修', N'基础必修', N'4', N'周一上午1-3节课', N'49')
GO

INSERT INTO [dbo].[Course] ([CNO], [CName], [CType], [CCredit], [CTime], [CTotalCount]) VALUES (N'2', N'软件工程', N'专业必修', N'4', N'周一下午1-3节课', N'30')
GO

INSERT INTO [dbo].[Course] ([CNO], [CName], [CType], [CCredit], [CTime], [CTotalCount]) VALUES (N'3', N'影视鉴赏', N'选修', N'4', N'周六上午1-3节课', N'99')
GO

SET IDENTITY_INSERT [dbo].[Course] OFF
GO


-- ----------------------------
-- Table structure for Depart
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Depart]') AND type IN ('U'))
	DROP TABLE [dbo].[Depart]
GO

CREATE TABLE [dbo].[Depart] (
  [DNO] int  IDENTITY(1,1) NOT NULL,
  [DName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [DPhone] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[Depart] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Depart
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Depart] ON
GO

SET IDENTITY_INSERT [dbo].[Depart] OFF
GO


-- ----------------------------
-- Table structure for SelectCourse
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectCourse]') AND type IN ('U'))
	DROP TABLE [dbo].[SelectCourse]
GO

CREATE TABLE [dbo].[SelectCourse] (
  [SNO] int  NULL,
  [CNO] int  NULL,
  [Grade] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[SelectCourse] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of SelectCourse
-- ----------------------------
INSERT INTO [dbo].[SelectCourse] ([SNO], [CNO], [Grade]) VALUES (N'1', N'1', N'89')
GO

INSERT INTO [dbo].[SelectCourse] ([SNO], [CNO], [Grade]) VALUES (N'1', N'2', N'78')
GO

INSERT INTO [dbo].[SelectCourse] ([SNO], [CNO], [Grade]) VALUES (N'1', N'3', N'99')
GO


-- ----------------------------
-- Table structure for Student
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Student]') AND type IN ('U'))
	DROP TABLE [dbo].[Student]
GO

CREATE TABLE [dbo].[Student] (
  [SNO] int  IDENTITY(1,1) NOT NULL,
  [SName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [SSex] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [SBorn] datetime  NULL,
  [SPassword] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[Student] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Student
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Student] ON
GO

INSERT INTO [dbo].[Student] ([SNO], [SName], [SSex], [SBorn], [SPassword]) VALUES (N'1', N'123', N'女', N'2022-01-09 21:19:07.000', N'1')
GO

SET IDENTITY_INSERT [dbo].[Student] OFF
GO


-- ----------------------------
-- Table structure for Teacher
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Teacher]') AND type IN ('U'))
	DROP TABLE [dbo].[Teacher]
GO

CREATE TABLE [dbo].[Teacher] (
  [TNO] int  IDENTITY(1,1) NOT NULL,
  [TName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [TLevel] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [TPhone] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [TPassword] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[Teacher] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Teacher
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Teacher] ON
GO

INSERT INTO [dbo].[Teacher] ([TNO], [TName], [TLevel], [TPhone], [TPassword]) VALUES (N'1', N't1', N'教师', N'12345', N'1')
GO

SET IDENTITY_INSERT [dbo].[Teacher] OFF
GO


-- ----------------------------
-- Auto increment value for ClassRoom
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[ClassRoom]', RESEED, 1)
GO


-- ----------------------------
-- Primary Key structure for table ClassRoom
-- ----------------------------
ALTER TABLE [dbo].[ClassRoom] ADD CONSTRAINT [PK__ClassRoo__F23795F1AFCA0FE4] PRIMARY KEY CLUSTERED ([CRNO])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Course
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Course]', RESEED, 3)
GO


-- ----------------------------
-- Primary Key structure for table Course
-- ----------------------------
ALTER TABLE [dbo].[Course] ADD CONSTRAINT [PK__Course__C1FF677BAE92C889] PRIMARY KEY CLUSTERED ([CNO])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Depart
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Depart]', RESEED, 1)
GO


-- ----------------------------
-- Primary Key structure for table Depart
-- ----------------------------
ALTER TABLE [dbo].[Depart] ADD CONSTRAINT [PK__Depart__C035B8C21EBBD669] PRIMARY KEY CLUSTERED ([DNO])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Uniques structure for table SelectCourse
-- ----------------------------
ALTER TABLE [dbo].[SelectCourse] ADD CONSTRAINT [1] UNIQUE NONCLUSTERED ([SNO] ASC, [CNO] ASC)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Student
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Student]', RESEED, 4)
GO


-- ----------------------------
-- Primary Key structure for table Student
-- ----------------------------
ALTER TABLE [dbo].[Student] ADD CONSTRAINT [PK__Student__CA1EE06CA16EA369] PRIMARY KEY CLUSTERED ([SNO])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Teacher
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Teacher]', RESEED, 1)
GO


-- ----------------------------
-- Primary Key structure for table Teacher
-- ----------------------------
ALTER TABLE [dbo].[Teacher] ADD CONSTRAINT [PK__Teacher__C4553DD57E33F95C] PRIMARY KEY CLUSTERED ([TNO])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


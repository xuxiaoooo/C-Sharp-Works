/*
 Navicat Premium Data Transfer

 Source Server         : localhost
 Source Server Type    : SQL Server
 Source Server Version : 15002000
 Source Host           : localhost:1433
 Source Catalog        : outtechmanage
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 15002000
 File Encoding         : 65001

 Date: 30/06/2021 13:13:57
*/


-- ----------------------------
-- Table structure for course
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[course]') AND type IN ('U'))
	DROP TABLE [dbo].[course]
GO

CREATE TABLE [dbo].[course] (
  [id] int  NOT NULL,
  [coursename] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[course] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of course
-- ----------------------------
INSERT INTO [dbo].[course] ([id], [coursename]) VALUES (N'1', N'语文')
GO

INSERT INTO [dbo].[course] ([id], [coursename]) VALUES (N'2', N'数学')
GO

INSERT INTO [dbo].[course] ([id], [coursename]) VALUES (N'3', N'英语')
GO

INSERT INTO [dbo].[course] ([id], [coursename]) VALUES (N'4', N'物理')
GO

INSERT INTO [dbo].[course] ([id], [coursename]) VALUES (N'5', N'化学')
GO

INSERT INTO [dbo].[course] ([id], [coursename]) VALUES (N'6', N'地理')
GO

INSERT INTO [dbo].[course] ([id], [coursename]) VALUES (N'7', N'历史')
GO

INSERT INTO [dbo].[course] ([id], [coursename]) VALUES (N'8', N'政治')
GO


-- ----------------------------
-- Table structure for teacherinfo
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[teacherinfo]') AND type IN ('U'))
	DROP TABLE [dbo].[teacherinfo]
GO

CREATE TABLE [dbo].[teacherinfo] (
  [id] int  IDENTITY(1,1) NOT NULL,
  [name] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [faculty] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [coursenum] int  NULL,
  [degree] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[teacherinfo] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of teacherinfo
-- ----------------------------
SET IDENTITY_INSERT [dbo].[teacherinfo] ON
GO

INSERT INTO [dbo].[teacherinfo] ([id], [name], [faculty], [coursenum], [degree]) VALUES (N'1', N't1', N'语文', N'2', N'本科')
GO

INSERT INTO [dbo].[teacherinfo] ([id], [name], [faculty], [coursenum], [degree]) VALUES (N'2', N't2', N'数学', N'1', N'硕士')
GO

INSERT INTO [dbo].[teacherinfo] ([id], [name], [faculty], [coursenum], [degree]) VALUES (N'3', N't3', N'英语', N'2', N'硕士')
GO

INSERT INTO [dbo].[teacherinfo] ([id], [name], [faculty], [coursenum], [degree]) VALUES (N'4', N't4', N'物理', N'1', N'硕士')
GO

INSERT INTO [dbo].[teacherinfo] ([id], [name], [faculty], [coursenum], [degree]) VALUES (N'5', N't5', N'化学', N'2', N'本科')
GO

INSERT INTO [dbo].[teacherinfo] ([id], [name], [faculty], [coursenum], [degree]) VALUES (N'6', N't6', N'地理', N'3', N'本科')
GO

INSERT INTO [dbo].[teacherinfo] ([id], [name], [faculty], [coursenum], [degree]) VALUES (N'7', N't7', N'历史', N'2', N'本科')
GO

INSERT INTO [dbo].[teacherinfo] ([id], [name], [faculty], [coursenum], [degree]) VALUES (N'8', N't8', N'政治', N'3', N'博士')
GO

SET IDENTITY_INSERT [dbo].[teacherinfo] OFF
GO


-- ----------------------------
-- Table structure for user
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[user]') AND type IN ('U'))
	DROP TABLE [dbo].[user]
GO

CREATE TABLE [dbo].[user] (
  [id] int  IDENTITY(1,1) NOT NULL,
  [password] varchar(50) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[user] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of user
-- ----------------------------
SET IDENTITY_INSERT [dbo].[user] ON
GO

INSERT INTO [dbo].[user] ([id], [password]) VALUES (N'1', N'1')
GO

SET IDENTITY_INSERT [dbo].[user] OFF
GO


-- ----------------------------
-- Primary Key structure for table course
-- ----------------------------
ALTER TABLE [dbo].[course] ADD CONSTRAINT [PK__course__3213E83F7F5C5236] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for teacherinfo
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[teacherinfo]', RESEED, 10)
GO


-- ----------------------------
-- Primary Key structure for table teacherinfo
-- ----------------------------
ALTER TABLE [dbo].[teacherinfo] ADD CONSTRAINT [PK__teacheri__3213E83F1AF81881] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for user
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[user]', RESEED, 1)
GO


-- ----------------------------
-- Primary Key structure for table user
-- ----------------------------
ALTER TABLE [dbo].[user] ADD CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


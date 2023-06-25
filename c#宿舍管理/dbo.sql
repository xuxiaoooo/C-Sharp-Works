/*
 Navicat Premium Data Transfer

 Source Server         : SQLserver
 Source Server Type    : SQL Server
 Source Server Version : 15002000
 Source Host           : 127.0.0.1:1433
 Source Catalog        : dms
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 15002000
 File Encoding         : 65001

 Date: 10/02/2022 13:02:29
*/


-- ----------------------------
-- Table structure for admin
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[admin]') AND type IN ('U'))
	DROP TABLE [dbo].[admin]
GO

CREATE TABLE [dbo].[admin] (
  [id] int  IDENTITY(1,1) NOT NULL,
  [aname] varchar(10) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [password] varchar(10) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [tel] varchar(20) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [power] tinyint  NOT NULL
)
GO

ALTER TABLE [dbo].[admin] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of admin
-- ----------------------------
SET IDENTITY_INSERT [dbo].[admin] ON
GO

INSERT INTO [dbo].[admin] ([id], [aname], [password], [tel], [power]) VALUES (N'9', N'a', N'a', N'1', N'0')
GO

INSERT INTO [dbo].[admin] ([id], [aname], [password], [tel], [power]) VALUES (N'10', N'b', N'b', N'2', N'0')
GO

INSERT INTO [dbo].[admin] ([id], [aname], [password], [tel], [power]) VALUES (N'11', N'c', N'c', N'3', N'1')
GO

INSERT INTO [dbo].[admin] ([id], [aname], [password], [tel], [power]) VALUES (N'12', N'd', N'd', N'4', N'2')
GO

SET IDENTITY_INSERT [dbo].[admin] OFF
GO


-- ----------------------------
-- Table structure for dormitory
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[dormitory]') AND type IN ('U'))
	DROP TABLE [dbo].[dormitory]
GO

CREATE TABLE [dbo].[dormitory] (
  [id] int  IDENTITY(1,1) NOT NULL,
  [a_id] int  NOT NULL,
  [ch] char(1) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [num] int  NOT NULL,
  [s_gender] varchar(10) COLLATE Chinese_PRC_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[dormitory] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of dormitory
-- ----------------------------
SET IDENTITY_INSERT [dbo].[dormitory] ON
GO

INSERT INTO [dbo].[dormitory] ([id], [a_id], [ch], [num], [s_gender]) VALUES (N'5', N'9', N'C', N'14', N'女')
GO

INSERT INTO [dbo].[dormitory] ([id], [a_id], [ch], [num], [s_gender]) VALUES (N'7', N'10', N'C', N'15', N'男')
GO

SET IDENTITY_INSERT [dbo].[dormitory] OFF
GO


-- ----------------------------
-- Table structure for in_out
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[in_out]') AND type IN ('U'))
	DROP TABLE [dbo].[in_out]
GO

CREATE TABLE [dbo].[in_out] (
  [id] int  IDENTITY(1,1) NOT NULL,
  [d_id] int  NOT NULL,
  [s_id] int  NOT NULL,
  [out_date] datetime  NOT NULL,
  [in_date] datetime  NULL
)
GO

ALTER TABLE [dbo].[in_out] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of in_out
-- ----------------------------
SET IDENTITY_INSERT [dbo].[in_out] ON
GO

INSERT INTO [dbo].[in_out] ([id], [d_id], [s_id], [out_date], [in_date]) VALUES (N'9', N'5', N'96', N'2022-02-08 19:33:52.000', N'2022-02-08 20:28:57.000')
GO

SET IDENTITY_INSERT [dbo].[in_out] OFF
GO


-- ----------------------------
-- Table structure for major
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[major]') AND type IN ('U'))
	DROP TABLE [dbo].[major]
GO

CREATE TABLE [dbo].[major] (
  [id] int  IDENTITY(1,1) NOT NULL,
  [name] varchar(50) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [m_id] int  NOT NULL
)
GO

ALTER TABLE [dbo].[major] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of major
-- ----------------------------
SET IDENTITY_INSERT [dbo].[major] ON
GO

INSERT INTO [dbo].[major] ([id], [name], [m_id]) VALUES (N'1', N'计算机工程学院', N'0')
GO

INSERT INTO [dbo].[major] ([id], [name], [m_id]) VALUES (N'2', N'管理学院', N'0')
GO

INSERT INTO [dbo].[major] ([id], [name], [m_id]) VALUES (N'3', N'软件工程', N'1')
GO

INSERT INTO [dbo].[major] ([id], [name], [m_id]) VALUES (N'4', N'计算机科学与技术', N'1')
GO

INSERT INTO [dbo].[major] ([id], [name], [m_id]) VALUES (N'5', N'财务管理', N'2')
GO

SET IDENTITY_INSERT [dbo].[major] OFF
GO


-- ----------------------------
-- Table structure for room
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[room]') AND type IN ('U'))
	DROP TABLE [dbo].[room]
GO

CREATE TABLE [dbo].[room] (
  [id] int  IDENTITY(1,1) NOT NULL,
  [d_id] int  NOT NULL,
  [num] int  NOT NULL,
  [margin] tinyint  NOT NULL,
  [price] int  NOT NULL
)
GO

ALTER TABLE [dbo].[room] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of room
-- ----------------------------
SET IDENTITY_INSERT [dbo].[room] ON
GO

INSERT INTO [dbo].[room] ([id], [d_id], [num], [margin], [price]) VALUES (N'7', N'5', N'247', N'2', N'1500')
GO

INSERT INTO [dbo].[room] ([id], [d_id], [num], [margin], [price]) VALUES (N'8', N'7', N'249', N'2', N'1500')
GO

INSERT INTO [dbo].[room] ([id], [d_id], [num], [margin], [price]) VALUES (N'9', N'5', N'248', N'4', N'1500')
GO

INSERT INTO [dbo].[room] ([id], [d_id], [num], [margin], [price]) VALUES (N'12', N'7', N'250', N'4', N'1500')
GO

SET IDENTITY_INSERT [dbo].[room] OFF
GO


-- ----------------------------
-- Table structure for student
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[student]') AND type IN ('U'))
	DROP TABLE [dbo].[student]
GO

CREATE TABLE [dbo].[student] (
  [id] int  IDENTITY(1,1) NOT NULL,
  [sno] varchar(20) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [sname] varchar(10) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [gender] varchar(10) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [age] int  NOT NULL,
  [tel] varchar(20) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [u_id] int  NOT NULL,
  [m_id] int  NOT NULL,
  [class] int  NOT NULL,
  [d_id] int  NOT NULL,
  [r_id] int  NOT NULL
)
GO

ALTER TABLE [dbo].[student] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of student
-- ----------------------------
SET IDENTITY_INSERT [dbo].[student] ON
GO

INSERT INTO [dbo].[student] ([id], [sno], [sname], [gender], [age], [tel], [u_id], [m_id], [class], [d_id], [r_id]) VALUES (N'91', N'1', N'张三', N'男', N'21', N'11', N'1', N'3', N'2014', N'7', N'8')
GO

INSERT INTO [dbo].[student] ([id], [sno], [sname], [gender], [age], [tel], [u_id], [m_id], [class], [d_id], [r_id]) VALUES (N'92', N'2', N'李四', N'男', N'22', N'22', N'1', N'4', N'2014', N'7', N'8')
GO

INSERT INTO [dbo].[student] ([id], [sno], [sname], [gender], [age], [tel], [u_id], [m_id], [class], [d_id], [r_id]) VALUES (N'93', N'3', N'小红', N'女', N'21', N'33', N'2', N'5', N'2013', N'5', N'7')
GO

INSERT INTO [dbo].[student] ([id], [sno], [sname], [gender], [age], [tel], [u_id], [m_id], [class], [d_id], [r_id]) VALUES (N'96', N'4', N'小微', N'女', N'22', N'44', N'2', N'5', N'2013', N'5', N'7')
GO

SET IDENTITY_INSERT [dbo].[student] OFF
GO


-- ----------------------------
-- Table structure for visit
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[visit]') AND type IN ('U'))
	DROP TABLE [dbo].[visit]
GO

CREATE TABLE [dbo].[visit] (
  [id] int  IDENTITY(1,1) NOT NULL,
  [d_id] int  NOT NULL,
  [s_id] int  NOT NULL,
  [name] varchar(10) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [in_date] datetime  NOT NULL,
  [out_date] datetime  NULL
)
GO

ALTER TABLE [dbo].[visit] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of visit
-- ----------------------------
SET IDENTITY_INSERT [dbo].[visit] ON
GO

INSERT INTO [dbo].[visit] ([id], [d_id], [s_id], [name], [in_date], [out_date]) VALUES (N'10', N'5', N'93', N'A', N'2016-12-16 03:39:45.000', N'2016-12-16 03:39:53.000')
GO

INSERT INTO [dbo].[visit] ([id], [d_id], [s_id], [name], [in_date], [out_date]) VALUES (N'11', N'5', N'96', N'123', N'2021-05-29 19:50:27.000', N'2022-02-08 20:29:21.000')
GO

INSERT INTO [dbo].[visit] ([id], [d_id], [s_id], [name], [in_date], [out_date]) VALUES (N'12', N'5', N'96', N'123', N'2021-05-29 19:51:56.000', N'2022-02-08 20:29:21.000')
GO

INSERT INTO [dbo].[visit] ([id], [d_id], [s_id], [name], [in_date], [out_date]) VALUES (N'13', N'5', N'96', N'123', N'2021-05-29 19:51:57.000', N'2022-02-08 20:29:21.000')
GO

INSERT INTO [dbo].[visit] ([id], [d_id], [s_id], [name], [in_date], [out_date]) VALUES (N'14', N'5', N'93', N'小红', N'2022-02-08 20:29:19.000', NULL)
GO

SET IDENTITY_INSERT [dbo].[visit] OFF
GO


-- ----------------------------
-- View structure for dormitory_in_out
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[dormitory_in_out]') AND type IN ('V'))
	DROP VIEW [dbo].[dormitory_in_out]
GO

CREATE VIEW [dbo].[dormitory_in_out] AS SELECT     dbo.dormitory.a_id, dbo.dormitory.ch, dbo.dormitory.num, dbo.dormitory.s_gender, dbo.in_out.s_id, dbo.in_out.out_date, dbo.in_out.in_date
FROM         dbo.dormitory INNER JOIN
                      dbo.in_out ON dbo.dormitory.id = dbo.in_out.d_id
GO


-- ----------------------------
-- View structure for dormitory_room
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[dormitory_room]') AND type IN ('V'))
	DROP VIEW [dbo].[dormitory_room]
GO

CREATE VIEW [dbo].[dormitory_room] AS SELECT     dbo.dormitory.a_id, dbo.dormitory.ch, dbo.dormitory.num, dbo.dormitory.s_gender, dbo.room.num AS room_num, dbo.room.margin, dbo.room.price
FROM         dbo.dormitory INNER JOIN
                      dbo.room ON dbo.dormitory.id = dbo.room.d_id
GO


-- ----------------------------
-- View structure for dormitory_visit
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[dormitory_visit]') AND type IN ('V'))
	DROP VIEW [dbo].[dormitory_visit]
GO

CREATE VIEW [dbo].[dormitory_visit] AS SELECT     dbo.dormitory.a_id, dbo.dormitory.ch, dbo.dormitory.num, dbo.dormitory.s_gender, dbo.visit.s_id, dbo.visit.name, dbo.visit.in_date, dbo.visit.out_date
FROM         dbo.dormitory INNER JOIN
                      dbo.visit ON dbo.dormitory.id = dbo.visit.d_id
GO


-- ----------------------------
-- Auto increment value for admin
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[admin]', RESEED, 12)
GO


-- ----------------------------
-- Primary Key structure for table admin
-- ----------------------------
ALTER TABLE [dbo].[admin] ADD CONSTRAINT [PK_admin] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for dormitory
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[dormitory]', RESEED, 7)
GO


-- ----------------------------
-- Primary Key structure for table dormitory
-- ----------------------------
ALTER TABLE [dbo].[dormitory] ADD CONSTRAINT [PK_dormitory] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for in_out
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[in_out]', RESEED, 9)
GO


-- ----------------------------
-- Primary Key structure for table in_out
-- ----------------------------
ALTER TABLE [dbo].[in_out] ADD CONSTRAINT [PK_in_out] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for major
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[major]', RESEED, 5)
GO


-- ----------------------------
-- Primary Key structure for table major
-- ----------------------------
ALTER TABLE [dbo].[major] ADD CONSTRAINT [PK_major] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for room
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[room]', RESEED, 12)
GO


-- ----------------------------
-- Primary Key structure for table room
-- ----------------------------
ALTER TABLE [dbo].[room] ADD CONSTRAINT [PK_room_1] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for student
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[student]', RESEED, 96)
GO


-- ----------------------------
-- Primary Key structure for table student
-- ----------------------------
ALTER TABLE [dbo].[student] ADD CONSTRAINT [PK_student] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for visit
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[visit]', RESEED, 14)
GO


-- ----------------------------
-- Primary Key structure for table visit
-- ----------------------------
ALTER TABLE [dbo].[visit] ADD CONSTRAINT [PK_visit] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Foreign Keys structure for table in_out
-- ----------------------------
ALTER TABLE [dbo].[in_out] ADD CONSTRAINT [FK_in_out_student] FOREIGN KEY ([s_id]) REFERENCES [dbo].[student] ([id]) ON DELETE CASCADE ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[in_out] ADD CONSTRAINT [FK_in_out_dormitory] FOREIGN KEY ([d_id]) REFERENCES [dbo].[dormitory] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table room
-- ----------------------------
ALTER TABLE [dbo].[room] ADD CONSTRAINT [FK_room_dormitory] FOREIGN KEY ([d_id]) REFERENCES [dbo].[dormitory] ([id]) ON DELETE CASCADE ON UPDATE CASCADE
GO


-- ----------------------------
-- Foreign Keys structure for table visit
-- ----------------------------
ALTER TABLE [dbo].[visit] ADD CONSTRAINT [FK_visit_student] FOREIGN KEY ([s_id]) REFERENCES [dbo].[student] ([id]) ON DELETE CASCADE ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[visit] ADD CONSTRAINT [FK_visit_dormitory] FOREIGN KEY ([d_id]) REFERENCES [dbo].[dormitory] ([id]) ON DELETE CASCADE ON UPDATE CASCADE
GO


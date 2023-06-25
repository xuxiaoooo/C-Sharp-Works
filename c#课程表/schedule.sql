/*
 Navicat Premium Data Transfer

 Source Server         : localhost
 Source Server Type    : SQL Server
 Source Server Version : 15002000
 Source Host           : localhost:1433
 Source Catalog        : timetable
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 15002000
 File Encoding         : 65001

 Date: 31/12/2021 16:48:37
*/


-- ----------------------------
-- Table structure for schedule
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[schedule]') AND type IN ('U'))
	DROP TABLE [dbo].[schedule]
GO

CREATE TABLE [dbo].[schedule] (
  [weekday] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [name] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [classtime] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[schedule] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of schedule
-- ----------------------------
INSERT INTO [dbo].[schedule] ([weekday], [name], [classtime]) VALUES (N'1', N'数学', N'1')
GO

INSERT INTO [dbo].[schedule] ([weekday], [name], [classtime]) VALUES (N'1', N'英语', N'2')
GO

INSERT INTO [dbo].[schedule] ([weekday], [name], [classtime]) VALUES (N'1', N'数学', N'3')
GO

INSERT INTO [dbo].[schedule] ([weekday], [name], [classtime]) VALUES (N'3', N'语文', N'7')
GO


-- ----------------------------
-- Table structure for info
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[info]') AND type IN ('U'))
	DROP TABLE [dbo].[info]
GO

CREATE TABLE [dbo].[info] (
  [id] int  NOT NULL,
  [name] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [num] int  NULL,
  [price] money  NULL
)
GO

ALTER TABLE [dbo].[info] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of info
-- ----------------------------
INSERT INTO [dbo].[info] ([id], [name], [num], [price]) VALUES (N'1', N'脏脏包本铺', N'9', N'20.0000')
GO

INSERT INTO [dbo].[info] ([id], [name], [num], [price]) VALUES (N'2', N'鲜果乳酪包', N'10', N'20.0000')
GO

INSERT INTO [dbo].[info] ([id], [name], [num], [price]) VALUES (N'3', N'手作芋泥软软包', N'10', N'20.0000')
GO

INSERT INTO [dbo].[info] ([id], [name], [num], [price]) VALUES (N'4', N'咸软包', N'10', N'20.0000')
GO

INSERT INTO [dbo].[info] ([id], [name], [num], [price]) VALUES (N'5', N'粉桃包', N'10', N'20.0000')
GO

INSERT INTO [dbo].[info] ([id], [name], [num], [price]) VALUES (N'6', N'亚洲枕头吐司', N'10', N'20.0000')
GO

INSERT INTO [dbo].[info] ([id], [name], [num], [price]) VALUES (N'7', N'黑糖舒芙蕾', N'10', N'25.0000')
GO

INSERT INTO [dbo].[info] ([id], [name], [num], [price]) VALUES (N'8', N'麻辣小龙虾包', N'10', N'25.0000')
GO


-- ----------------------------
-- Table structure for sale
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[sale]') AND type IN ('U'))
	DROP TABLE [dbo].[sale]
GO

CREATE TABLE [dbo].[sale] (
  [id] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [name] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [num] int  NULL,
  [time] datetime2(7)  NULL,
  [salerid] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [price] decimal(18)  NULL
)
GO

ALTER TABLE [dbo].[sale] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of sale
-- ----------------------------
INSERT INTO [dbo].[sale] ([id], [name], [num], [time], [salerid], [price]) VALUES (N'120210713152322527', N'脏脏包本铺', N'1', N'2021-07-13 15:23:22.0000000', N'1', N'20')
GO

INSERT INTO [dbo].[sale] ([id], [name], [num], [time], [salerid], [price]) VALUES (N'120210713152343958', N'脏脏包本铺', N'2', N'2021-07-13 15:23:43.0000000', N'1', N'40')
GO

INSERT INTO [dbo].[sale] ([id], [name], [num], [time], [salerid], [price]) VALUES (N'120210713164322464', N'脏脏包本铺', N'1', N'2021-07-13 16:43:22.0000000', N'1', N'20')
GO

INSERT INTO [dbo].[sale] ([id], [name], [num], [time], [salerid], [price]) VALUES (N'220210713164132533', N'鲜果乳酪包', N'2', N'2021-07-13 16:41:32.0000000', N'2', N'40')
GO


-- ----------------------------
-- Table structure for user
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[user]') AND type IN ('U'))
	DROP TABLE [dbo].[user]
GO

CREATE TABLE [dbo].[user] (
  [id] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [password] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[user] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of user
-- ----------------------------
INSERT INTO [dbo].[user] ([id], [password]) VALUES (N'1', N'1')
GO

INSERT INTO [dbo].[user] ([id], [password]) VALUES (N'2', N'2')
GO


-- ----------------------------
-- Primary Key structure for table info
-- ----------------------------
ALTER TABLE [dbo].[info] ADD CONSTRAINT [PK__info__3213E83F2645ED70] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table sale
-- ----------------------------
ALTER TABLE [dbo].[sale] ADD CONSTRAINT [PK__sale__3213E83F843A6C65] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table user
-- ----------------------------
ALTER TABLE [dbo].[user] ADD CONSTRAINT [PK__user__3213E83F73F159A1] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


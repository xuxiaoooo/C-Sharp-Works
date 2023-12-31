USE [master]
GO
/****** Object:  Database [workermanage]    Script Date: 2021/7/2 22:07:05 ******/
CREATE DATABASE [workermanage]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'课程设计', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\课程设计.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'课程设计_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\课程设计_log.ldf' , SIZE = 3136KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [workermanage] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [workermanage].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [workermanage] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [workermanage] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [workermanage] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [workermanage] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [workermanage] SET ARITHABORT OFF 
GO
ALTER DATABASE [workermanage] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [workermanage] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [workermanage] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [workermanage] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [workermanage] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [workermanage] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [workermanage] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [workermanage] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [workermanage] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [workermanage] SET  DISABLE_BROKER 
GO
ALTER DATABASE [workermanage] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [workermanage] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [workermanage] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [workermanage] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [workermanage] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [workermanage] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [workermanage] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [workermanage] SET RECOVERY FULL 
GO
ALTER DATABASE [workermanage] SET  MULTI_USER 
GO
ALTER DATABASE [workermanage] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [workermanage] SET DB_CHAINING OFF 
GO
ALTER DATABASE [workermanage] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [workermanage] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [workermanage] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [workermanage] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [workermanage] SET QUERY_STORE = OFF
GO
USE [workermanage]
GO
/****** Object:  Table [dbo].[部门负责人信息]    Script Date: 2021/7/2 22:07:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[部门负责人信息](
	[负责人编号] [nchar](3) NOT NULL,
	[姓名] [nchar](10) NULL,
	[分管部门] [nchar](3) NULL,
	[账号] [nchar](20) NULL,
	[密码] [nchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[负责人编号] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[普通员工信息]    Script Date: 2021/7/2 22:07:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[普通员工信息](
	[员工编号] [nchar](3) NOT NULL,
	[姓名] [nchar](10) NULL,
	[上级员工编号] [nchar](3) NULL,
	[所在部门编号] [nchar](3) NULL,
	[账号] [nchar](20) NULL,
	[密码] [nchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[员工编号] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[请假信息]    Script Date: 2021/7/2 22:07:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[请假信息](
	[员工编号] [nchar](3) NOT NULL,
	[请假日期] [date] NULL,
	[请假类型编号] [int] NULL,
	[请假开始时间] [date] NULL,
	[请假结束时间] [date] NULL,
	[请假累计天数] [int] NULL,
	[请假原因描述] [text] NULL,
	[确认标志] [bit] NULL,
	[确认人] [nchar](10) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[部门负责人信息] ([负责人编号], [姓名], [分管部门], [账号], [密码]) VALUES (N'101', N'admin1    ', N'201', N'admin1              ', N'123                 ')
INSERT [dbo].[部门负责人信息] ([负责人编号], [姓名], [分管部门], [账号], [密码]) VALUES (N'102', N'admin2    ', N'202', N'admin2              ', N'123                 ')
INSERT [dbo].[部门负责人信息] ([负责人编号], [姓名], [分管部门], [账号], [密码]) VALUES (N'103', N'admin3    ', N'203', N'admin3              ', N'123                 ')
INSERT [dbo].[部门负责人信息] ([负责人编号], [姓名], [分管部门], [账号], [密码]) VALUES (N'104', N'admin4    ', N'204', N'admin4              ', N'123                 ')
INSERT [dbo].[部门负责人信息] ([负责人编号], [姓名], [分管部门], [账号], [密码]) VALUES (N'105', N'admin5    ', N'205', N'admin5              ', N'123                 ')
GO
INSERT [dbo].[普通员工信息] ([员工编号], [姓名], [上级员工编号], [所在部门编号], [账号], [密码]) VALUES (N'1  ', N'员工1       ', N'101', N'201', N'1                   ', N'123                 ')
INSERT [dbo].[普通员工信息] ([员工编号], [姓名], [上级员工编号], [所在部门编号], [账号], [密码]) VALUES (N'10 ', N'员工10      ', N'105', N'205', N'10                  ', N'123                 ')
INSERT [dbo].[普通员工信息] ([员工编号], [姓名], [上级员工编号], [所在部门编号], [账号], [密码]) VALUES (N'2  ', N'员工2       ', N'101', N'201', N'2                   ', N'123                 ')
INSERT [dbo].[普通员工信息] ([员工编号], [姓名], [上级员工编号], [所在部门编号], [账号], [密码]) VALUES (N'3  ', N'员工3       ', N'101', N'201', N'3                   ', N'123                 ')
INSERT [dbo].[普通员工信息] ([员工编号], [姓名], [上级员工编号], [所在部门编号], [账号], [密码]) VALUES (N'4  ', N'员工4       ', N'101', N'201', N'4                   ', N'123                 ')
INSERT [dbo].[普通员工信息] ([员工编号], [姓名], [上级员工编号], [所在部门编号], [账号], [密码]) VALUES (N'5  ', N'员工5       ', N'102', N'202', N'5                   ', N'123                 ')
INSERT [dbo].[普通员工信息] ([员工编号], [姓名], [上级员工编号], [所在部门编号], [账号], [密码]) VALUES (N'6  ', N'员工6       ', N'102', N'202', N'6                   ', N'123                 ')
INSERT [dbo].[普通员工信息] ([员工编号], [姓名], [上级员工编号], [所在部门编号], [账号], [密码]) VALUES (N'7  ', N'员工7       ', N'103', N'203', N'7                   ', N'123                 ')
INSERT [dbo].[普通员工信息] ([员工编号], [姓名], [上级员工编号], [所在部门编号], [账号], [密码]) VALUES (N'8  ', N'员工8       ', N'104', N'204', N'8                   ', N'123                 ')
INSERT [dbo].[普通员工信息] ([员工编号], [姓名], [上级员工编号], [所在部门编号], [账号], [密码]) VALUES (N'9  ', N'员工9       ', N'104', N'204', N'9                   ', N'123                 ')
GO
INSERT [dbo].[请假信息] ([员工编号], [请假日期], [请假类型编号], [请假开始时间], [请假结束时间], [请假累计天数], [请假原因描述], [确认标志], [确认人]) VALUES (N'1  ', CAST(N'2021-06-29' AS Date), 1, CAST(N'2021-06-29' AS Date), CAST(N'2021-06-30' AS Date), 1, N'', 1, N'admin1    ')
INSERT [dbo].[请假信息] ([员工编号], [请假日期], [请假类型编号], [请假开始时间], [请假结束时间], [请假累计天数], [请假原因描述], [确认标志], [确认人]) VALUES (N'1  ', CAST(N'2021-06-29' AS Date), 1, CAST(N'2021-06-30' AS Date), CAST(N'2021-07-01' AS Date), 1, N'', 0, N'驳回        ')
GO
ALTER TABLE [dbo].[请假信息]  WITH CHECK ADD CHECK  (([请假类型编号]=(4) OR [请假类型编号]=(3) OR [请假类型编号]=(2) OR [请假类型编号]=(1)))
GO
/****** Object:  StoredProcedure [dbo].[p_exporttb]    Script Date: 2021/7/2 22:07:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 /*--数据导出EXCEL
 
 导出查询中的数据到Excel,包含字段名,文件为真正的Excel文件
 如果文件不存在,将自动创建文件
 如果表不存在,将自动创建表
 基于通用性考虑,仅支持导出标准数据类型

--邹建 2003.10(引用请保留此信息)--*/

 /*--调用示例

 p_exporttb @sqlstr='select * from 地区资料'
  ,@path='c:',@fname='aa.xls',@sheetname='地区资料'
--*/
 create   proc  [dbo].[p_exporttb]
 @sqlstr   varchar ( 8000 ),    -- 查询语句,如果查询语句中使用了order by ,请加上top 100 percent
 @path   nvarchar ( 1000 ),    -- 文件存放目录
 @fname   nvarchar ( 250 ),    -- 文件名
 @sheetname   varchar ( 250 ) = ''    -- 要创建的工作表名,默认为文件名
 as  
 declare   @err   int , @src   nvarchar ( 255 ), @desc   nvarchar ( 255 ), @out   int
 declare   @obj   int , @constr   nvarchar ( 1000 ), @sql   varchar ( 8000 ), @fdlist   varchar ( 8000 )

 -- 参数检测
 if   isnull ( @fname , '' ) = ''   set   @fname = ' temp.xls '
 if   isnull ( @sheetname , '' ) = ''   set   @sheetname = replace ( @fname , ' . ' , ' # ' )

 -- 检查文件是否已经存在
 if   right ( @path , 1 ) <> ' '   set   @path = @path + ' '
 create   table  #tb(a  bit ,b  bit ,c  bit )
 set   @sql = @path + @fname
 insert   into  #tb  exec  master..xp_fileexist  @sql

 -- 数据库创建语句
 set   @sql = @path + @fname
 if   exists ( select   1   from  #tb  where  a = 1 )
  set   @constr = ' DRIVER={Microsoft Excel Driver (*.xls)};DSN= '''' ;READONLY=FALSE '
        + ' ;CREATE_DB=" ' + @sql + ' ";DBQ= ' + @sql
 else
  set   @constr = ' Provider=Microsoft.Jet.OLEDB.4.0;Extended Properties="Excel 8.0;HDR=YES '
     + ' ;DATABASE= ' + @sql + ' " '

 -- 连接数据库
 exec   @err = sp_oacreate  ' adodb.connection ' , @obj  out
 if   @err <> 0   goto  lberr

 exec   @err = sp_oamethod  @obj , ' open ' , null , @constr
 if   @err <> 0   goto  lberr

 -- 创建表的SQL
 declare   @tbname  sysname
 set   @tbname = ' ##tmp_ ' + convert ( varchar ( 38 ), newid ())
 set   @sql = ' select * into [ ' + @tbname + ' ] from( ' + @sqlstr + ' ) a '
 exec ( @sql )

 select   @sql = '' , @fdlist = ''
 select   @fdlist = @fdlist + ' ,[ ' + a.name + ' ] '
 , @sql = @sql + ' ,[ ' + a.name + ' ]  '
   + case  
    when  b.name  like   ' %char '  
    then   case   when  a.length > 255   then   ' memo '
     else   ' text( ' + cast (a.length  as   varchar ) + ' ) '   end
    when  b.name  like   ' %int '   or  b.name = ' bit '   then   ' int '
    when  b.name  like   ' %datetime '   then   ' datetime '
    when  b.name  like   ' %money '   then   ' money '
    when  b.name  like   ' %text '   then   ' memo '
    else  b.name  end
 FROM  tempdb..syscolumns a  left   join  tempdb..systypes b  on  a.xtype = b.xusertype
 where  b.name  not   in ( ' image ' , ' uniqueidentifier ' , ' sql_variant ' , ' varbinary ' , ' binary ' , ' timestamp ' )
  and  a.id = ( select  id  from  tempdb..sysobjects  where  name = @tbname )

 if   @@rowcount = 0   return

 select   @sql = ' create table [ ' + @sheetname
  + ' ]( ' + substring ( @sql , 2 , 8000 ) + ' ) '
 , @fdlist = substring ( @fdlist , 2 , 8000 )

 exec   @err = sp_oamethod  @obj , ' execute ' , @out  out, @sql
 if   @err <> 0   goto  lberr

 exec   @err = sp_oadestroy  @obj

 -- 导入数据
 set   @sql = ' openrowset( '' MICROSOFT.JET.OLEDB.4.0 '' , '' Excel 8.0;HDR=YES
   ;DATABASE= ' + @path + @fname + ''' ,[ ' + @sheetname + ' $]) '

 exec ( ' insert into  ' + @sql + ' ( ' + @fdlist + ' ) select  ' + @fdlist + '  from [ ' + @tbname + ' ] ' )

 set   @sql = ' drop table [ ' + @tbname + ' ] '
 exec ( @sql )
 return

lberr:
  exec  sp_oageterrorinfo  0 , @src  out, @desc  out
lbexit:
  select   cast ( @err   as   varbinary ( 4 ))  as  错误号
  , @src   as  错误源, @desc   as  错误描述
  select   @sql , @constr , @fdlist
GO
USE [master]
GO
ALTER DATABASE [workermanage] SET  READ_WRITE 
GO

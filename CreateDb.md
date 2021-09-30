USE [Xxx_Dev]
GO
/****** Object:  Table [dbo].[Menus]    Script Date: 2021/8/3 17:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Url] [nvarchar](255) NULL,
	[ParentId] [int] NULL,
	[Level] [int] NOT NULL,
	[Icon] [nvarchar](50) NULL,
	[Status] [int] NOT NULL,
	[UpdateName] [nvarchar](10) NOT NULL,
	[IsDelete] [bit] NOT NULL,
	[CreateTime] [datetime] NOT NULL,
	[CreateName] [nvarchar](10) NOT NULL,
	[UpdateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_Menus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 2021/8/3 17:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[UniqueId] [varchar](32) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Remark] [nvarchar](50) NULL,
	[Status] [int] NOT NULL,
	[IsDelete] [bit] NOT NULL,
	[CreateTime] [datetime] NOT NULL,
	[CreateName] [nvarchar](10) NOT NULL,
	[UpdateTime] [datetime] NOT NULL,
	[UpdateName] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[UniqueId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 2021/8/3 17:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UniqueId] [varchar](32) NOT NULL,
	[Name_Cn] [nvarchar](50) NOT NULL,
	[Name_En] [varchar](50) NULL,
	[Password] [varchar](255) NOT NULL,
	[Status] [int] NOT NULL,
	[PrivateKey] [varchar](max) NOT NULL,
	[IsDelete] [bit] NOT NULL,
	[CreateTime] [datetime] NOT NULL,
	[CreateName] [nvarchar](10) NOT NULL,
	[UpdateTime] [datetime] NOT NULL,
	[UpdateName] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UniqueId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users_Role]    Script Date: 2021/8/3 17:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users_Role](
	[UniqueId] [varchar](32) NOT NULL,
	[Role_UniqueId] [varchar](32) NOT NULL,
	[User_UniqueId] [varchar](32) NOT NULL,
	[UpdateName] [nvarchar](10) NOT NULL,
	[IsDelete] [bit] NOT NULL,
	[CreateTime] [datetime] NOT NULL,
	[CreateName] [nvarchar](10) NOT NULL,
	[UpdateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_Users_Role] PRIMARY KEY CLUSTERED 
(
	[UniqueId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Menus] ON 
GO
INSERT [dbo].[Menus] ([Id], [Name], [Url], [ParentId], [Level], [Icon], [Status], [UpdateName], [IsDelete], [CreateTime], [CreateName], [UpdateTime]) VALUES (1, N'菜单管理', NULL, NULL, 1, N'fa fa-sitemap', 1, N'Dick', 0, CAST(N'2021-04-28T16:04:52.597' AS DateTime), N'Dick', CAST(N'2021-04-28T16:04:52.597' AS DateTime))
GO
INSERT [dbo].[Menus] ([Id], [Name], [Url], [ParentId], [Level], [Icon], [Status], [UpdateName], [IsDelete], [CreateTime], [CreateName], [UpdateTime]) VALUES (2, N'用户管理', NULL, NULL, 1, N'fa fa-user', 1, N'Dick', 0, CAST(N'2021-04-28T16:05:05.253' AS DateTime), N'Dick', CAST(N'2021-04-28T16:05:05.253' AS DateTime))
GO
INSERT [dbo].[Menus] ([Id], [Name], [Url], [ParentId], [Level], [Icon], [Status], [UpdateName], [IsDelete], [CreateTime], [CreateName], [UpdateTime]) VALUES (3, N'角色管理', NULL, NULL, 1, N'fa fa-user', 1, N'Dick', 0, CAST(N'2021-04-28T16:05:11.693' AS DateTime), N'Dick', CAST(N'2021-04-28T16:05:11.693' AS DateTime))
GO
INSERT [dbo].[Menus] ([Id], [Name], [Url], [ParentId], [Level], [Icon], [Status], [UpdateName], [IsDelete], [CreateTime], [CreateName], [UpdateTime]) VALUES (5, N'菜单列表', N'/Common/Menu/List', 1, 2, N'fa fa-sitemap', 1, N'Dick', 0, CAST(N'2021-04-28T16:06:05.353' AS DateTime), N'Dick', CAST(N'2021-04-28T16:06:05.353' AS DateTime))
GO
INSERT [dbo].[Menus] ([Id], [Name], [Url], [ParentId], [Level], [Icon], [Status], [UpdateName], [IsDelete], [CreateTime], [CreateName], [UpdateTime]) VALUES (7, N'新增菜单', N'/Common/Menu/Save', 1, 2, N'fa fa-sitemap', 2, N'Dick', 0, CAST(N'2021-04-28T16:10:16.053' AS DateTime), N'Dick', CAST(N'2021-04-28T16:10:16.053' AS DateTime))
GO
INSERT [dbo].[Menus] ([Id], [Name], [Url], [ParentId], [Level], [Icon], [Status], [UpdateName], [IsDelete], [CreateTime], [CreateName], [UpdateTime]) VALUES (8, N'用户列表', N'/Common/User/List', 2, 2, N'fa fa-user', 1, N'Dick', 0, CAST(N'2021-04-28T16:11:06.077' AS DateTime), N'Dick', CAST(N'2021-04-28T16:11:06.077' AS DateTime))
GO
INSERT [dbo].[Menus] ([Id], [Name], [Url], [ParentId], [Level], [Icon], [Status], [UpdateName], [IsDelete], [CreateTime], [CreateName], [UpdateTime]) VALUES (9, N'新增用户', N'/Common/User/Save', 2, 2, N'fa fa-user', 2, N'Mr. li', 0, CAST(N'2021-04-28T16:11:27.230' AS DateTime), N'Dick', CAST(N'2021-05-06T10:41:59.787' AS DateTime))
GO
INSERT [dbo].[Menus] ([Id], [Name], [Url], [ParentId], [Level], [Icon], [Status], [UpdateName], [IsDelete], [CreateTime], [CreateName], [UpdateTime]) VALUES (10, N'角色列表', N'/Common/Role/List', 3, 2, N'fa fa-user', 1, N'Dick', 0, CAST(N'2021-04-28T16:16:26.867' AS DateTime), N'Dick', CAST(N'2021-04-28T16:16:26.867' AS DateTime))
GO
INSERT [dbo].[Menus] ([Id], [Name], [Url], [ParentId], [Level], [Icon], [Status], [UpdateName], [IsDelete], [CreateTime], [CreateName], [UpdateTime]) VALUES (11, N'新增角色', N'/Common/Role/Save', 3, 2, N'fa fa-user', 2, N'Dick', 0, CAST(N'2021-04-28T16:17:00.897' AS DateTime), N'Dick', CAST(N'2021-04-28T16:17:00.897' AS DateTime))
GO
INSERT [dbo].[Menus] ([Id], [Name], [Url], [ParentId], [Level], [Icon], [Status], [UpdateName], [IsDelete], [CreateTime], [CreateName], [UpdateTime]) VALUES (12, N'角色详情', N'/Common/Users_Role/Detail', 3, 2, N'fa fa-user', 2, N'Dick', 0, CAST(N'2021-04-28T16:17:16.240' AS DateTime), N'Dick', CAST(N'2021-04-28T16:17:16.240' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Menus] OFF
GO
INSERT [dbo].[Roles] ([UniqueId], [Name], [Remark], [Status], [IsDelete], [CreateTime], [CreateName], [UpdateTime], [UpdateName]) VALUES (N'01955a8aeb63495ab1a44cfb15a5615a', N'系统管理员', N'超管', 1, 0, CAST(N'2021-04-30T10:32:59.860' AS DateTime), N'Mr. li', CAST(N'2021-04-30T10:33:12.777' AS DateTime), N'Mr. li')
GO
INSERT [dbo].[Users] ([UniqueId], [Name_Cn], [Name_En], [Password], [Status], [PrivateKey], [IsDelete], [CreateTime], [CreateName], [UpdateTime], [UpdateName]) VALUES (N'7a8a1d14fb3144b994fec86b17e8b539', N'Mr. li', N'Dick', N'rJQBjWWlnqZVfzDG2iuPGR0R11JhLbODhdoZI030/Clb0f7f4B7q9ty4075QfFY/vcPxJIbmwhRzZZkUsBD5iGKkhg15Q230PUJmkv00vhnpbgVRGuq4mMN0uVM0x9ce46H5q3UeQbvpVEL4JqSEdC0/Kr/Qd5tWFO4/jxJB8wY=', 1, N'<RSAKeyValue><Modulus>2R8NM3K+aY4KUqY7JNexkuLtoAV/Mr25FDdcu4eG6m4LrJpC3a6So4hUAxbQzh7qXAnFT9zp9KYwGMNKmVuD/YKGzNDW0n0YNuCHHveEMqGeybp8v8h/HvVqMsb/w4ikwoqJlFdp8BHq+8D91tqP+FlQ6slShSoVeTwWOmGc0fU=</Modulus><Exponent>AQAB</Exponent><P>6yQNt/f9w0MYDbPtbCOMvrcjVRHUywjZDAOjpztHLwTkSMIF6TU6z5EOGj5AKj5nFfq0i+QGKDzoMlgwqZR9Ww==</P><Q>7GHINMnS3x3o9JkV8pnmvECEFkYac59EuKoLZuPBg6REHxiSJQRVOsJpcHP26TR6laiju8o1rraWX8kThCt+7w==</Q><DP>IWvfc02RSQapTZFMZrlq0NSw9e9x4mXgi7+crDFVvc4hMGI7etkxAb2pVnuQnTB/cHVQ4i1H3sJBcp5sVD4hzw==</DP><DQ>q1m6emGu5aPV4bEzErhzZRVTap4IwLW8aCyDtWL2PUoPQ4dZMVIxwjV5n1XAr44mKmSjxBYx0eNzoB2vcwjgqw==</DQ><InverseQ>a2ngm4HqQFbBZFVvWy8c1fZPUqild6nys/03dFjSvu2PIhOXuZLlCQeOWvxB+8XlQPL2sDBPeZjzQgvY6nuK8w==</InverseQ><D>kKFmocbloFrF9ZhV/YzQ9Q/FSrtep+ZJy3W1iBYXgUIc9LUtpY4MkHLXw9cG8McXRogbr79w+U9a6qPspYuYt6SJ1+zHMZ0IPhHykz+J5PtSikA+PcwUNO7KJNSantq750kDV3tJhi6Id8HTTnPMpLa80MMbNNzz3Y4pZ3fUu2E=</D></RSAKeyValue>', 0, CAST(N'2021-04-29T17:52:45.010' AS DateTime), N'Jack', CAST(N'2021-05-06T11:01:32.747' AS DateTime), N'Mr. li')
GO
INSERT [dbo].[Users] ([UniqueId], [Name_Cn], [Name_En], [Password], [Status], [PrivateKey], [IsDelete], [CreateTime], [CreateName], [UpdateTime], [UpdateName]) VALUES (N'd854dcfb90374d22aedb20c1cd348cbf', N'Mr. Dick', N'Dick', N'QQbKkm5qFWNH8AW6+ghYxo/C3Ej3Ive0ap/TdhIpTTIc8v/7SMrAJmCxX4WHXUKGtH/iaHLORn0xolT+y/rcz2zHxCW7TB95cuOmEi94YotzLhxKyA793OEVovoSfVLuArNDD2vVH7d6FJbeeI+tCuV17rnWuSwSh5ONNAZfH8E=', 1, N'<RSAKeyValue><Modulus>yMWAtQwbkadLmOcVfBAMexfvI5+4y752El+/DELq5B3CkMXOCYfyRs++vomNFN38HtEyzfm4Hb4AV72oQzUtQAt7dgTmm6iFv97gbEigPwM8KiYOohjPczdrtD6u8esi+20vVksXDD666LJuBxTk7dcYS47xEd6hsKQZSxVdjL0=</Modulus><Exponent>AQAB</Exponent><P>2TIh0RPh6B3e/xs2CQtYQ37BEsljyvrDgY2T4Rbyg6DL2GuXSp4nRSyC07E+n3vs40Vx6dDfC9ep5w6O/ghh1w==</P><Q>7KQsGfVQkkDed55aaz5iIQ/UE2TCUmwPNhx4m8Zr7u+Jahtj8t949sCXY1fgKtZws0ctZ2K5D9FjriOX5R9biw==</Q><DP>jt+6fRWuKonT0k6tGf/7fNLZ4SjXW4Pfrc5bM9trhoj07xW/fRdST9+649SZlEHqD4r0J1H+F4Uzv8nE6HjNGw==</DP><DQ>OLq2s9ZiZV1Vt7lnlbQT1Dc2MRwDlby//Mngg/+SWmpkN+KvGEdIeWb8I92qKLrVs7TJhrJdCRS6X8G6pTvaNw==</DQ><InverseQ>ptxoKB+wVSpXcenS8T0ZU4UTWcLujolmvKRuEZSnNRONP00XfpUsx/RqW4Qid8mLfjtPceAzo+RoA5W3cW3cvg==</InverseQ><D>GG2feWfdut0mH5aOUKgLPLbuy+DVNUUZTKcFsdI6jkLot4C5zwMRgXgpdzl5Rv6zfHRrwBAQTN4fYI2c+YBw3tDOhZCQFgodiPdvMvQlCsHb0PNJNwyh8FVbFLRKca0L+tfZ4CpJbpDwxZzR7EmWh6Ky2+QvN693XS+lBAxv66k=</D></RSAKeyValue>', 0, CAST(N'2021-05-07T10:49:28.333' AS DateTime), N'Mr. li', CAST(N'2021-05-07T10:49:28.320' AS DateTime), N'Mr. li')
GO
INSERT [dbo].[Users_Role] ([UniqueId], [Role_UniqueId], [User_UniqueId], [UpdateName], [IsDelete], [CreateTime], [CreateName], [UpdateTime]) VALUES (N'01955a8aeb63495ab1a44cfb15a56151', N'01955a8aeb63495ab1a44cfb15a5615a', N'7a8a1d14fb3144b994fec86b17e8b539', N'Dick', 0, CAST(N'2021-04-30T15:17:51.970' AS DateTime), N'Dick', CAST(N'2021-04-30T15:17:51.970' AS DateTime))
GO
ALTER TABLE [dbo].[Menus] ADD  CONSTRAINT [DF_Menus_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Menus] ADD  CONSTRAINT [DF_Menus_UpdateName]  DEFAULT (N'Dick') FOR [UpdateName]
GO
ALTER TABLE [dbo].[Menus] ADD  CONSTRAINT [DF_Menus_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
ALTER TABLE [dbo].[Menus] ADD  CONSTRAINT [DF_Menus_CreateTime]  DEFAULT (getdate()) FOR [CreateTime]
GO
ALTER TABLE [dbo].[Menus] ADD  CONSTRAINT [DF_Menus_CreateName]  DEFAULT (N'Dick') FOR [CreateName]
GO
ALTER TABLE [dbo].[Menus] ADD  CONSTRAINT [DF_Menus_UpdateTime]  DEFAULT (getdate()) FOR [UpdateTime]
GO
ALTER TABLE [dbo].[Roles] ADD  CONSTRAINT [DF_Roles_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Roles] ADD  CONSTRAINT [DF_Roles_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
ALTER TABLE [dbo].[Roles] ADD  CONSTRAINT [DF_Roles_CreateTime]  DEFAULT (getdate()) FOR [CreateTime]
GO
ALTER TABLE [dbo].[Roles] ADD  CONSTRAINT [DF_Roles_CreateName]  DEFAULT (N'Dick') FOR [CreateName]
GO
ALTER TABLE [dbo].[Roles] ADD  CONSTRAINT [DF_Roles_UpdateTime]  DEFAULT (getdate()) FOR [UpdateTime]
GO
ALTER TABLE [dbo].[Roles] ADD  CONSTRAINT [DF_Roles_UpdateName]  DEFAULT (N'Dick') FOR [UpdateName]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_CreateTime]  DEFAULT (getdate()) FOR [CreateTime]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_CreateName]  DEFAULT (N'Dick') FOR [CreateName]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_UpdateTime]  DEFAULT (getdate()) FOR [UpdateTime]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_UpdateName]  DEFAULT (N'Dick') FOR [UpdateName]
GO
ALTER TABLE [dbo].[Users_Role] ADD  CONSTRAINT [DF_Users_Role_UpdateName]  DEFAULT (N'Dick') FOR [UpdateName]
GO
ALTER TABLE [dbo].[Users_Role] ADD  CONSTRAINT [DF_Users_Role_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
ALTER TABLE [dbo].[Users_Role] ADD  CONSTRAINT [DF_Users_Role_CreateTime]  DEFAULT (getdate()) FOR [CreateTime]
GO
ALTER TABLE [dbo].[Users_Role] ADD  CONSTRAINT [DF_Users_Role_CreateName]  DEFAULT (N'Dick') FOR [CreateName]
GO
ALTER TABLE [dbo].[Users_Role] ADD  CONSTRAINT [DF_Users_Role_UpdateTime]  DEFAULT (getdate()) FOR [UpdateTime]
GO
/****** Object:  StoredProcedure [dbo].[TableColumn]    Script Date: 2021/8/3 17:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[TableColumn]
@tablename nvarchar(50)
AS
BEGIN
	SELECT ROW_NUMBER() OVER (ORDER BY C.id) AS [Row]
		 ,C.name as [字段名]
		 ,isnull(ETP.value,'') AS [字段描述],T.name as [字段类型]
		 ,convert(bit,C.IsNullable)  as [可否为空]
		 ,convert(bit,case when exists(SELECT 1 FROM sysobjects where xtype='PK' and parent_obj=c.id and name in (
			 SELECT name FROM sysindexes WHERE indid in(
				 SELECT indid FROM sysindexkeys WHERE id = c.id AND colid=c.colid))) then 1 else 0 end) 
					 as [是否主键]
		 ,convert(bit,COLUMNPROPERTY(c.id,c.name,'IsIdentity')) as [自动增长]
		 ,C.Length as [占用字节] 
		 ,COLUMNPROPERTY(C.id,C.name,'PRECISION') as [长度]
		 ,isnull(COLUMNPROPERTY(c.id,c.name,'Scale'),0) as [小数位数]
		 ,ISNULL(CM.text,'') as [默认值]		 
	FROM syscolumns C
	INNER JOIN systypes T ON C.xusertype = T.xusertype 
	left JOIN sys.extended_properties ETP   ON  ETP.major_id = c.id AND ETP.minor_id = C.colid AND ETP.name ='MS_Description' 
	left join syscomments CM on C.cdefault=CM.id
	WHERE C.id = object_id(@tablename)
END
GO
/****** Object:  StoredProcedure [dbo].[TableToClass]    Script Date: 2021/8/3 17:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		sky
-- Create date: 2020-05-12
-- Description:	产生C#实体类
-- =============================================
CREATE PROCEDURE [dbo].[TableToClass]
@tbName nvarchar(50)
AS
BEGIN
DECLARE @colName	VARCHAR(200)		--字段名
DECLARE @cType		VARCHAR(20)			--c#类型
DECLARE @isnullable bit					--是否为空
declare @description varchar(500)		--字段描述
declare @defaultValue nvarchar(50)		--默认值
DECLARE @length	INT						--字段长度
DECLARE @rowCount	INT					--字段数
DECLARE @rowIndex	INT 				--遍历标志

SELECT ROW_NUMBER() OVER(ORDER BY sc.colid) rid,sc.name AS colName, st.name AS colType,convert(bit,sc.IsNullable) isnullable,
isnull(cast(ETP.value as varchar(500)),'')  [description],COLUMNPROPERTY(sc.id,sc.name,'PRECISION') as [length],
ISNULL(CM.text,'') as defaultValue INTO #t 
FROM syscolumns sc   
INNER JOIN systypes st  ON st.xusertype = sc.xusertype  
left JOIN sys.extended_properties ETP   ON  ETP.major_id = sc.id AND ETP.minor_id = sc.colid AND ETP.name ='MS_Description' 
	left join syscomments CM on sc.cdefault=CM.id
WHERE sc.Id=OBJECT_ID(@tbName)

SELECT @rowIndex=MIN(rid),@rowCount=MAX(rid) FROM #t

PRINT 'public class ' + @tbName
PRINT '{'  

WHILE(@rowIndex<=@rowCount)
BEGIN
	SELECT @colName=colName,
	 @cType =  CASE WHEN colType LIKE '%char%' OR colType LIKE '%text%' THEN 'string'   
						 WHEN colType IN ('decimal', 'numeric') THEN 'decimal'      
						 WHEN colType = 'real' THEN 'float'     
						 WHEN colType LIKE '%money%' THEN 'decimal'      
						 WHEN colType = 'bit' THEN 'bool'      
						 WHEN colType = 'bigint' THEN 'long'      
						 WHEN colType LIKE '%int%' THEN 'int' 
						 WHEN colType like '%date%' THEN 'DateTime' 
						 WHEN colType ='uniqueidentifier' THEN 'Guid'
						 ELSE colType  END +case when isnullable=1 and colType not LIKE '%char%' and colType not LIKE '%text%'  then '?' else '' end,
	@description = [description],@length =[length],@defaultValue=defaultValue
	FROM #t WHERE rid=@rowIndex
	PRINT CHAR(9)+'/// <summary>'
	PRINT CHAR(9)+'/// ' +@description
	PRINT CHAR(9)+'/// </summary>'
	if(@cType ='string')
	begin
		if @length>0
		begin
			PRINT CHAR(9)+'[StringLength('+cast(@length as varchar(50))+')]'
		end
		PRINT CHAR(9)+'public '+@cType+' '+@colName+' { get; set;} = "'+ @defaultValue+'";'
	end
	else
		PRINT CHAR(9)+'public '+@cType+' '+@colName+' { get; set;}'

	SET @rowIndex=@rowIndex+1
END

PRINT '}' 

DROP TABLE #t
end
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'菜单id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menus', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'菜单名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menus', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'菜单url' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menus', @level2type=N'COLUMN',@level2name=N'Url'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'父菜单id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menus', @level2type=N'COLUMN',@level2name=N'ParentId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'菜单级别（一级菜单，二级菜单）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menus', @level2type=N'COLUMN',@level2name=N'Level'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'菜单状态（1启用,2禁用）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menus', @level2type=N'COLUMN',@level2name=N'Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menus', @level2type=N'COLUMN',@level2name=N'UpdateName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否删除' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menus', @level2type=N'COLUMN',@level2name=N'IsDelete'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menus', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menus', @level2type=N'COLUMN',@level2name=N'CreateName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menus', @level2type=N'COLUMN',@level2name=N'UpdateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Roles', @level2type=N'COLUMN',@level2name=N'UniqueId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Roles', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Roles', @level2type=N'COLUMN',@level2name=N'Remark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色状态（2禁用，1启用）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Roles', @level2type=N'COLUMN',@level2name=N'Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否删除' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Roles', @level2type=N'COLUMN',@level2name=N'IsDelete'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Roles', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Roles', @level2type=N'COLUMN',@level2name=N'CreateName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Roles', @level2type=N'COLUMN',@level2name=N'UpdateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Roles', @level2type=N'COLUMN',@level2name=N'UpdateName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'UniqueId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'中文名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Name_Cn'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'英文名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Name_En'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户密码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Password'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户状态（2禁用，1启用）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'解密/私钥' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'PrivateKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否删除' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'IsDelete'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'CreateName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'UpdateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'UpdateName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users_Role', @level2type=N'COLUMN',@level2name=N'Role_UniqueId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users_Role', @level2type=N'COLUMN',@level2name=N'User_UniqueId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users_Role', @level2type=N'COLUMN',@level2name=N'UpdateName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否删除' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users_Role', @level2type=N'COLUMN',@level2name=N'IsDelete'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users_Role', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users_Role', @level2type=N'COLUMN',@level2name=N'CreateName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users_Role', @level2type=N'COLUMN',@level2name=N'UpdateTime'
GO

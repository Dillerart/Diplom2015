CREATE TABLE [dbo].[Access_user](
	[id_access] [int] IDENTITY(1,1) NOT NULL,
	[id_role] [int] NOT NULL,
	[Login] [nchar](20) NOT NULL,
	[Pass] [nchar](20) NOT NULL,
	[NameInfoUser] [nchar](60) NULL,
	[Info_dop] [nchar](200) NULL,
	[Date] [smalldatetime] NULL,
	[Date_iz] [smalldatetime] NULL,
	[_delete] [bit] NULL,
 CONSTRAINT [PK_Access_user] PRIMARY KEY CLUSTERED 
(
	[id_access] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO



CREATE TABLE [dbo].[Bonus](
	[id_bonus] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](60) NULL,
	[bonus] [real] NULL,
 CONSTRAINT [PK_Bonus_1] PRIMARY KEY CLUSTERED 
(
	[id_bonus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO





CREATE TABLE [dbo].[Client](
	[id_client] [int] IDENTITY(1,1) NOT NULL,
	[id_access] [int] NULL,
	[id_bonus] [int] NULL,
	[Number_card] [int] NOT NULL,
	[Name] [nchar](100) NOT NULL,
	[Inform] [nchar](200) NULL,
	[Date_reg] [smalldatetime] NULL,
	[Block] [bit] NULL,
	[Sum_Flow] [money] NULL,
	[Sum_Expenses] [money] NULL,
	[Sum_money]  AS ([Sum_Flow]-[Sum_Expenses]),
	[_delete] [bit] NULL,
	[_inform_delete] [nchar](60) NULL,
	[_level] [bit] NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[id_client] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO



CREATE TABLE [dbo].[Currency](
	[id_currency] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](60) NULL,
	[_delete] [bit] NULL,
 CONSTRAINT [PK_Currency] PRIMARY KEY CLUSTERED 
(
	[id_currency] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO



CREATE TABLE [dbo].[Expenses](
	[id_expenses] [int] IDENTITY(1,1) NOT NULL,
	[id_access] [int] NULL,
	[id_client] [int] NOT NULL,
	[id_service] [int] NOT NULL,
	[Count] [int] NOT NULL,
	[Date] [smalldatetime] NULL,
	[Sum] [money] NULL,
 CONSTRAINT [PK_Expenses] PRIMARY KEY CLUSTERED 
(
	[id_expenses] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO



CREATE TABLE [dbo].[Flow](
	[id_flow] [int] IDENTITY(1,1) NOT NULL,
	[id_access] [int] NOT NULL,
	[id_currency] [int] NOT NULL,
	[id_client] [int] NOT NULL,
	[Date] [smalldatetime] NULL,
	[Sum] [money] NULL,
	[Sum_bonus] [money] NULL,
 CONSTRAINT [PK_Flow] PRIMARY KEY CLUSTERED 
(
	[id_flow] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO



CREATE TABLE [dbo].[Level_bns](
	[id_level] [int] IDENTITY(1,1) NOT NULL,
	[id_bonus] [int] NULL,
	[Name] [nchar](60) NULL,
	[level_min] [money] NULL,
	[level_max] [money] NULL,
 CONSTRAINT [PK_Level_bns] PRIMARY KEY CLUSTERED 
(
	[id_level] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


CREATE TABLE [dbo].[Role](
	[id_role] [int] NOT NULL,
	[Name_R] [nchar](20) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[id_role] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


CREATE TABLE [dbo].[Service](
	[id_service] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](60) NULL,
	[Price] [money] NULL,
	[_delete] [bit] NULL,
 CONSTRAINT [PK_Service] PRIMARY KEY CLUSTERED 
(
	[id_service] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

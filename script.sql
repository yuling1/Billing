USE [Billing]
GO
/****** Object:  Table [dbo].[BillingInfo]    Script Date: 10/13/2016 2:53:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillingInfo](
	[Alias] [nvarchar](100) NOT NULL,
	[MSTitleId] [int] NOT NULL,
	[SOWId] [int] NOT NULL,
	[Id] [int] NOT NULL,
	[BillingMonth] [datetime] NOT NULL,
 CONSTRAINT [PK_BillingInfo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customer]    Script Date: 10/13/2016 2:53:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Name] [nvarchar](100) NOT NULL,
	[Title] [nvarchar](100) NULL,
	[Id] [int] NOT NULL,
	[Alias] [nvarchar](100) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employee_Basic]    Script Date: 10/13/2016 2:53:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee_Basic](
	[BYSID] [int] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Alias] [nvarchar](100) NULL,
	[BYSCode] [nvarchar](100) NULL,
 CONSTRAINT [PK_Employee_Basic] PRIMARY KEY CLUSTERED 
(
	[BYSID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employee_Cost]    Script Date: 10/13/2016 2:53:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee_Cost](
	[BYSID] [int] NOT NULL,
	[Salary] [int] NOT NULL,
	[Id] [int] NOT NULL,
	[Month] [datetime] NOT NULL,
 CONSTRAINT [PK_Employee_Cost] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MSTitle]    Script Date: 10/13/2016 2:53:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MSTitle](
	[MSTitleId] [int] NOT NULL,
	[MSTitle] [nvarchar](50) NOT NULL,
	[Rate] [int] NULL,
	[BillingYear] [int] NULL,
 CONSTRAINT [PK_MSTitle] PRIMARY KEY CLUSTERED 
(
	[MSTitleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SOW]    Script Date: 10/13/2016 2:53:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SOW](
	[SOWId] [int] NOT NULL,
	[SOWName] [nvarchar](100) NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
	[FTEOwnerAlias] [nvarchar](100) NOT NULL,
	[Type] [nvarchar](50) NULL,
 CONSTRAINT [PK_SOW] PRIMARY KEY CLUSTERED 
(
	[SOWId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[BillingInfo]  WITH CHECK ADD  CONSTRAINT [FK_BillingInfo_BillingInfo] FOREIGN KEY([SOWId])
REFERENCES [dbo].[SOW] ([SOWId])
GO
ALTER TABLE [dbo].[BillingInfo] CHECK CONSTRAINT [FK_BillingInfo_BillingInfo]
GO
ALTER TABLE [dbo].[BillingInfo]  WITH CHECK ADD  CONSTRAINT [FK_BillingInfo_MSTitle] FOREIGN KEY([MSTitleId])
REFERENCES [dbo].[MSTitle] ([MSTitleId])
GO
ALTER TABLE [dbo].[BillingInfo] CHECK CONSTRAINT [FK_BillingInfo_MSTitle]
GO

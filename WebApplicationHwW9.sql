USE [eCommerceWebsite]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 8.12.2022 15:10:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Surname] [varchar](50) NOT NULL,
	[Gender] [char](6) NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[PhoneNumber] [nvarchar](50) NOT NULL,
	[Email] [varchar](255) NOT NULL,
	[Birthday] [date] NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustomerID], [Name], [Surname], [Gender], [UserName], [Password], [Address], [PhoneNumber], [Email], [Birthday]) VALUES (17, N'Ece', N'Polat', N'Female', N'Ece.p', N'123', N'istanbul', N'5308644988', N'ece@gmail.com', CAST(N'2000-01-29' AS Date))
INSERT [dbo].[Customer] ([CustomerID], [Name], [Surname], [Gender], [UserName], [Password], [Address], [PhoneNumber], [Email], [Birthday]) VALUES (18, N'Batuhan', N'Polat', N'Male  ', N'Batuu', N'345', N'istanbul', N'5308644988', N'batu@gmail.com', CAST(N'2001-02-27' AS Date))
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO

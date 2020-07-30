
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvoiceSale]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[InvoiceSale](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[seqId] [int] NOT NULL,
	[InvoiceDate] [Datetime] NULL,
	[TotalSum] [Float] NULL,
	[UserSave] [varchar](50) NULL,
	[DateSave] [Datetime] NULL,
 CONSTRAINT [PK_InvoiceSale] PRIMARY KEY CLUSTERED 
(
	[seqId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvoiceSaleChild]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[InvoiceSaleChild](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[InvoiceSaleId] [int] NOT NULL,
	[GoodsId] [int] NOT NULL,
	[Counts] [Float] NOT NULL,
	[Price] [Float] NOT NULL,	
 CONSTRAINT [PK_InvoiceSaleChild] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Goods]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Goods](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[GoodsName] [varchar](max) NULL,
	[GoodsCode] [varchar](max) NULL,
	[GoodsUnit] [int] not NULL,
	[Saleprice] [float] NULL,
	[Buyprice] [float] NULL,
	[GoodsGroup] [int] NULL,
	[GoodsType] [int] NULL,
	[UserSave] [varchar](50) NULL,
	[DateSave] [Datetime] NULL,
 CONSTRAINT [PK_Goods] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GoodsGroup]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[GoodsGroup](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[GroupTitle] [varchar](max) NULL,
	[ParentId] [bigint] NULL,
	[UserSave] [varchar](50) NULL,
	[DateSave] [Datetime] NULL,
 CONSTRAINT [PK_GoodsGroup] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GoodsType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[GoodsType](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[TypeTitle] [varchar](max) NULL,
	[ParentId] [bigint] NULL,
	[UserSave] [varchar](50) NULL,
	[DateSave] [Datetime] NULL,
 CONSTRAINT [PK_GoodsType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END

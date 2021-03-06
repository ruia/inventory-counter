USE [Stocks]
GO
/****** Object:  Table [dbo].[Produtos]    Script Date: 13/04/2022 21:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produtos](
	[Id] [nvarchar](60) NOT NULL,
	[Descricao] [nvarchar](200) NOT NULL,
	[CodBarras] [nvarchar](60) NOT NULL,
	[Categoria] [nchar](1) NOT NULL,
	[UnidadeMedida] [nvarchar](50) NOT NULL,
	[PrecoCusto] [smallmoney] NOT NULL,
	[Eliminado] [bit] NOT NULL,
 CONSTRAINT [PK_Produtos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stocks]    Script Date: 13/04/2022 21:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stocks](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Data] [datetime] NOT NULL,
	[DataUltimaAlteracao] [datetime] NOT NULL,
	[Eliminado] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StocksDetalhes]    Script Date: 13/04/2022 21:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StocksDetalhes](
	[IdStock] [bigint] NOT NULL,
	[IdProduto] [nvarchar](60) NOT NULL,
	[Qtd] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Produtos] ADD  CONSTRAINT [DF_Produtos_Categoria]  DEFAULT (N'M') FOR [Categoria]
GO
ALTER TABLE [dbo].[Produtos] ADD  CONSTRAINT [DF_Produtos_UnidadeMedida]  DEFAULT (N'Unidade') FOR [UnidadeMedida]
GO
ALTER TABLE [dbo].[Produtos] ADD  CONSTRAINT [DF_Produtos_PrecoCusto]  DEFAULT ((0.00)) FOR [PrecoCusto]
GO
ALTER TABLE [dbo].[Produtos] ADD  CONSTRAINT [DF_Produtos_Eliminado]  DEFAULT ((0)) FOR [Eliminado]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Código Produto' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Produtos', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descrição' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Produtos', @level2type=N'COLUMN',@level2name=N'Descricao'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Código Barras' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Produtos', @level2type=N'COLUMN',@level2name=N'CodBarras'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Categoria' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Produtos', @level2type=N'COLUMN',@level2name=N'Categoria'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Unidade Medida' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Produtos', @level2type=N'COLUMN',@level2name=N'UnidadeMedida'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Preço Custo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Produtos', @level2type=N'COLUMN',@level2name=N'PrecoCusto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Eliminado' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Produtos', @level2type=N'COLUMN',@level2name=N'Eliminado'
GO

USE [myfinanceweb]
GO

/****** Object:  Table [dbo].[transacao]    Script Date: 09/12/2023 16:34:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[transacao](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[historico] [varchar](50) NOT NULL,
	[tipo] [char](1) NOT NULL,
	[valor] [decimal](9, 2) NOT NULL,
	[planocontaid] [int] NOT NULL,
	[data] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[transacao]  WITH CHECK ADD FOREIGN KEY([planocontaid])
REFERENCES [dbo].[planoconta] ([id])
GO



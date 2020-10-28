USE [Practica_Patrones]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 28-10-2020 19:38:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](20) NOT NULL,
	[Apellido] [nvarchar](25) NOT NULL,
	[Direccion] [nvarchar](100) NOT NULL,
	[Ciudad] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Telefono] [nvarchar](25) NOT NULL,
	[Ocupacion] [nvarchar](70) NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[VerRegistros]    Script Date: 28-10-2020 19:38:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Joan Toro Ortiz
-- Create date: 26-10-2020
-- Description:	Buscar registros de clientes
-- =============================================
CREATE PROCEDURE [dbo].[VerRegistros] 
	@Condicion nvarchar(30)
AS
BEGIN
	SELECT * FROM CLIENTES WHERE ID LIKE @Condicion+'%' OR Nombre like @Condicion+'%';
END
GO

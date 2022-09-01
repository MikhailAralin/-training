USE [CoffeeStore]
GO
/****** Object:  View [dbo].[ProductOperations]    Script Date: 28.08.2022 14:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER VIEW [dbo].[vw_ClientsActivity]
AS
	SELECT  TOP 100 PERCENT
		[dbo].[Clients].[Name],
		[dbo].[Clients].[Surname],
		TotalAmount

	FROM
	(
		SELECT
			[dbo].[Clients].[Id] AS [ClientId],
			SUM([dbo].[OrderDetails].[Amount]) AS [TotalAmount]

		FROM [dbo].[Clients]
		INNER JOIN [dbo].[Orders]
			ON [dbo].[Orders].[ClientId] = [dbo].[Clients].[Id]
		INNER JOIN [dbo].[OrderDetails]
			ON [dbo].[OrderDetails].[OrderId] = [dbo].[Orders].[Id]

		WHERE [dbo].[Orders].[OrderStatus] = 2

		GROUP BY [dbo].[Clients].[Id]
	)t

	INNER JOIN [dbo].[Clients]
		ON [dbo].[Clients].[Id] = t.ClientId

	ORDER BY TotalAmount DESC
GO
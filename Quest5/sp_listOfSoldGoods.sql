USE [CoffeeStore]
GO
/****** Object:  StoredProcedure [dbo].[sp_createOrder]    Script Date: 28.08.2022 11:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_listOfSoldGoods]
	@dateFrom DATETIME,
	@dateTo DATETIME,
	@productTypeId UNIQUEIDENTIFIER
AS
BEGIN
	SET NOCOUNT ON;

	SELECT
		[dbo].[Products].[Id] AS [ProductId],
		SUM([dbo].[OrderDetails].[Amount]) AS [TotalAmount]

	INTO #tmp
	FROM [dbo].[Orders]
	INNER JOIN [dbo].[OrderDetails]
		ON [dbo].[OrderDetails].[OrderId] = [dbo].[Orders].[Id]
	INNER JOIN [dbo].[Products]
		ON [dbo].[Products].[Id] = [dbo].[OrderDetails].[ProductId]

	WHERE [dbo].[Products].[ProductTypeId] = @productTypeId
		AND [dbo].[Orders].[OrderStatus] = 2
		AND [dbo].[Orders].[ModifiedDate] BETWEEN @dateFrom AND @dateTo
		
	GROUP BY [dbo].[Products].[Id]

	SELECT 
		ProductId, 
		[dbo].[Products].[Name],
		TotalAmount
		
		from #tmp		
		INNER JOIN [dbo].[Products]
			ON [dbo].[Products].[Id] = #tmp.ProductId

		ORDER BY TotalAmount DESC
END


ALTER PROCEDURE [dbo].[sp_most_popular products]
    @dateFrom DATETIME2(7),
    @dateTo DATETIME2(7),
    @productTypeId UNIQUEIDENTIFIER
AS
BEGIN
    SET NOCOUNT ON;



   select ProductId, ProductName, sum(Amount) as Amount
    from (
  select ProductId, p.Name as ProductName, Amount, ModifiedDate, ProductTypeId
  from [dbo].[OrderDetails] od
  left join [dbo].[Orders]  o on od.OrderId=o.Id
  left join [dbo].[Products] p on od.ProductId=p.Id
  left join [dbo].[ProductTypes] pt on p.ProductTypeId=pt.Id
  where ModifiedDate between @dateFrom and @dateTo and ProductTypeId=@productTypeId) t
  group by ProductId, ProductName
  order by Amount desc



END
GO
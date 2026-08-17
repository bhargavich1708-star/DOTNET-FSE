-- Exercise 1: Ranking and Window Functions
SELECT 
    ProductID, 
    ProductName, 
    Category, 
    Price,
    ROW_NUMBER() OVER(PARTITION BY Category ORDER BY Price DESC) as RowNum,
    RANK() OVER(PARTITION BY Category ORDER BY Price DESC) as RankNum,
    DENSE_RANK() OVER(PARTITION BY Category ORDER BY Price DESC) as DenseRankNum
FROM Products;
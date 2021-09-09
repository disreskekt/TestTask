SELECT Products.Name, Categories.Name FROM dbo.Products
LEFT OUTER JOIN dbo.ProductsCategories ON Id = ProductsId
LEFT OUTER JOIN dbo.Categories ON CategoriesId = Categories.Id
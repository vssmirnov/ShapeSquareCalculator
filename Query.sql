select Product.Name + '-' + Category.Name  from ProductCategory PG
left join Product on Product.Id = PG.ProductId
left join Category on Category.Id = PG.CategoryId
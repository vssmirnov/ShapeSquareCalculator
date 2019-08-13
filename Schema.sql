IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Product' and xtype='U')
    CREATE TABLE Product
    (
      ID int not null IDENTITY(1,1),
      Name varchar(100) not null,
      PRIMARY KEY (ID)
    )
GO

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Category' and xtype='U')
    CREATE TABLE Category
    (
      ID int not null IDENTITY(1,1),
      Name varchar(100) not null,
      PRIMARY KEY (ID)
    )
GO

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='ProductCategory' and xtype='U')
    CREATE TABLE ProductCategory
    (
      ID int not null IDENTITY(1,1),
      ProductId int not null,
      CategoryId int not null,
      FOREIGN KEY (ProductId) REFERENCES Product(Id),
      FOREIGN KEY (CategoryId) REFERENCES Category(Id),
      PRIMARY KEY (ID)
    )
GO

insert into Product(Name)
select 'Product1'
union select 'Product2'
union select 'Product3';
GO

insert into Category(Name)
select 'Category1'
union select 'Category2';
GO

insert into ProductCategory(ProductId, CategoryId)
select top 5 Product.Id, Category.Id from Category, Product
GO
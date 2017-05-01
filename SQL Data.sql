CREATE TABLE [dbo].[Stock]
(
	[Stock_No] INT NOT NULL PRIMARY KEY IDENTITY , 
	[Name] NCHAR(50) NOT NULL,
	[Desc] NCHAR(50) NOT NULL,
	[Type] NCHAR(50) NOT NULL,
	[Quantity] INT NOT NULL,
	[Price] MONEY NOT NULL
)

CREATE TABLE [dbo].[Sale]
(
	[Sale_No] INT NOT NULL PRIMARY KEY IDENTITY , 
	[Date] Date NOT NULL,
)

CREATE TABLE [dbo].[StockSale]
(
	[Stock_No] INT NOT NULL CONSTRAINT [Stock_No] FOREIGN KEY REFERENCES [dbo].[Stock],
	[Sale_No] INT NOT NULL CONSTRAINT [Sale_No] FOREIGN KEY REFERENCES [dbo].[Sale],
	[Quantity_Sold] INT NOT NULL,
	[Sale_Price] MONEY NOT NULL, 
	CONSTRAINT [PK_StockSale] PRIMARY KEY ([Stock_No],[Sale_No]),
)

INSERT INTO Stock VALUES ('name', 'desc', 'type', 22, 499);

INSERT INTO Sale VALUES ('04/18/2017');

Stock
---
Stock_No[PK]
Name
Desc
Stock Type
Quantity
Price

StockSale
---
Stock_No [PK]
Sale_No [PK]
Quantity_Sold
Sale_Price


Sale
---
Sale_No[PK]
Sale_Date

One Stock has One StockSales
One StockSale has Many Stocks

One Sale has One StockSales
One StockSale has Many Sales
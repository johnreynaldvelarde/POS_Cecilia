CREATE DATABASE DB_Cecilia;  
USE DB_Cecilia;


CREATE TABLE Categories (Category_ID int IDENTITY(1,1) PRIMARY KEY,
						 Category_Name varchar(99) NOT NULL,
						 Date_Added datetime,
						 Archive tinyint);

CREATE TABLE Product (Product_ID int IDENTITY(1,1) PRIMARY KEY, 
					  Product_Code varchar(20) NOT NULL,
			          Product_Name varchar(99) NOT NULL,
			          Price decimal(18,2) NOT NULL,
					  Size varchar(50),
					  Date_Added datetime,
					  Archive tinyint,
					  Category_ID int NOT NULL,
					  CONSTRAINT FK_Category_ID_Product FOREIGN KEY (Category_ID) REFERENCES Categories(Category_ID));

CREATE TABLE Item(Item_ID int IDENTITY(1,1) PRIMARY KEY,
				  Item_Code varchar(20) NOT NULL,
				  Item_Name varchar(99) NOT NULL,
				  Price decimal(18,2) NOT NULL,
				  Per_Piece int NOT NULL,
				  Date_Added datetime,
				  Archive tinyint NOT NULL);

CREATE TABLE Stock (Stock_ID int IDENTITY(1,1) PRIMARY KEY,
					Product_ID int NOT NULL,
					Item_ID int NOT NULL,
					Stock_Product_Quantity int NOT NULL,
					Stock_Item_Quantity int NOT NULL,
					CONSTRAINT FK_Product_ID_Stock FOREIGN KEY (Product_ID) REFERENCES Product(Product_ID),
					CONSTRAINT FK_Item_ID_Stock FOREIGN KEY (Item_ID) REFERENCES Item(Item_ID));



CREATE TABLE Stock_Item(StockItem_ID int IDENTITY(1,1) PRIMARY KEY,
						Item_ID int NOT NULL,
						Stock_Quantity int,
						CONSTRAINT FK_Item_ID_Stock_Item FOREIGN KEY (Item_ID) REFERENCES Item(Item_ID));

CREATE TABLE Suppliers (Supplier_ID int IDENTITY(1,1) PRIMARY KEY,
						Supplier_Name varchar(99) NOT NULL,
						Address varchar(99) NOT NULL,
						Contact_Number varchar(12) NOT NULL,
						Email varchar(99),
						Date_Added datetime,
						Archive tinyint NOT NULL);

CREATE TABLE Staff_Account (Staff_ID int IDENTITY(1,1) PRIMARY KEY,
							Staff_Image varbinary(MAX) NOT NULL,
							Staff_Name varchar(99) NOT NULL,
							Password varchar(20) NOT NULL,
							Contact_Number varchar(12) NOT NULL,
							Role varchar(20) NOT NULL,
							Date_Added datetime,
							Archive tinyint NOT NULL);	

CREATE TABLE Order_Transaction (Transaction_ID int IDENTITY(1,1) PRIMARY KEY,
							    Staff_ID int NOT NULL,
							    Transaction_Date datetime,
							    Total_Quantity int NOT NULL,
							    Total_Amount decimal(18,2) NOT NULL,
							    CONSTRAINT FK_Staff_ID_Order_Transaction FOREIGN KEY (Staff_ID) REFERENCES Staff_Account(Staff_ID));




CREATE TABLE Order_Product(OrderProduct_ID int IDENTITY(1,1) PRIMARY KEY,
						   Transaction_ID int NOT NULL,
						   Product_ID int NOT NULL,
						   Order_Quantity int NOT NULL,
						   Amount decimal(18,2) NOT NULL,
						   CONSTRAINT FK_Transaction_ID_Order_Product FOREIGN KEY (Transaction_ID) REFERENCES Order_Transaction(Transaction_ID),
						   CONSTRAINT FK_Product_ID_Order_Product FOREIGN KEY (Product_ID) REFERENCES Product(Product_ID));
						   

CREATE TABLE Purchase_Transaction (Purchase_ID int IDENTITY(1,1) PRIMARY KEY,
								   Staff_ID int NOT NULL,
								   Supplier_ID int NOT NULL,
								   Purchase_Date datetime,
								   Total_Amount decimal(18,2) NOT NULL,
								   CONSTRAINT FK_Staff_ID_Purchase_Transaction FOREIGN KEY (Staff_ID) REFERENCES Staff_Account(Staff_ID),
								   CONSTRAINT FK_Supplier_ID_Purchase_Transaction FOREIGN KEY (Supplier_ID) REFERENCES Suppliers(Supplier_ID));

CREATE TABLE Item_Stock(ItemStock_ID int IDENTITY(1,1) PRIMARY KEY,
						Item_ID int NOT NULL,
						ItemStock_Qyt int NOT NULL,
						CONSTRAINT FK_Item_ID_Item_Stock FOREIGN KEY (Item_ID) REFERENCES Item(Item_ID));

CREATE TABLE Purchase_Item (PurchaseItem_ID int IDENTITY(1,1) PRIMARY KEY,
							Purchase_ID int NOT NULL,
							ItemStock_ID int NOT NULL,
							Purchase_Quantity int NOT NULL,
						    Amount decimal(18,2) NOT NULL,
							CONSTRAINT FK_Purchase_ID_Purchase_Item FOREIGN KEY (Purchase_ID) REFERENCES Purchase_Transaction(Purchase_ID),
							CONSTRAINT FK_ItemStock_ID_Purchase_Item FOREIGN KEY (ItemStock_ID) REFERENCES Item_Stock(ItemStock_ID));
							
CREATE TABLE Product_Stock(ProductStock_ID int IDENTITY(1,1) PRIMARY KEY,
						   Product_ID int NOT NULL,
						   ProductStock_Qyt int NOT NULL,
						   CONSTRAINT FK_Product_ID_Product_Stock FOREIGN KEY (Product_ID) REFERENCES Product(Product_ID));





                
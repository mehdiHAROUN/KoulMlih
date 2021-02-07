CREATE TABLE [dbo].[Product] (
    [ProductID]      INT           IDENTITY (1, 1) NOT NULL,
    [ProductBarcode] NVARCHAR (50) NULL,
    [ProductCode]    NCHAR (10)    NULL,
    [ProductLibelle] NCHAR (50)    NULL,
    [ProductNote]    SMALLINT      NULL,
    [ProductScore]   INT           NULL,
    [ProductBrand]   NCHAR (10)    NULL,
    CONSTRAINT [PK_Product_1] PRIMARY KEY CLUSTERED ([ProductID] ASC)
);


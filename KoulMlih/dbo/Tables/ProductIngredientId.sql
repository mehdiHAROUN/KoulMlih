CREATE TABLE [dbo].[ProductIngredientId] (
    [ProductIngredientID]       INT IDENTITY (1, 1) NOT NULL,
    [ProductID]                 INT NULL,
    [IngredientID]              INT NULL,
    [ProductIngredientQuantity] INT NULL,
    CONSTRAINT [PK_ProductIngredientId] PRIMARY KEY CLUSTERED ([ProductIngredientID] ASC),
    CONSTRAINT [FK_ProductIngredientId_Ingredient] FOREIGN KEY ([IngredientID]) REFERENCES [dbo].[Ingredient] ([IngredientID]),
    CONSTRAINT [FK_ProductIngredientId_Product] FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Product] ([ProductID])
);


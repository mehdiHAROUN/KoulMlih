CREATE TABLE [dbo].[Ingredient] (
    [IngredientID]       INT        IDENTITY (1, 1) NOT NULL,
    [IngredientCode]     NCHAR (10) NULL,
    [IngredientLibelle]  NCHAR (20) NULL,
    [IngredientRemarque] NCHAR (20) NULL,
    [IngredientUnit]     SMALLINT   NULL,
    CONSTRAINT [PK_Ingredient] PRIMARY KEY CLUSTERED ([IngredientID] ASC)
);


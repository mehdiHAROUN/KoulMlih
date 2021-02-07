using System;
using System.Collections.Generic;

#nullable disable

namespace KoulMlihBack.Models
{
    public partial class Ingredient
    {
        public Ingredient()
        {
            ProductIngredients = new HashSet<ProductIngredient>();
        }

        public int IngredientId { get; set; }
        public string IngredientCode { get; set; }
        public string IngredientLibelle { get; set; }
        public string IngredientRemarque { get; set; }
        public short? IngredientUnit { get; set; }

        public virtual ICollection<ProductIngredient> ProductIngredients { get; set; }
    }
}

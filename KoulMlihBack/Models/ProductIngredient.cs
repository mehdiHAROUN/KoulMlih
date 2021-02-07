using System;
using System.Collections.Generic;

#nullable disable

namespace KoulMlihBack.Models
{
    public partial class ProductIngredient
    {
        public int ProductIngredientId { get; set; }
        public int? ProductId { get; set; }
        public int? IngredientId { get; set; }
        public int? ProductIngredientQuantity { get; set; }

        public virtual Ingredient Ingredient { get; set; }
        public virtual Product Product { get; set; }
    }
}

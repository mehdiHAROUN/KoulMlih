using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KoulMlihBack.DTO
{
    public class ProductIngredient
    {
        public int ProductIngredientId { get; set; }
        public int? ProductId { get; set; }
        public int? IngredientId { get; set; }
        public int? ProductIngredientQuantity { get; set; }
    }
}

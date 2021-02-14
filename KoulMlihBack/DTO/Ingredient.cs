using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KoulMlihBack.DTO
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        public string IngredientCode { get; set; }
        public string IngredientLibelle { get; set; }
        public string IngredientRemarque { get; set; }
        public short? IngredientUnit { get; set; }
        public int? ProductIngredientQuantity { get; set; }
    }
}

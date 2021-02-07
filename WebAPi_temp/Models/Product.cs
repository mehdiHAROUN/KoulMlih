using System;
using System.Collections.Generic;

#nullable disable

namespace KoulMlihBack.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductIngredients = new HashSet<ProductIngredient>();
        }

        public int ProductId { get; set; }
        public string ProductBarcode { get; set; }
        public string ProductCode { get; set; }
        public string ProductLibelle { get; set; }
        public short? ProductNote { get; set; }
        public int? ProductScore { get; set; }
        public string ProductBrand { get; set; }

        public virtual ICollection<ProductIngredient> ProductIngredients { get; set; }
    }
}

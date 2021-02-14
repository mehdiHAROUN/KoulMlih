using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KoulMlihBack.DTO
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductBarcode { get; set; }
        public string ProductCode { get; set; }
        public string ProductLibelle { get; set; }
        public short? ProductNote { get; set; }
        public int? ProductScore { get; set; }
        public string ProductBrand { get; set; }
        public IList<DTO.Ingredient> Ingredients { get; set; }
    }
}

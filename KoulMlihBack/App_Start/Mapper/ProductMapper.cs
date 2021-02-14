using KoulMlihBack.Models;
using System.Collections.Generic;
using System.Linq;

namespace KoulMlihBack.App_Start.Mapper
{
    public class ProductMapper : AutoMapper.Profile
    {
        public ProductMapper()
        {
            //AutoMapper many to many relationship into collection 
            CreateMap<Ingredient, DTO.Ingredient>()
                .ForMember(dto => dto.ProductIngredientQuantity, opt => opt.MapFrom(x => x.ProductIngredients.SingleOrDefault(y => y.IngredientId == x.IngredientId).ProductIngredientQuantity));

            CreateMap<Product, DTO.Product>()
             .ForMember(dto => dto.Ingredients, opt => opt.MapFrom(x => x.ProductIngredients.Select(y => y.Ingredient).ToList()));
        }
    }
}

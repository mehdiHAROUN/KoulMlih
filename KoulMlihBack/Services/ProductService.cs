using AutoMapper;
using KoulMlihBack.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;

namespace KoulMlihBack.Services
{
    public class ProductService : IProductService
    {
        private readonly ILogger<ProductService> _logger;
        private readonly KoulMlihContext _context;
        private readonly IMapper _mapper;

        public ProductService(ILogger<ProductService> logger, KoulMlihContext context , IMapper mapper)
        {
            _logger = logger;
            _context = context;
            _mapper = mapper;
        }

        public DTO.Product GetProductByCodeBar(string codeBare)
        {
            if (string.IsNullOrEmpty(codeBare))
            {
                return null;
            }

            var productDB =  _context.Products
                .Include(c => c.ProductIngredients)
                .ThenInclude(c => c.Ingredient)
                .FirstOrDefault(d => d.ProductBarcode == codeBare);

            // to do FirstOrDefaultAsync

            return _mapper.Map<DTO.Product>(productDB);
        }
    }
}

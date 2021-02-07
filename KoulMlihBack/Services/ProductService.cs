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

        public ProductService(ILogger<ProductService> logger, KoulMlihContext context )
        {
            _logger = logger;
            _context = context;
        }

        public Task<Product> GetProductByCodeBar(string codeBare)
        {
            if (string.IsNullOrEmpty( codeBare))
            {
                return null;
            }
            return _context.Products.FirstOrDefaultAsync(d => d.ProductBarcode == codeBare);
        }
    }
}

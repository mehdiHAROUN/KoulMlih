using KoulMlihBack.Models;
using System.Threading.Tasks;

namespace KoulMlihBack.Services
{
    public interface IProductService
    {
        Task<Product> GetProductByCodeBar(string codeBare);
    }
}
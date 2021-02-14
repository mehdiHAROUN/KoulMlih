using KoulMlihBack.Models;
using System.Threading.Tasks;

namespace KoulMlihBack.Services
{
    public interface IProductService
    {
        DTO.Product GetProductByCodeBar(string codeBare);
    }
}
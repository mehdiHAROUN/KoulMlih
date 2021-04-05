using KoulMlihBack.Models.Result.CommonResult;
using KoulMlihBack.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace YukaBack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;

        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpGet("{codeBare}")]
        public async Task<JsonResult> Get(string codeBare)
        {
            try
            {
                var product =  _productService.GetProductByCodeBar(codeBare);
                return ModelResult.SuccessModel(product);
            }
            catch (Exception ex)
            {
                var error = $"Error while retrieving product {codeBare}";
                _logger.LogError(ex, error);
                return ModelResult.ErrorModel(error);
            }
        }
    }
}

using KoulMlihBack.Models;
using KoulMlihBack.Models.Result.CommonResult;
using KoulMlihBack.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
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
                Product product = await _productService.GetProductByCodeBar(codeBare);
                return ModelResult.SuccessModel(product);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error while retrieving product {codeBare}");
                return ModelResult.ErrorModel("Erreur lors de la récupération des collaborateurs.");
            }
        }
    }
}

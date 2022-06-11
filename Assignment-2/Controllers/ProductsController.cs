using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayerService;
using NLayerService.DTOs;

namespace Assignment_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductsController(ProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> GetAll()
        {
           var response = await _productService.GetAll();
           return new ObjectResult(response);
        }

    }
}

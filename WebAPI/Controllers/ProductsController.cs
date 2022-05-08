using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            return Ok(_productService.GetById(id));
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            return Ok(_productService.GetAll());
        }

        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            _productService.Add(product);
            return Ok("Başarılı");
        }

    }
}

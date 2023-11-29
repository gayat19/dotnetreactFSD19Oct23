using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Exceptions;
using ShoppingApp.Interfaces;
using ShoppingApp.Models;
using System.Net.Mime;

namespace ShoppingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("reactApp")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly ILogger<ProductController> _logger;

        public ProductController(IProductService productService, ILogger<ProductController> logger)
        {
            _productService = productService;
            _logger = logger;
        }
        [HttpGet]
        [Authorize]
        public ActionResult Get()
        {
            string errorMessage = string.Empty;
            try
            {
                var result = _productService.GetProducts();
                _logger.LogInformation("Product listed");
                return Ok(result);
            }
            catch (NoProductsAvailableException e)
            {
                errorMessage = e.Message;
                _logger.LogError("No products available in the collection or in the table");
            }
            return BadRequest(errorMessage);
        }
        
        [Authorize(Roles ="Admin")]
        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(Product), StatusCodes.Status200OK)]
        [ProducesResponseType( StatusCodes.Status400BadRequest)]
        public ActionResult Create(Product product)
        {
            string errorMessage = string.Empty;
            try
            {
                var result = _productService.Add(product);
                return Ok(result);
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
            }
            return BadRequest(errorMessage);
        }
    }
}

using E_Commerce.BLL.Manager;
using E_Commerce.BLL.Manager.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_CommerceAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductManager _productManager;

        public ProductController(IProductManager productManager)
        {
            _productManager = productManager;
        }

        [HttpPost]
        public IActionResult ListProducts(string? Filter) {

            try {

                return new OkObjectResult(_productManager.GetAllProducts());
            }
            catch (Exception ex) {
                return BadRequest(ex);
            }
            
        
        }
    }
}

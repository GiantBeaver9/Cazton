using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreModels.DTO;
using WebAPIStore.Extensions;
using WebAPIStore.Repos.Contracts;

namespace WebAPIStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepo productRepo;

        public ProductController(IProductRepo productRepo)
        {
            this.productRepo = productRepo;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetItems()
        {
            try
            {
                var products = await this.productRepo.GetProducts();

                if (products == null)
                {
                    return NotFound();
                }
                else
                {
                    var productDto = products.ConvertToDTO();

                    return Ok(productDto);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error receiving data " + ex);
            }

        }
    }
}

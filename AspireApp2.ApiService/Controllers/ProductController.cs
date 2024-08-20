using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlazorApp.Model;
using BlazorApp.Model.Model;
using BlazorApp.BL.Services;

namespace AspireApp2.ApiService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(IProductService productService) : ControllerBase
    {
        [HttpGet]
    public async Task<ActionResult<BaseResponseModel>> GetProduct()
        {
            var products = await productService.GetProducts();
            return Ok(new BaseResponseModel { Success=true,Data=products});

        }

    }
}

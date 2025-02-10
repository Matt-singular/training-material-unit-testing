namespace Api.Controllers;

using Domain.Services.Products;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class ProductsController
{
  [HttpGet("GetAllProducts")]
  public async Task<List<object>> GetAllProducts([FromServices] IProductService productService)
  {
    var getAllProductsTask = productService.GetProductsAsync();
    return await getAllProductsTask.ConfigureAwait(false);
  }
}
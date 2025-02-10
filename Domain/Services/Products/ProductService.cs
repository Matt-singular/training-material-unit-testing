namespace Domain.Services.Products;

using System.Collections.Generic;
using System.Net.Http.Json;

/// <inheritdoc cref="IProductService"/>
public class ProductService(IHttpClientFactory httpClientFactory) : IProductService
{
  private readonly HttpClient HttpClient = httpClientFactory.CreateClient("Products");
  private readonly string ProductsEndpoint = "products";

  public async Task<List<object>> GetProductsAsync()
  {
    // Call the products endpoint
    var getProductsTask = this.HttpClient.GetAsync(this.ProductsEndpoint);
    var getProductsResponse = await getProductsTask.ConfigureAwait(false);
    ValidateHttpResponseStatus(getProductsResponse);

    // Map the response to a list of objects
    var products = await getProductsResponse.Content.ReadFromJsonAsync<List<object>>();
    return products ?? [];
  }

  private static void ValidateHttpResponseStatus(HttpResponseMessage? httpResponse)
  {
    if (httpResponse != null && httpResponse.IsSuccessStatusCode)
    {
      return;
    }

    throw new InvalidOperationException("Failed to retrieve products from the API.");
  }
}
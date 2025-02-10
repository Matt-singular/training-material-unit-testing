namespace Domain.Services.Products;

/// <summary>
/// Represents product-related services.
/// </summary>
public interface IProductService
{
  /// <summary>
  /// Gets all products.
  /// </summary>
  /// <returns>A list of objects.</returns>
  public Task<List<object>> GetProductsAsync();
}
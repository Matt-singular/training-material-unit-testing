namespace IntegrationTests.Services;

using Domain.Services.Products;
using FluentAssertions;

/// <summary>
/// Integration tests for the <see cref="ProductService"/> class using <see cref="NSubstitute"/> for mocking.
/// </summary>
public class ProductServiceIntegrationTests
{
  private readonly string ProductsUrl = IntegrationTestHelpers
    .BuildApiAppsettingsConfig()
    .GetConfigEntryByKey("Secrets:ApiBaseUrl");

  [Fact]
  public async Task GetProductsAsync_FetchAllProducts_ReturnsActualProducts()
  {
    // Arrange
    var httpClientFactory = Substitute.For<IHttpClientFactory>();
    httpClientFactory.CreateClient(Arg.Any<string>()).Returns(new HttpClient
    {
      BaseAddress = new Uri(this.ProductsUrl)
    });

    var productService = Substitute.ForPartsOf<ProductService>(httpClientFactory);

    // Act
    var result = await productService.GetProductsAsync();

    // Assert
    result.Should().NotBeNullOrEmpty();
  }
}
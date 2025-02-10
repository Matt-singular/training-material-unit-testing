namespace Application;

using Domain.Services.Products;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

/// <summary>
/// Contains extension methods for the <see cref="Program"/> startup class.
/// </summary>
public static class StartupExtensions
{
  /// <summary>
  /// Adds the domain services to the service collection.
  /// </summary>
  /// <param name="services">The service collection.</param>
  /// <returns>The service collection with the registered domain services.</returns>
  public static IServiceCollection AddDomainServices(this IServiceCollection services)
  {
    services.AddScoped<IProductService, ProductService>();

    return services;
  }

  public static IConfigurationBuilder AddDomainConfig(this IConfigurationBuilder configuration)
  {
    configuration
      .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
      .AddUserSecrets<Program>(optional: true, reloadOnChange: true);

    return configuration;
  }

  //var configurationBuilder = new ConfigurationBuilder()
  //    .SetBasePath(Directory.GetCurrentDirectory())
  //    .AddJsonFile("secrets.json", optional: true, reloadOnChange: true)
  //    .AddEnvironmentVariables();
}
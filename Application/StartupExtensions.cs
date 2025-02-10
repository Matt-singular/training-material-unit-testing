namespace Application;

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
    return services;
  }
}
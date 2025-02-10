namespace IntegrationTests.Helpers;

using Microsoft.Extensions.Configuration;

/// <summary>
/// Some basic helper methods for integration tests.
/// </summary>
public static class IntegrationTestHelpers
{
  /// <summary>
  /// Builds the configuration for the API appsettings.json file.
  /// </summary>
  /// <returns>The built configuration</returns>
  public static IConfigurationRoot BuildApiAppsettingsConfig()
  {
    var assemblyLocation = Path.GetDirectoryName(typeof(Api.Controllers.ProductsController).Assembly.Location)!;
    var appSettingsPath = Path.Combine(assemblyLocation, "appsettings.json");

    var configurationBuilder = new ConfigurationBuilder()
      .AddJsonFile(appSettingsPath, optional: true, reloadOnChange: true)
      .AddUserSecrets<Api.Controllers.ProductsController>(optional: true, reloadOnChange: true);

    return configurationBuilder.Build();
  }

  /// <summary>
  /// Gets a configuration entry by key (with no null checking or validation)
  /// </summary>
  /// <param name="configuration">The configuration builder.</param>
  /// <param name="sectionName">The section key of the config to get.</param>
  /// <returns>The config entry value.</returns>
  public static string GetConfigEntryByKey(this IConfigurationRoot configuration, string sectionName)
  {
    return configuration[sectionName]!;
  }
}
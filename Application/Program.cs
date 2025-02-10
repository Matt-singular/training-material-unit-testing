namespace Application;

using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.DependencyInjection;

[ExcludeFromCodeCoverage]
public class Program
{
  private static void Main(string[] args)
  {
    // Dependency Injection
    var serviceProvider = new ServiceCollection()
      .AddDomainServices()
      .BuildServiceProvider();

    // Execute Example
    //var calculator = serviceProvider.GetRequiredService<ICalculator>();
    //var result = calculator.Add(1, 2);

    // Write the results and keep the terminal open
    Console.WriteLine(string.Empty);
    Console.ReadLine();
  }
}
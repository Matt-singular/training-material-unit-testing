using Application;
using Microsoft.Extensions.DependencyInjection;

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
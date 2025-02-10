namespace Domain.Tests.Services.Calculator;

using Domain.Services.Calculator;

/// <summary>
/// Unit tests for the <see cref="MultiplyOperation"/> class using mocked services.
/// </summary>
public partial class MultiplyOperationTests
{
  [Fact]
  public void Execute_AddsNumbers_UsingMockedService()
  {
    // Arrange
    decimal a = 1m;
    decimal b = 0m;
    decimal expected = 0m;

    var mockedMultiplyOperationService = Substitute.For<ICalculatorOperation>();

    mockedMultiplyOperationService
      .Execute(Arg.Is(a), Arg.Is(b))
      .Returns(expected);

    // Act
    decimal result = mockedMultiplyOperationService.Execute(a, b);

    // Assert
    Assert.Equal(expected, result);
  }
}
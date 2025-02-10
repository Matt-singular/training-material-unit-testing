namespace Domain.Tests.Services.AddOperation;

using Domain.Services;

public partial class AddOperationTests
{
  [Fact]
  public void Execute_AddsNumbers_UsingMockedService()
  {
    // Arrange
    var mockedAddOperationService = Substitute.For<ICalculatorOperation>();

    mockedAddOperationService
      .Execute(Arg.Any<decimal?>(), Arg.Any<decimal?>())
      .Returns(decimal.One);

    // Act
    decimal result = mockedAddOperationService.Execute(1, 0);

    // Assert
    Assert.Equal(1, result);
  }
}
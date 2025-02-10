namespace Domain.Tests.Operations;

using Domain.Operations;

/// <summary>
/// Some very simple units using the <see cref="FactAttribute"/> and the <see cref="TheoryAttribute"/>.
/// </summary>
public partial class AddOperationTests
{
  private readonly AddOperation AddOperationService;

  public AddOperationTests()
  {
    this.AddOperationService = Substitute.ForPartsOf<AddOperation>();
  }

  [Fact]
  public void Execute_AddsTwoPositiveNumbers_ReturnsCorrectSum()
  {
    // Arrange
    decimal a = 5;
    decimal b = 3;

    // Act
    decimal result = this.AddOperationService.Execute(a, b);

    // Assert
    Assert.Equal(8, result);
  }

  [Fact]
  public void Execute_AddsPositiveAndNegativeNumber_ReturnsCorrectSum()
  {
    // Arrange
    decimal a = 5;
    decimal b = -3;

    // Act
    decimal result = this.AddOperationService.Execute(a, b);

    // Assert
    Assert.Equal(2, result);
  }

  [Fact]
  public void Execute_AddsTwoNegativeNumbers_ReturnsCorrectSum()
  {
    // Arrange
    decimal a = -5;
    decimal b = -3;

    // Act
    decimal result = this.AddOperationService.Execute(a, b);

    // Assert
    Assert.Equal(-8, result);
  }

  [Fact]
  public void Execute_AddsNumberAndZero_ReturnsSameNumber()
  {
    // Arrange
    decimal a = 5;
    decimal b = 0;

    // Act
    decimal result = this.AddOperationService.Execute(a, b);

    // Assert
    Assert.Equal(5, result);
  }

  [Fact]
  public void Execute_AddsValidAndInvalidData_ThrowsError()
  {
    // Arrange
    decimal a = 5;
    decimal? b = null;

    // Act
    Action addOperationAction1 = () => this.AddOperationService.Execute(a, b);
    Action addOperationAction2 = () => this.AddOperationService.Execute(b, a);

    // Assert
    Assert.Throws<ArgumentNullException>(addOperationAction1);
    Assert.Throws<ArgumentNullException>(addOperationAction2);
  }
}
namespace Domain.Tests.Services.Calculator;

using Domain.Services.Calculator;

/// <summary>
/// Unit tests for the <see cref="MinusOperation"/> class.
/// </summary>
public class MinusOperationTests
{
  private readonly MinusOperation MinusOperationService;

  public MinusOperationTests()
  {
    this.MinusOperationService = Substitute.ForPartsOf<MinusOperation>();
  }

  private static readonly decimal? NonConstantValue = 5m;

  [Theory]
  //[InlineData(NonConstantValue, 3, 8)] // We can only use constant values here
  [InlineData(5, 3, 2)]
  [InlineData(5, -3, 8)]
  [InlineData(-5, -3, -2)]
  [InlineData(5, 0, 5)]
  public void Execute_SubtractTwoNumbers_ReturnsExpected(decimal value1, decimal value2, decimal expected)
  {
    // Act
    decimal result = this.MinusOperationService.Execute(value1, value2);

    // Assert
    Assert.Equal(expected, result);
  }

  [Theory]
  [MemberData(nameof(InvalidData))]
  public void Execute_InvalidData_ThrowsError(decimal? value1, decimal? value2)
  {
    // Act
    Action addOperationAction = () => this.MinusOperationService.Execute(value1, value2);

    // Assert
    Assert.Throws<ArgumentNullException>(addOperationAction);
  }

  /// <summary>
  /// Some test data for use in the <see cref="Execute_InvalidData_ThrowsError"/> test.
  /// </summary>
  public static IEnumerable<object[]> InvalidData =>
   [
    // We can use dynamic values here
    [NonConstantValue!, null!],
    [null!, -3m]
   ];
}
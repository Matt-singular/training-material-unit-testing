namespace Domain.Services.Calculator;

/// <summary>
/// Represents a calculator operation such as <see cref="AddOperation"/>, <see cref="MinusOperation"/>, and <see cref="MultiplyOperation"/>.
/// </summary>
public interface ICalculatorOperation
{
  public decimal Execute(decimal? a, decimal? b);
}
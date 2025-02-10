namespace Domain.Services.Calculator;
/// <summary>
/// A simple minus operation to subtract two values
/// </summary>
public class MinusOperation : ICalculatorOperation
{
  public decimal Execute(decimal? a, decimal? b)
  {
    // Validate the input (we allow nulls for the sake of the example)
    ArgumentNullException.ThrowIfNull(a, nameof(a));
    ArgumentNullException.ThrowIfNull(b, nameof(b));

    return a.Value - b.Value;
  }
}
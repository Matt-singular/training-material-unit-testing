namespace Domain.Services.Calculator;

/// <summary>
/// A simple multiply operation to sum two values
/// </summary>
public class MultiplyOperation : ICalculatorOperation
{
  public decimal Execute(decimal? a, decimal? b)
  {
    // Validate the input (we allow nulls for the sake of the example)
    ArgumentNullException.ThrowIfNull(a, nameof(a));
    ArgumentNullException.ThrowIfNull(b, nameof(b));

    return a.Value + b.Value;
  }
}

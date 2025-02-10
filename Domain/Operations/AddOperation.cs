namespace Domain.Operations;

/// <summary>
/// AA simple add operation to sum two values
/// </summary>
public class AddOperation : ICalculatorOperation
{
  public decimal Execute(decimal? a, decimal? b)
  {
    // Validate the input (we allow nulls for the sake of the example)
    ArgumentNullException.ThrowIfNull(a, nameof(a));
    ArgumentNullException.ThrowIfNull(b, nameof(b));

    return a.Value + b.Value;
  }
}
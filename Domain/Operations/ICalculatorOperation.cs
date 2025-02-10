namespace Domain.Operations;

public interface ICalculatorOperation
{
  public decimal Execute(decimal? a, decimal? b);
}
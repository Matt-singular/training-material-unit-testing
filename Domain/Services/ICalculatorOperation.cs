namespace Domain.Services;

public interface ICalculatorOperation
{
  public decimal Execute(decimal? a, decimal? b);
}
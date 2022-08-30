using Moq;
using FluentAssertions;

namespace stock_options.Test;
public class TestStock
{
  [Theory]
  [InlineData("GOOG", "GOOG")]
  public void HasStock(string symbol, string findStock)
  {
    throw new NotImplementedException();
  }

  [Theory]
  [InlineData("Common", "Common", 1030.00, 1000.00, 1500.00)]
  public void HasStockRecomend(string mockType, string findType, double price, double minValue, double maxValue)
  {
    throw new NotImplementedException();
  }
}

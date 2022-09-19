using Moq;
using FluentAssertions;

namespace stock_options.Test;
public class TestStock
{
  [Theory]
  [InlineData("GOOG", "GOOG")]
  public void HasStock(string symbol, string findStock)
  {
    var mockStok = new Mock<IStockService>();
    var stok = new Stock("name", symbol, "0", "change", "type");
    mockStok.Setup(c => c.stocks()).Returns(new List<IStock> { stok });

    var stokeOptions = new StockOptions(mockStok.Object);
    var result = stokeOptions.getStock(symbol);

    result.Should().NotBeNull();
    result.Should().BeEquivalentTo(stok);
    result.symbol.Should().Be(findStock);
  }

  [Theory]
  [InlineData("Common", "Common", 1030.00, 1000.00, 1500.00)]
  public void HasStockRecomend(string mockType, string findType, double price, double minValue, double maxValue)
  {
    throw new NotImplementedException();
  }
}

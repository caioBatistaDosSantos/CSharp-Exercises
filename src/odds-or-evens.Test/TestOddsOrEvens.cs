using FluentAssertions;
using Xunit;

namespace OddsOrEvens.Test;

public class TestOddsOrEvens
{
    [Theory(DisplayName = "Teste de sucesso para verificar se a soma entre dois números é par ou ímpar")]
    [InlineData(2, 7, "Ímpar")]
    [InlineData(3, 7, "Par")]
    public void TestOddsOrEvensSuccess(int numberOne, int numberTwo, string resultExpected)
    {
        var expect = new OddsOrEvens();

        var resultNumber = expect.SumNumbers(numberOne, numberTwo);

        expect.VerifyOddsOrEvens(resultNumber).Should().Be(resultExpected);
    }

    [Theory(DisplayName = "Teste de exceção para verificar se a soma entre dois números é par ou ímpar")]
    [InlineData(10, 11)]
    [InlineData(-10, 1)]
    [InlineData(100, 1)]
    [InlineData(10, -1)]
    public void TestOddsOrEvensException(int numberOne, int numberTwo)
    {
        var expect = new OddsOrEvens();

        Action act = () =>  expect.SumNumbers(numberOne, numberTwo);

        act.Should().Throw<ArgumentOutOfRangeException>();
    }
}

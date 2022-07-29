using FluentAssertions;
using Xunit;

namespace OddsOrEvens.Test;

public class TestOddsOrEvens
{
    [Theory(DisplayName = "Teste de sucesso para verificar se a soma entre dois números é par ou ímpar")]
    [InlineData(2, 7, "Ímpar")]
    public void TestOddsOrEvensSuccess(int numberOne, int numberTwo, string resultExpected)
    {
        throw new NotImplementedException();
    }

    [Theory(DisplayName = "Teste de exceção para verificar se a soma entre dois números é par ou ímpar")]
    [InlineData(10, 11)]
    public void TestOddsOrEvensException(int numberOne, int numberTwo)
    {
        throw new NotImplementedException();
    }
}

using FluentAssertions;
using Xunit;

namespace SelectionProcessValidation.Test;

public class TestSelectionProcessValidation
{
    [Theory(DisplayName = "Teste de sucesso para validação de processo de seleção")]
    [InlineData("Maria;João;Fernanda;Felipe;Maurício;Mayara", "Maria", true)]
    public void TestSelectionProcessValidationSuccess(string selectedPeople, string name, bool resultExpected)
    {
        throw new NotImplementedException();
    }

    [Theory(DisplayName = "Teste de exceção para validação de processo de seleção onde nome não pode ser vazio")]
    [InlineData("Maria;João;Fernanda;Felipe;Maurício;Mayara", null)]
    public void TestSelectionProcessValidationException(string selectedPeople, string name)
    {
        throw new NotImplementedException();
    }
}

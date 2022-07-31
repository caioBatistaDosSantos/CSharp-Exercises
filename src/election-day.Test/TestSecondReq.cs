using Xunit;
using System.IO;
using System;
using election_day;
using FluentAssertions;

namespace election_day.Test;

[Collection("Sequential")]
public class TestSecondReq
{
    [Theory(DisplayName = "Deve ler os votos")]
    [InlineData(2, 2)]
    [InlineData(3, 3)]
    public void TestStart(int countVoters, int printExpected)
    {
        using var input = new StringReader(countVoters.ToString());
        Console.SetIn(input);

        using var output = new StringWriter();
        Console.SetOut(output);

        var instanceClass = new BallotBox();
        instanceClass.Start(1);

        string result = output.ToString().Trim();
        
        var message = $"\r\nInforme o número do candidato de 1 a 3, ou tecle qualquer outro digito para votar nulo: \r\nO número deve ser um inteiro maior que zero\r\n\r\nVoto registrado: {printExpected}\r\n";

        result.Should().Be(message);
    }
}
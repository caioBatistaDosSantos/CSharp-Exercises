using Xunit;
using System.IO;
using System;
using election_day;
using FluentAssertions;

namespace election_day.Test;

[Collection("Sequential")]
public class TestThirdReq
{
    [Theory(DisplayName = "Deve imprimir o resultado")]
    [InlineData(new string[]{"6","1","1","5","A","3","2"}, 2, 1, 1, 2)]
    [InlineData(new string[]{"1","5","A","3","2"}, 1, 1, 1, 1)]
    public void TestPrintResult(
        string[] entrys,
        int expectedReceivedOption1,
        int expectedReceivedOption2,
        int expectedReceivedOption3,
        int expectedOptionNull)
    {
        using var output = new StringWriter();
        Console.SetOut(output);

        var instanceClass = new BallotBox();
        foreach (var entry in entrys)
        {
            if (!int.TryParse(entry, out var valid)) continue;

            using var input = new StringReader(entry);
            Console.SetIn(input);

            instanceClass.Start(1);
        }
        
        instanceClass.PrintResult();

        string result = output.ToString().Trim();

        string[] message =
        {
            $"Votação finalizada!!!!",
            $"A opção 1 recebeu: {expectedReceivedOption1} voto(s)",
            $"A opção 2 recebeu: {expectedReceivedOption2} voto(s)",
            $"A opção 3 recebeu: {expectedReceivedOption3} voto(s)",
            $"Total de votos anulados: {expectedOptionNull} voto(s)",
        };

        for (var j = 0; j < message.Length; j++)
            result.Should().Contain(message[j]);
    }
}
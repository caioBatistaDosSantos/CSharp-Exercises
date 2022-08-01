using Xunit;
using System.IO;
using System;
using TikTakToe;
using FluentAssertions;

namespace TikTakToe.Test;

[Collection("Sequential")]
public class TestTikTakToeGame
{
    [Theory(DisplayName = "Deve preencher o tabuleiro com o caractere correto na posição adequada")]
    [InlineData(
        1,
        1,
        'x',
        new char[] {
            ' ', ' ', ' ',
            ' ', 'x', ' ',
            ' ', ' ', ' '
        }
    )]
    public void TestMakeMove(int lineEntry, int columnEntry, char playerEntry, char[] expected)
    {
        var play = new TikTakToeGame();
        play.makeMove(lineEntry, columnEntry, playerEntry);

        play.board.Should().BeEquivalentTo(fromArrayToMultiDimArray(expected, 3, 3));
    }
    
    [Theory(DisplayName = "Deve imprimir o tabuleiro")]
    [InlineData(
        new char[] {
            'x', 'x', 'x',
            'x', 'x', 'x',
            'x', 'x', 'x'
        },
        new string[] {
            "x x x",
            "x x x",
            "x x x"
        }
    )]
    public void TestPrintBoard(char[] entry, string[] expected)
    {
        var play = new TikTakToeGame();

        play.board = fromArrayToMultiDimArray(entry, 3, 3);

        using (var NewOutput = new StringWriter())
        {
            Console.SetOut(NewOutput);

            play.printBoard();

            var result = NewOutput.ToString().Trim();

            var message = string.Concat(expected[0] + "\n" + expected[1] + "\n" + expected[2]);

            result.Should().Be(message);
        }
    }

    [Theory(DisplayName = "Deve retornar corretamente se o jogo acabou ou não")]
    [InlineData(
        new char[] {
            'x', 'x', 'x',
            'x', 'x', 'x',
            'x', 'x', 'x'
        },
        'x',
        true
    )]
    public void TestIsGameOver(char[] entry, char expectedWinner, bool expectedReturn)
    {
        var play = new TikTakToeGame();

        play.board = fromArrayToMultiDimArray(entry, 3, 3);

        var playWinner = play.isGameOver();

        play.winner.Should().Be(expectedWinner);
        playWinner.Should().Be(expectedReturn);
    }

    [Theory(DisplayName = "Deve imprimir o vencedor correto do jogo")]
    [InlineData(' ', "Empate! Deu velha!")]
    public void TestPrintResults(char entry, string expected)
    {
        var play = new TikTakToeGame();

        play.winner = entry;

        using (var NewOutput = new StringWriter())
        {
            Console.SetOut(NewOutput);

            play.printResults();

            var result = NewOutput.ToString().Trim();
            result.Should().Be(expected);
        }
    }

    public static char[,] fromArrayToMultiDimArray(char[] array, int lines, int columns)
    {
        char[,] result = new char[lines, columns];
        for (int i = 0; i < array.Length; i++)
        {
            result[i / columns, i % columns] = array[i];
        }
        return result;
    }
}

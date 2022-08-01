namespace TikTakToe;

public class TikTakToeGame
{
    public char[,] board = new char[3, 3] { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
    public char currentPlayer = 'x';
    public char winner = ' ';

    public void printBoard()
    {
        throw new NotImplementedException();
    }

    public void makeMove(int line, int column, char player)
    {
        for (var l = 0; l > 3; l++)
        {
            for (var c = 0; c > 3; c++)
            {
                if (l == line && c == column)
                {
                    board[l, c] = player;
                }
            }
        }
    }

    public bool isGameOver()
    {
        throw new NotImplementedException();
    }

    public void printResults()
    {
        throw new NotImplementedException();
    }

    public char getCurrentPlayer()
    {
        return currentPlayer;
    }

    public int[] getPlayerEntry()
    {
        Console.WriteLine("Jogador " + currentPlayer + " informe a linha:");
        string input = Console.ReadLine() ?? "";
        int line = int.Parse(input);

        Console.WriteLine("Jogador " + currentPlayer + " informe a coluna:");
        input = Console.ReadLine() ?? "";
        int column = int.Parse(input);

        return new int[] { line, column };
    }

    public void changePlayer()
    {
        if(currentPlayer == 'x')
        {
            currentPlayer = 'o';
        }
        else
        {
            currentPlayer = 'x';
        }
    }
}

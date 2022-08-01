namespace TikTakToe;

public class TikTakToeGame
{
    public char[,] board = new char[3, 3] { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
    public char currentPlayer = 'x';
    public char winner = ' ';

    public void printBoard()
    {
        for (var l = 0; l < 3; l++)
        {
            for (var c = 0; c < 3; c++)
            {
                if (c == 2) {
                    Console.Write($"{board[l,c]}\n");
                } else {
                    Console.Write($"{board[l,c]} ");
                }
            }
        }
    }

    public void makeMove(int line, int column, char player)
    {
        for (var l = 0; l < 3; l++)
        {
            for (var c = 0; c < 3; c++)
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
        // if (1,1) == (1,2) == (1,3) = ganhou na horizontal √
        // if (1,1) == (2,1) == (3,1) = ganhou na vertical √
        // if (1,1) == (2,2) == (3,3) = ganhou na diagonal √
        for (var i = 0; i < 3; i++)
        {
            if (board[i,0] == board[i,1] && board[i,1] == board[i,2] && board[i,0] != ' ')
            {
                winner = board[i, 0];
                return true;
            }

            if (board[0,i] == board[1,i] && board[1,i] == board[2,i] && board[0,1] != ' ')
            {
                winner = board[i, 0];
                return true;
            }

            if (board[0,0] == board[1,1] && board[1,1] == board[2,2] && board[0,0] != ' ')
            {
                winner = board[i, 0];
                return true;
            }

            if (board[2,0] == board[1,1] && board[1,1] == board[2,0] && board[2,0] != ' ')
            {
                winner = board[i, 0];
                return true;
            }
        }

        for (var l = 0; l < 3; l++)
        {
            for (var c = 0; c < 3; c++)
            {
                if (board[l,c] == ' ')
                {
                    winner = ' ';
                    return false;
                }
            }
        }

        winner = ' ';
        return true;
    }

    public void printResults()
    {
        if ( winner == 'x')  Console.WriteLine("O jogador x venceu!");
        else if ( winner == 'o')  Console.WriteLine("O jogador o venceu!");
        else Console.Write("Empate! Deu Velha!");
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

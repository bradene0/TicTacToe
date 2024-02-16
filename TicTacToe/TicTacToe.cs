using System;

class TicTacToe
{
    private char[,] board;
    private char currentPlayer;

    public object CurrentPlayer { get; internal set; }

    public TicTacToe()
    {
        board = new char[3, 3];
        currentPlayer = 'X'; // Player X starts first
        InitializeBoard();
    }

    private void InitializeBoard()
    {
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                board[row, col] = ' ';
            }
        }
    }

    public void PrintBoard()
    {
        Console.WriteLine("  0 1 2");
        for (int row = 0; row < 3; row++)
        {
            Console.Write(row + " ");
            for (int col = 0; col < 3; col++)
            {
                Console.Write("|" + board[row, col]);
            }
            Console.WriteLine("|");
        }
    }

    public bool MakeMove(int row, int col)
    {
        if (row < 0 || row >= 3 || col < 0 || col >= 3 || board[row, col] != ' ')
        {
            Console.WriteLine("Invalid move. Please try again.");
            return false;
        }

        board[row, col] = currentPlayer;
        return true;
    }

    public bool CheckForWinner()
    {
        // Check rows, columns, and diagonals for a winning condition
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer)
                return true;
            if (board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer)
                return true;
        }
        if ((board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer) ||
            (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer))
            return true;

        return false;
    }

    public void SwitchPlayer()
    {
        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
    }

    internal bool IsBoardFull()
    {
        throw new NotImplementedException();
    }
}

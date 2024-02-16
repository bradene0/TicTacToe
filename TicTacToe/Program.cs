using System;

static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Tic Tac Toe!");

        // Initialize the Tic Tac Toe game
        TicTacToe game = new TicTacToe();
        bool gameOver = false;

        // Game loop
        while (!gameOver)
        {
            // Print the current state of the game board
            game.PrintBoard();

            // Prompt the current player to make a move
            Console.WriteLine($"Player {game.CurrentPlayer}'s turn.");
            Console.Write("Enter row (0-2): ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter column (0-2): ");
            int col = int.Parse(Console.ReadLine());

            // Make the move and check for a winner or draw
            if (game.MakeMove(row, col))
            {
                if (game.CheckForWinner())
                {
                    // If there's a winner, end the game
                    Console.WriteLine($"Player {game.CurrentPlayer} wins!");
                    gameOver = true;
                }
                else if (game.IsBoardFull())
                {
                    // If the board is full and there's no winner, it's a draw
                    Console.WriteLine("It's a draw!");
                    gameOver = true;
                }
                else
                {
                    // Switch to the next player's turn
                    game.SwitchPlayer();
                }
            }
        }
    }
}

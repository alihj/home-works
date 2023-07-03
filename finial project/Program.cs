using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudokugame_ali_haji_haji
{
    class SudokuBoard
    {
        private int[,] board;

        public SudokuBoard()
        {
            board = new int[9, 9];
        }

        public int this[int row, int col]
        {
            get { return board[row, col]; }
            set { board[row, col] = value; }
        }
        public void InitializeBoard(int[,] initialBoard)
        {
            if (initialBoard.GetLength(0) != 9 || initialBoard.GetLength(1) != 9)
            {
                Console.WriteLine("Invalid initial board size. Must be a 9x9 grid.");
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    board[i, j] = initialBoard[i, j];
                }
            }


        }
        public bool IsValidMove(int row, int col, int value)
        {
            if (board[row, col] != 0)
            {
                return false;
            }

            for (int i = 0; i < 9; i++)
            {
                if (board[row, i] == value || board[i, col] == value)
                {
                    return false;
                }
            }

            int startRow = row;
            int startCol = col;

            for (int i = startRow; i < startRow + 3; i++)
            {
                for (int j = startCol; j < startCol + 3; j++)
                {
                    if (board[i, j] == value)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        public bool IsGameComplete()
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (board[row, col] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public void DisplayBoard()
        {
            Console.WriteLine("---------");

            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    Console.Write(board[row, col] + " ");
                    if (col == 2 || col == 5)
                    {
                        Console.Write("| ");
                    }
                }

                Console.WriteLine();

                if (row == 2 || row == 5)
                {
                    Console.WriteLine("---------");
                }
            }

            Console.WriteLine("---------");
        }
    }
    class SudokuGame
    {
        public SudokuBoard Board { get; }

        public SudokuGame()
        {
            Board = new SudokuBoard();
        }
        public void Play()
        {
            while (!Board.IsGameComplete())
            {
                Board.DisplayBoard();
                int row, col, value;

                Console.WriteLine("Enter the\nrow : \ncolumn : \nand value :  \n(from 1-9) or '0' to quit:");
               
                row = Convert.ToInt32(Console.ReadLine());
                col = Convert.ToInt32(Console.ReadLine());
                value = Convert.ToInt32(Console.ReadLine());

                if (row == 0 || col == 0 || value == 0)
                {
                    Console.WriteLine("Quitting the game...");
                    return;
                }
                if (
                        row < 1 || row > 9 ||
                        col < 1 || col > 9 ||
                        value < 1 || value > 9)
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }


                if (!Board.IsValidMove(row - 1, col - 1, value))
                {
                    Console.WriteLine("Invalid move. Please try again.");
                    continue;
                }

                Board[row - 1, col - 1] = value;
            }

            Console.WriteLine("Congratulations! You solved the Sudoku puzzle!");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[,] initialBoard =
            {
                { 5, 3, 0, 0, 7, 0, 0, 0, 0 },
                { 6, 0, 0, 1, 9, 5, 0, 0, 0 },
                { 0, 9, 8, 0, 0, 0, 0, 6, 0 },
                { 8, 0, 0, 0, 6, 0, 0, 0, 3 },
                { 4, 0, 0, 8, 0, 3, 0, 0, 1 },
                { 7, 0, 0, 0, 2, 0, 0, 0, 6 },
                { 0, 6, 0, 0, 0, 0, 2, 8, 0 },
                { 0, 0, 0, 4, 1, 9, 0, 0, 5 },
                { 0, 0, 0, 0, 8, 0, 0, 7, 9 }
            };

            SudokuGame game = new SudokuGame();
            game.Board.InitializeBoard(initialBoard);
            game.Play();
        }
    }
}

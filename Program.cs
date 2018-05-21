using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace conroy1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] board = initializeBoard();
            while (true)
            {

                //bool[,] board = initializeBoard();
                printBoard(board);
                bool[,] newBoard = updateBoard(board);
                //printBoard(newBoard);
                // board = copy(newBoard);
                for (int row = 1; row <= 20; row++)
                    for (int col = 1; col <= 40; col++)
                        board[row, col] = newBoard[row, col];


            }
        }
        public static bool[,] initializeBoard()
        {
            bool[,] startBoard = new bool[22, 42];
            startBoard[5, 10] = true;
            startBoard[8, 10] = true;
            startBoard[9, 10] = true;
            startBoard[10, 10] = true;

            startBoard[5,20] = true;
            startBoard[6, 21] = true;
            startBoard[7, 19] = true;
            startBoard[7, 20] = true;
            startBoard[7, 21] = true;

            return startBoard;
        }

        public static void printBoard(bool[,] b)
        {
            Console.Clear();
            for (int row = 1; row <=20; row++)
            {
                for(int col = 1; col <=40; col++)
                {
                    if (b[row, col]) Console.Write('X');
                    else Console.Write('.');
                }
                //Console.WriteLine();
                Console.WriteLine();
            }
            Thread.Sleep(400);
        }

        public static bool[,] updateBoard(bool[,] b)
        {
            bool[,] updatedBoard = new bool[22, 42];
            for (int row = 1; row <= 20; row++)
            {
                for(int col = 1; col <= 40; col++)
                {
                    int counter = 0;
                    for (int i=-1; i<2; i++)
                    {
                        for (int j = -1; j < 2; j++) {
                            if (b[row + i, col + j] && !(i == 0 && j == 0))
                                counter++;
                        }
                    }
                    //Console.Write(counter);
                    if (counter == 3) updatedBoard[row, col] = true;
                    else if (b[row, col] && counter == 2) updatedBoard[row, col] = true;
                    //else updatedBoard[row, col] = false;
                    
                }
            }
            //Thread.Sleep(5000);
            return updatedBoard;
        }

        public static bool[,] copy(bool[,] copiedBoard)
        {
            return copiedBoard;
        }
    }
}

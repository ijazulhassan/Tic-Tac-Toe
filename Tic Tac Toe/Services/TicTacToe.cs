using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe.Interfaces;
using Tic_Tac_Toe.Model;

namespace Tic_Tac_Toe.Services
{
    public class TicTacToe :ModelObjects,IService
    {
        
        public void InitializeBoard(char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = ' ';
                }
            }
        }

        public void Print(char[,] board)
        {
            Console.WriteLine("  | 0 | 1 | 2 |");
            for (int row = 0; row < 3; row++)
            {
                Console.Write(row + " | ");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
        }

        public char ChangeTurn(char CurrentPlayer)
        {
            if (CurrentPlayer == 'X')
            {
                return 'O';
            }
            else
            {
                return 'X';
            }
        }

        public int WiningCondition(char Player, char[,] board)
        {
            //Horzontal Winning Condtion
            //Winning Condition For First Row

            if (Player == board[0, 0] && Player == board[0, 1] && Player == board[0, 2])
            {
                Console.WriteLine("Player {0} has won the game", Player);
                Console.ReadKey();
                return 0;
            }
            //Winning Condition For Second Row
            else if (Player == board[1, 0] && Player == board[1, 1] && Player == board[1, 2])
            {
                Console.WriteLine("Player {0} has won the game", Player);
                Console.ReadKey();
                return 0;
            }
            //Winning Condition For Third Row
            else if (Player == board[2, 0] && Player == board[2, 1] && Player == board[2, 2])
            {
                Console.WriteLine("Player {0} has won the game", Player);
                Console.ReadKey();
                return 0;
            }

            //Vertical Winning Condtion
            //Winning Condition For First Col

            if (Player == board[0, 0] && Player == board[1, 0] && Player == board[2, 0])
            {
                Console.WriteLine("Player {0} has won the game", Player);
                Console.ReadKey();
                return 0;
            }
            //Winning Condition For Second Col
            else if (Player == board[0, 1] && Player == board[1, 1] && Player == board[2, 1])
            {
                Console.WriteLine("Player {0} has won the game", Player);
                Console.ReadKey();
                return 0;
            }
            //Winning Condition For Third Col
            else if (Player == board[0, 2] && Player == board[1, 2] && Player == board[2, 2])
            {
                Console.WriteLine("Player {0} has won the game", Player);
                Console.ReadKey();
                return 0;
            }

            //Diagnol Winning Condtion
            //Winning Condition For lef to right

            if (Player == board[0, 0] && Player == board[1, 1] && Player == board[2, 2])
            {
                Console.WriteLine("Player {0} has won the game", Player);
                Console.ReadKey();
                return 0;
            }
            //Winning Condition For right to left
            else if (Player == board[0, 2] && Player == board[1, 1] && Player == board[2, 0])
            {
                Console.WriteLine("Player {0} has won the game", Player);
                Console.ReadKey();
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public void CheckMarked(int row, int col, char Player, char[,] board)
        {
            if (board[row, col] != 'X' && board[row, col] != 'O')
            {
                board[row, col] = Player;
            }
            else
            {
                Console.Write("already marked! plz choose another location ");
            }
        }
    }
}

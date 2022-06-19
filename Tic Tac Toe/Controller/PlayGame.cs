using System;
using Tic_Tac_Toe.Services;

namespace Tic_Tac_Toe
{
    public class PlayGame : TicTacToe
    {
        PlayGame play;
       static PlayGame get()
        {
            PlayGame game = new PlayGame();
            return game;
        }

        static void Main(string[] args)
        {
            char[,] board = new char[3, 3];
            char Player = 'X';
            PlayGame play = get();
 
            GamePlay(board, Player, play);
        }

         static void GamePlay(char[,] board, char Player, PlayGame play)
        {
            play.InitializeBoard(board);
            int start = 1;
            while (start != 0 )
            {

                Console.Clear();
                play.Print(board);

                Console.Write("Plz enter the row: ");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.Write("Plz enter the col: ");
                int col = Convert.ToInt32(Console.ReadLine());
                play.CheckMarked(row, col, Player, board);

                //check if player win.
                start = play.WiningCondition(Player, board);
                Player = play.ChangeTurn(Player);
                Console.WriteLine("row {0} col {1}", row, col);

            }
        }
    }
}


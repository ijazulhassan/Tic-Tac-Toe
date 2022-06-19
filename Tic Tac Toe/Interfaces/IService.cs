using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Interfaces
{
    public interface IService
    {
        public  void InitializeBoard(char[,] board);
        public void Print(char[,] board);
        public char ChangeTurn(char CurrentPlayer);
        public int WiningCondition(char Player, char[,] board);
        public void CheckMarked(int row, int col, char Player, char[,] board);
    }
}

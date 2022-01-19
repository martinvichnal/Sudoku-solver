using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuTester
{
    class Sudoku
    {
        // Possible string, in, char
        //
        //public string SudokuNumbers { get; set; }
        //public List<int> SudokuNumbers = new List<int>();
        //public List<string> SudokuNumbers = new List<string>();
        public List<char> sudokuNumbers = new List<char>();
        public int gridCount { get; set; }


        public int GetNumer(int x, int y)
        {
            // O = (x-1)*S+Y
            int s = gridCount
            int number = (x - 1) * 
            return x;
        }
    }
}

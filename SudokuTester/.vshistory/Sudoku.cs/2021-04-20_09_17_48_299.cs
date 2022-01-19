using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuTester
{
    class Sudoku
    {
        public List<int> sudokuNumbers = new List<int>();
        public int gridCount { get; set; }


        public double GetNumer(int x, int y)
        {
            // Main Calculation for Getting the Serial number of a selected square.
            // Serial number = (x - 1) * gridCount(for exaplme 4*4) + y
            
            gridCount = Convert.ToInt32(Math.Sqrt(sudokuNumbers.Count));
            return (x - 1) * gridCount + y;
        }
    }
}

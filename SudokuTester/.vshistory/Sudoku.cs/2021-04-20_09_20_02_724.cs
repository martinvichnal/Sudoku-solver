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
        
        
        // Main Calculation for Getting the Serial number of a selected square.
        public double GetNumer(int x, int y)
        {    
            // Serial number = (x - 1) * gridCount(for exaplme 4*4) + y   
            gridCount = Convert.ToInt32(Math.Sqrt(sudokuNumbers.Count));
            return (x - 1) * gridCount + y;
        }

        public bool CheckingForRight()
        {
            // Chekcing for VERTICAL problems



            // Checking for HORIRZONTAL problems




            return false;
        }
    }
}

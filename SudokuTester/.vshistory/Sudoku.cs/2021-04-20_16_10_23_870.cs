using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuTester
{
    class Sudoku
    {
        public static List<int> sudokuNumbers = new List<int>();
        public static int gridCount { get; set; }

        // Main Calculation for Getting the Serial number of a selected square.
        public static int GetNumer(int x, int y)
        {
            // Serial number = (x - 1) * gridCount(for exaplme 4*4) + y

            gridCount = Convert.ToInt32(Math.Sqrt(sudokuNumbers.Count));
            int number = (x - 1) * gridCount + y;
            return number;
        }


        // Main Method for checking the Vertical and the Horizontal numbers for any duplicants
        public static bool CheckingForRight(int x, int y)
        {
            gridCount = Convert.ToInt32(Math.Sqrt(sudokuNumbers.Count));
            int problemCount = 0;
            int defaultNumber = GetNumer(x, y);
            bool isFoundProblem = false;

            ////////////////////////////////////// ****** VERTICAL ****** //////////////////////////////////////
            // Chekcing for VERTICAL problems   //
            // Adding 4 every upper checks      //
            // Removing 4 every down checks     //
            //////////////////////////////////////

            int o = defaultNumber;
            int oUpper = o;
            int oLower = o;
            bool isThereSomethingVertical = true;

            // Upper
            while (isThereSomethingVertical)
            {
                oUpper = oUpper - gridCount;
                if (oUpper <= 0)
                {
                    isThereSomethingVertical = true;
                    break;
                }
                else
                {
                    if (sudokuNumbers[defaultNumber - 1] == sudokuNumbers[oUpper - 1])
                    {
                        problemCount++;
                        isFoundProblem = true;
                    }
                }
            }

            isThereSomethingVertical = true;

            // Lower
            while (isThereSomethingVertical)
            {
                oLower = oLower + gridCount;
                if (oLower > sudokuNumbers.Count) // if (oLower > 16)
                {
                    isThereSomethingVertical = true;
                    break;
                }
                else
                {
                    if (sudokuNumbers[defaultNumber - 1] == sudokuNumbers[oLower - 1])
                    {
                        problemCount++;
                        isFoundProblem = true;
                    }
                }
            }

            ////////////////////////////////////// ****** HORIRZONTAL ****** //////////////////////////////////////
            // Chekcing for HORIRZONTAL problems//
            // Adding 1 every upper checks      //
            // Removing 1 every left checks     //
            //////////////////////////////////////

            int Right = y;
            int Left = y;
            bool isThereSomethingHorizontal = true;

            // Right
            while (isThereSomethingHorizontal)
            {
                Right++;
                if (Right > gridCount) // if (Right > 4)
                {
                    isThereSomethingHorizontal = true;
                    break;
                }
                else
                {
                    if (sudokuNumbers[defaultNumber - 1] == sudokuNumbers[GetNumer(x, Right) - 1])
                    {
                        problemCount++;
                        isFoundProblem = true;
                    }
                }   
            }

            // Left
            while (isThereSomethingHorizontal)
            {
                Left--;
                if (Left < 1)
                {
                    isThereSomethingHorizontal = true;
                    break;
                }
                else
                {
                    if (sudokuNumbers[defaultNumber - 1] == sudokuNumbers[GetNumer(x, Left) - 1])
                    {
                        problemCount++;
                        isFoundProblem = true;
                    }
                }
            }
            return isFoundProblem;
        }
    }
}

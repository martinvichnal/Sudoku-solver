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
                oUpper = oUpper - Convert.ToInt32(Math.Sqrt(sudokuNumbers.Count));
                if (oUpper <= 0)
                {
                    isThereSomethingVertical = true;
                    break;
                }
                else
                {
                    if (sudokuNumbers[defaultNumber] == sudokuNumbers[oUpper])
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
                oLower = oLower + Convert.ToInt32(Math.Sqrt(sudokuNumbers.Count));
                if (oLower > 16)
                {
                    isThereSomethingVertical = true;
                    break;
                }
                else
                {
                    if (sudokuNumbers[defaultNumber] == sudokuNumbers[oLower])
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

            //int Right = y;
            //int Left = y;
            //bool isThereSomethingHorizontal = true;

            //// Right
            //while (isThereSomethingHorizontal)
            //{
            //    if (Right >= 4)
            //    {
            //        isThereSomethingHorizontal = true;
            //        break;
            //    }
            //    else
            //    {
            //        if (sudokuNumbers[defaultNumber] == sudokuNumbers[GetNumer(x,Right)])
            //        {
            //            problemCount++;
            //            isFoundProblem = true;
            //        }
            //    }
            //    Right++;
            //}

            //// Left
            //while (isThereSomethingHorizontal)
            //{
            //    if (Left <= 1)
            //    {
            //        isThereSomethingHorizontal = true;
            //        break;
            //    }
            //    else
            //    {
            //        if (sudokuNumbers[defaultNumber] == sudokuNumbers[GetNumer(x, Left)])
            //        {
            //            problemCount++;
            //            isFoundProblem = true;
            //        }
            //    }
            //    Left--;
            //}
            return isFoundProblem;
        }
    }
}

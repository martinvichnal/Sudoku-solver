using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuTester
{
    class Sudoku
    {
        // Public variables for the program

        // public static List<int> sudokuNumbers = new List<int>();
        public static int sqrtGrid { get; set; }                    // The Squareroot for the gridSize
        public static int gridSize { get; set; }                    // Grid Size

        public static int[,] problemCoordiantes { get; set; }       // The coordiantes for the wrong numbers



        // Main Calculation for Getting the Serial number of a selected square.
        public static int GetNumber(int x, int y)
        {
            // Serial number = (x - 1) * gridCount(for exaplme 4*4) + y
            sqrtGrid = Convert.ToInt32(Math.Sqrt(gridSize));
            return (x - 1) * sqrtGrid + y;
        }


        // Main Method for checking the Vertical and the Horizontal numbers for any duplicants
        // Note: This can be maybe faster if the vertical and the horizontal is checked individually 
        //       i.e: 4x4 -> 4 horizontal and 4 vertical check. Wrong number is saved.


        public static bool CheckingForRight(int x, int y)
        {
            sqrtGrid = Convert.ToInt32(Math.Sqrt(gridSize));
            int problemCount = 0;
            bool isFoundProblem = false;

            ////////////////////////////////////// ****** VERTICAL ****** //////////////////////////////////////
            //   Chekcing for VERTICAL problems : Adding 4 every upper checks, removing 4 every down checks   //
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            /// The same number can't be in the vertical line
            int yUpper = y;
            int yLower = y;
            bool isThereSomethingVertical = true;

            // Checking the upper numbers
            while (isThereSomethingVertical)
            {
                yUpper = yUpper - 1;
                // If it's out of bound it will brake from the while cycle 
                if (yUpper < 0)
                {
                    break;
                }
                // Checking if is equals to it's upper value
                if (Program.testNumber10[x, y] == Program.testNumber10[x, yUpper] && Program.testNumber10[x, yUpper] != 0)
                {
                    problemCount++;
                    isFoundProblem = true;
                    bool isFoundProblemVertically = true;
                }
            }

            // Checking the lower numbers
            isThereSomethingVertical = true;            // Reseting the bool value for the lower numbers
            while (isThereSomethingVertical)
            {
                yLower = yLower + 1;
                // If it's out of bound it will brake from the while cycle 
                if (yLower > sqrtGrid - 1)
                { 
                    break;
                }
                // Checking if is equals to it's lower value
                if (Program.testNumber10[x, y] == Program.testNumber10[x, yLower] && Program.testNumber10[x, yLower] != 0)
                {
                    problemCount++;
                    isFoundProblem = true;
                    bool isFoundProblemVertically = true;
                }
            }

            ////////////////////////////////////// ****** HORIRZONTAL ****** //////////////////////////////////////
            //   Chekcing for HORIRZONTAL problems : Adding 1 every upper checks, removing 1 every left checks   //
            ///////////////////////////////////////////////////////////////////////////////////////////////////////
            /// The same number can't be in the horizontal line
            int xRight = x;
            int xLeft = x;
            bool isThereSomethingHorizontal = true;

            // Checking the Right side numbers
            while (isThereSomethingHorizontal)
            {
                xRight++;
                // If it's out of bound it will brake from the while cycle 
                if (xRight > sqrtGrid - 1)
                {
                    break;
                }
                // Checking if is equals to it's right value
                if (Program.testNumber10[x, y] == Program.testNumber10[xRight, y] && Program.testNumber10[xRight, y] != 0)
                {
                    problemCount++;
                    isFoundProblem = true;
                    bool isFoundProblemHorizontally = true;
                }
            }

            // Checking the Left side numbers
            isThereSomethingHorizontal = true;          // Reseting the bool value for the left numbers
            while (isThereSomethingHorizontal)
            {
                xLeft--;
                if (xLeft < 0)
                {
                    break;
                }
                // Checking if is equals to it's left value
                if (Program.testNumber10[x, y] == Program.testNumber10[xLeft, y] && Program.testNumber10[xLeft, y] != 0)
                {
                    problemCount++;
                    isFoundProblem = true;
                    bool isFoundProblemHorizontally = true;
                }
            }


            ////////////////////////////////////// ****** SMALL BOX CHECK ****** //////////////////////////////////////
            //                                   Chekcing problems in the small box                                  //
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////

            int smallBoxSize = Convert.ToInt32(Math.Sqrt(sqrtGrid));






            // Storeing the coordinates for the problematical number

            // Returning a bool if there is a problem or not. (false = no prblem, true = problem)
            return isFoundProblem;
        }
    }
}

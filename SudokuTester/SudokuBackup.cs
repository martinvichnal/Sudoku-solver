using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuTester
{
    internal class SudokuBackup
    {        
        // Public variables for the program
        //public static List<int> sudokuNumbers = new List<int>();

        public static int sqrtGrid { get; set; }        // The Squareroot for the gridSize
        public static int gridSize { get; set; }        // Grid Size

        public static int[,] problemCoordiantes { get; set; }       // The coordiantes for the wrong numbers



        // This now is basically useless ... NOICE ... :)
        // Main Calculation for Getting the Serial number of a selected square.
        public static int GetNumber(int x, int y)
        {
            // Serial number = (x - 1) * gridCount(for exaplme 4*4) + y

            sqrtGrid = Convert.ToInt32(Math.Sqrt(gridSize));

            int number = (x - 1) * sqrtGrid + y;

            return number;
        }


        // Main Method for checking the Vertical and the Horizontal numbers for any duplicants
        public static bool CheckingForRight(int x, int y)
        {
            sqrtGrid = Convert.ToInt32(Math.Sqrt(gridSize));

            int problemCount = 0;

            bool isFoundProblem = false;

            ////////////////////////////////////// ****** VERTICAL ****** //////////////////////////////////////
            // Chekcing for VERTICAL problems   //
            // Adding 4 every upper checks      //
            // Removing 4 every down checks     //
            //////////////////////////////////////

            int yUpper = y;
            int yLower = y;
            bool isThereSomethingVertical = true;

            // Checking the upper numbers
            while (isThereSomethingVertical)
            {
                yUpper = yUpper - 1;
                if (yUpper < 0)
                {
                    isThereSomethingVertical = true;
                    break;
                }
                else
                {
                    if (Program.testNumber1[x, y] == Program.testNumber1[x, yUpper])
                    {
                        problemCount++;
                        isFoundProblem = true;
                    }
                }
            }

            isThereSomethingVertical = true;

            // Checking the lower numbers
            while (isThereSomethingVertical)
            {
                yLower = yLower + 1;
                if (yLower > sqrtGrid - 1)
                {
                    isThereSomethingVertical = true;
                    break;
                }
                else
                {
                    if (Program.testNumber1[x, y] == Program.testNumber1[x, yLower])
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

            int xRight = x;
            int xLeft = x;
            bool isThereSomethingHorizontal = true;

            // Checking the Right side numbers
            while (isThereSomethingHorizontal)
            {
                xRight++;
                if (xRight > sqrtGrid - 1)
                {
                    isThereSomethingHorizontal = true;
                    break;
                }
                else
                {
                    if (Program.testNumber1[x, y] == Program.testNumber1[xRight, y])
                    {
                        problemCount++;
                        isFoundProblem = true;
                    }
                }
            }

            // Checking the Left side numbers
            while (isThereSomethingHorizontal)
            {
                xLeft--;
                if (xLeft < 0)
                {
                    isThereSomethingHorizontal = true;
                    break;
                }
                else
                {
                    if (Program.testNumber1[x, y] == Program.testNumber1[xLeft, y])
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

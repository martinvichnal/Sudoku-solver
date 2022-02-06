using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuTester
{
    class Program
    {
        // 4 by 4 Sudokus
        // Test numbers => 3412,1243,2134,4321 .. 2143,4321,1234.3412 .. 1234,4312,2143,3421 .. 4312,2134,3421,1243

        public static int[,] testNumber1 =      // Test 1 2D Matrix Numbers 
        {
            { 3, 4, 1, 2 },
            { 1, 2, 4, 3 },
            { 2, 1, 3, 4 },
            { 4, 3, 2, 1 }
        };

        public static int[,] testNumber10 =     // Test 1 2D Matrix Numbers WITH 0
        {
            { 0, 4, 1, 0 },
            { 1, 0, 4, 3 },
            { 2, 1, 0, 4 },
            { 0, 3, 2, 1 }
        };      

        //public static int[,] testNumber2 = { { 2, 1, 4, 3 }, { 4, 3, 2, 1 }, { 1, 2, 3, 4 }, { 3, 4, 1, 2 } };      // Test 2 2D Matrix Numbers
        //public static int[,] testNumber2w = { { 2, 1, 4, 3 }, { 4, 4, 2, 1 }, { 1, 2, 3, 4 }, { 3, 4, 1, 2 } };      // Test 2 2D Matrix Numbers WRONG
        //public static int[,] testNumber3 = { { 1, 2, 3, 4 }, { 4, 3, 1, 2 }, { 2, 1, 4, 3 }, { 3, 4, 2, 1 } };      // Test 3 2D Matrix Numbers
        //public static int[,] testNumber4 = { { 4, 3, 1, 2 }, { 2, 1, 3, 4 }, { 3, 4, 2, 1 }, { 1, 2, 4, 3 } };      // Test 4 2D Matrix Numbers
        static void Main(string[] args)
        {
            Console.WriteLine("Hello this is my sudoku tester program where I testing each methods");

            //var testNumberArrays = new[] { testNumber1, testNumber2, testNumber3, testNumber4 };

            Sudoku.gridSize = testNumber1.Length;
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {

                    Console.WriteLine($"O({x},{y})\t placed on ...\t and has a value of {testNumber10[x, y]}\t is {Sudoku.CheckingForRight(x, y)}\t");
                }
            }

            Console.ReadLine();
        }
    }
}

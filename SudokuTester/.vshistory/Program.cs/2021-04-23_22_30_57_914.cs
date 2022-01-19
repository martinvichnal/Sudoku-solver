using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuTester
{
    class Program
    {
        public static int[,] testNumber1 = { { 3, 4, 1, 2 }, { 1, 2, 4, 3 }, { 2, 1, 3, 4 }, { 4, 3, 2, 1 } };      // Test 2D Matrix Numbers 
        public static int[,] testNumber2 = { { 2, 1, 4, 3 }, { 4, 3, 2, 1 }, { 1, 2, 3, 4 }, { 3, 4, 1, 2 } };      // Test 2D Matrix Numbers
        public static int[,] testNumber3 = { { 1, 2, 3, 4 }, { 4, 3, 1, 2 }, { 2, 1, 4, 3 }, { 3, 4, 2, 1 } };      // Test 2D Matrix Numbers
        public static int[,] testNumber4 = { { 4, 3, 1, 2 }, { 2, 1, 3, 4 }, { 3, 4, 2, 1 }, { 1, 2, 4, 3 } };      // Test 2D Matrix Numbers

        static void Main(string[] args)
        {
            Console.WriteLine("Hello this is my sudoku tester program where I testing each methods");

            // 4 by 4
            // Test numbers => 2143,4321,1234.3412 .. 1234,4312,2143,3421 .. 4312,2134,3421,1243 .. 3412,1243,2134,4321
            //int[,] testNumber = { { 3, 4, 1, 2 }, { 1, 2, 4, 3 }, { 2, 1, 3, 4 }, { 4, 3, 2, 1 } };      // Test 2D Matrix Numbers 
            //int[,] testNumber2 = { { 2, 1, 4, 3 }, { 4, 3, 2, 1 }, { 1, 2, 3, 4 }, { 3, 4, 1, 2 } };      // Test 2D Matrix Numbers
            //int[,] testNumber3 = { { 1, 2, 3, 4 }, { 4, 3, 1, 2 }, { 2, 1, 4, 3 }, { 3, 4, 2, 1 } };      // Test 2D Matrix Numbers
            //int[,] testNumber4 = { { 4, 3, 1, 2 }, { 2, 1, 3, 4 }, { 3, 4, 2, 1 }, { 1, 2, 4, 3 } };      // Test 2D Matrix Numbers

            //var testNumberArrays = new[] { testNumber1, testNumber2, testNumber3, testNumber4 };


            Sudoku.gridSize = testNumber1.Length;

            //int x = 0;
            //int y = 0;
            //while (true)
            //{
            //    Console.Write($"x: "); x = int.Parse(Console.ReadLine());
            //    Console.Write($"y: "); y = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"O({x},{y})\t placed on {Sudoku.GetNumber(x, y)}\t and has a value of {testNumber1[x, y]}\t is  {Sudoku.CheckingForRight(x, y)}\t");
            //}


            for (int x = 0; x <= 4; x++)
            {
                for (int y = 0; y <= 4; y++)
                {
                    //Console.WriteLine($"O({x},{y})\t placed on {Sudoku.GetNumer(x, y)}\t and has a value of {Sudoku.sudokuNumbers[Sudoku.GetNumer(x, y) - 1]}\t is  {Sudoku.CheckingForRight(x, y)}\t");
                    Console.WriteLine($"O({x},{y})\t placed on {Sudoku.GetNumber(x, y)}\t and has a value of {testNumber1[x, y]}\t is  {Sudoku.CheckingForRight(x, y)}\t");

                }
            }
            Console.WriteLine("____________________________________________________________________________________________________________________________________________________");





            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///                                                                         Version List
            //int[] testNumber1 = { 2, 1, 4, 3, 4, 3, 2, 1, 1, 2, 3, 4, 3, 4, 1, 2 };
            //int[] testNumber2 = { 1, 2, 3, 4, 4, 3, 1, 2, 2, 1, 4, 3, 3, 4, 2, 1 };
            //int[] testNumber3 = { 4, 3, 1, 2, 2, 1, 3, 4, 3, 4, 2, 1, 1, 2, 4, 3 };
            //int[] testNumber4 = { 3, 4, 1, 2, 1, 2, 4, 3, 2, 1, 3, 4, 4, 3, 2, 1 };

            //for (int main = 0; main < 4; main++)
            //{
            //    Sudoku.sudokuNumbers.AddRange(testNumberArrays[main]);
            //
            //    for (int x = 1; x <= 4; x++)
            //    {
            //        for (int y = 1; y <= 4; y++)
            //        {
            //            Console.WriteLine($"O({x},{y})\t placed on {Sudoku.GetNumer(x, y)}\t and has a value of {Sudoku.sudokuNumbers[Sudoku.GetNumer(x, y) - 1]}\t is  {Sudoku.CheckingForRight(x, y)}\t");
            //        }
            //    }
            //    Console.WriteLine("____________________________________________________________________________________________________________________________________________________");
            //    Sudoku.sudokuNumbers.Clear();
            //}




            // Filling up the sudokuNumbers with the testNumber int array
            //for (int i = 0; i < 16; i++)
            //{
            //    Sudoku.sudokuNumbers.Add(testNumber1[i]);
            //}


            //Console.WriteLine(Sudoku.sudokuNumbers[Sudoku.GetNumer(0,2) - 1]);

        }
    }
}

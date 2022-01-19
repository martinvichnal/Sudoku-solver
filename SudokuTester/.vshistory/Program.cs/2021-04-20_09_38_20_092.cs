using System;

namespace SudokuTester
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4 by 4
            // Test numbers => 2143,4321,1234.3412 .. 1234,4312,2143,3421 .. 4312,2134,3421,1243 .. 3412,1243,2134,4321
            int[] testNumber = { 2,1,4,3,4,3,2,1,1,2,3,4,3,4,1,2 };
            Console.WriteLine("Hello this is my sudoku tester program where I testing each methods");
            for (int i = 0; i < 16; i++)
            {
                Sudoku sudoku = new Sudoku();
                sudoku.sudokuNumbers.Add();
            }
        }
    }
}

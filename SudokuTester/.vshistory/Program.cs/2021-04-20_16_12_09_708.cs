using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuTester
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4 by 4
            // Test numbers => 2143,4321,1234.3412 .. 1234,4312,2143,3421 .. 4312,2134,3421,1243 .. 3412,1243,2134,4321
            int[] testNumber1 = { 2, 1, 4, 3, 4, 3, 2, 1, 1, 2, 3, 4, 3, 4, 1, 2 };
            int[] testNumber2 = { 1, 2, 3, 4, 4, 3, 1, 2, 2, 1, 4, 3, 3, 4, 2, 1 };
            int[] testNumber3 = { 4, 3, 1, 2, 2, 1, 3, 4, 3, 4, 2, 1, 1, 2, 4, 3 };
            int[] testNumber4 = { 3, 4, 1, 2, 1, 2, 4, 3, 2, 1, 3, 4, 4, 3, 2, 1 };

            Console.WriteLine("Hello this is my sudoku tester program where I testing each methods");
            for (int i = 0; i < 16; i++)
            {
                Sudoku.sudokuNumbers.Add(testNumber1[i]);
            }


            //Console.WriteLine(Sudoku.sudokuNumbers[Sudoku.GetNumer(0,2) - 1]);

            int x = 0;
            int y = 0;
            //while (true)
            //{
            //    Console.Write($"x: "); x = int.Parse(Console.ReadLine());
            //    Console.Write($"y: "); y = int.Parse(Console.ReadLine());
            //    int answer = Sudoku.GetNumer(x, y);
            //    Console.WriteLine($"Az eredmeny: {answer} -> {Sudoku.sudokuNumbers[answer - 1]}");
            //    Console.WriteLine();
            //    if (Sudoku.CheckingForRight(x, y))
            //    {
            //        Console.WriteLine("PROBLEM");
            //    }
            //}

        }
    }
}

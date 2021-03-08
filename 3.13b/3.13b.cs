/*
3.13 (Order of Evaluation) State the order of evaluation of the operators in each of the following
     C# statements and show the value of x after each statement is performed:

b) x = 2 % 2 + 2 * 2 - 2 / 2;

*/

using System;

namespace _3._13b
{
    class Program
    {
        static void Main(string[] args)
        {
            int x0, x1, x2, x3, mainX;

            Console.WriteLine("x = 2 % 2 + 2 * 2 - 2 / 2");
            Console.WriteLine();
            Console.WriteLine("Order of evaluation is\n" +
               "In the first place 2%2 = {0}\n" +
               "Then 2 * 2 = {1}\n" +
               "Next 2  / 2 = {2}\n" +
               "Further {0} + {1} = {3}\n" +
               "And in the end {3} - {2} = {4}\n" +
               "\n" +
               "x = {4}",
               x0 = 2%2, x1 = 2 * 2, x2 = 2 / 2, x3 = x0 + x1, mainX = x3 - x2 );

            Console.ReadKey();
        }
    }
}

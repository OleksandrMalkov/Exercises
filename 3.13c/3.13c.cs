/*
3.13 (Order of Evaluation) State the order of evaluation of the operators in each of the following
C# statements and show the value of x after each statement is performed:

c) x=( 3 * 9 * ( 3 + ( 9 * 3 / ( 3 ) ) ) );

*/

using System;

namespace _3._13c
{
    class Program
    {
        static void Main(string[] args)
        {
            int x0, x1, x2, x3, mainX;

            Console.WriteLine("x = ( 3 * 9 * ( 3 + ( 9 * 3 / ( 3 ) ) ) )");
            Console.WriteLine();
            Console.WriteLine("Order of evaluation is\n" +
               "In the first place 3/(3) = {0}\n" +
               "Then 9 * {0} = {1}\n" +
               "Next 3 + {1} = {2}\n" +
               "Further 3 * 9 = {3}\n" +
               "And in the end {3} * {2} = {4}\n" +
               "\n" + 
               "x = {4}",
               x0 = 3 / (3), x1 = 9 * x0, x2 = 3 + x1, x3 = 3 * 9, mainX = x3 * x2);
            Console.ReadKey();
        }
    }
}

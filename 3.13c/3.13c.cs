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
            int x;

            x = (3 * 9 * (3 + (9 * 3 / (3))));

            Console.WriteLine("x is {0}", x);

            Console.ReadKey();
        }
    }
}

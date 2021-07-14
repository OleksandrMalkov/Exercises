/*
   3.15 (Arithmetic) Write an app that asks the user to enter two integers, obtains them from the
        user and displays their sum, product, difference and quotient (division). Use the techniques shown
        in Fig. 3.14.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._15
{
    class Program
    {
        static void Main(string[] args)
        {
            int int1, int2;

            Console.Write("Enter first integer: ");
            int1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer: ");
            int2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Sum is: {0}", int1 + int2);

            Console.WriteLine("Product is: {0}", int1 * int2);

            Console.WriteLine("Difference is: {0}", int1 - int2);

            Console.WriteLine("Quintient is: {0}", int1 / int2);

            Console.ReadKey();
        }
    }
}

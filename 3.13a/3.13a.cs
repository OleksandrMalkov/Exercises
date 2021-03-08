/*
 3.13 (Order of Evaluation) State the order of evaluation of the operators in each of the following
      C# statements and show the value of x after each statement is performed:

a) x = 7 + 3 * 6 / 2 - 1;

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._13a
{
    class Program
    {
        static void Main(string[] args)
        {
            int x0, x1, x2, mainX;

            Console.WriteLine("x = 7 + 3 * 6 / 2 - 1");
            Console.WriteLine();
            Console.WriteLine("Order of evaluation is\n" +
                "In the first place 3 * 6 = {0}\n" +
                "Then {0} / 2 = {1}\n" +
                "Next 7 + {1} = {2}\n" +
                "And in the end {2} - 1 = {3}\n" +
                "\n" +
                "x = {3}",
                x0=3*6, x1=x0/2, x2=7+x1, mainX=16-1 );

            Console.ReadKey(); 
        }
    }
}

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

namespace _3._13
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            x = 7 + 3 * 6 / 2 - 1;

            Console.WriteLine("x is {0}", x);

            Console.ReadKey(); 
        }
    }
}

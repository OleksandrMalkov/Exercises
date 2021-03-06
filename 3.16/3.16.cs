/*
  3.16 (Comparing Integers) Write an app that asks the user to enter two integers, obtains them
       from the user and displays the larger number followed by the words "is larger". If the numbers
       are equal, display the message "These numbers are equal." Use the techniques shown in Fig. 3.22.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._16
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.Write("Enter first integer: ");
                x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer: ");
                y = Convert.ToInt32(Console.ReadLine());

            if (x > y)
                Console.WriteLine("{0} is larger", x);

            if (y > x)
                Console.WriteLine("{0} is larger", y);

            if (x == y)
                Console.WriteLine("These numbers are equal");

            Console.ReadKey();
        }
    }
}

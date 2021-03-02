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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._24
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.Write("Enter the integer: ");
            x = Convert.ToInt32(Console.ReadLine());

            if (x % 2 == 1)
                Console.WriteLine("{0} is odd", x);

            if (x % 2 < 1)
                Console.WriteLine("{0} is even", x);

            Console.ReadKey();
        }
    }
}

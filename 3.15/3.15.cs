using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._14
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, sum, average, product, smallest, larges;

            Console.Write("Enter first integer: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer: ");
            y = Convert.ToInt32(Console.ReadLine());

            sum = x + y;

            Console.WriteLine("Sum is {0}", sum);

            average = (x + y) / 2;

            Console.WriteLine("Average is {0}", average);

            product = x * y;

            Console.WriteLine("Product is {0}", product);

            if (x > y)
                Console.WriteLine("{0} smallest number\n{1} larges number", y, x);

            if (y > x)
                Console.WriteLine("{0} smallest number\n{1} larges number", x, y);

            Console.Read();
        }
    }
}

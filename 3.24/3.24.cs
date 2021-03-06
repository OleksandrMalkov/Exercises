/*
3.24 (Odd or Even) Write an app that reads an integer, then determines and displays whether
     it’s odd or even. [Hint: Use the remainder operator. An even number is a multiple of 2. Any multiple
     of 2 leaves a remainder of 0 when divided by 2.]
*/

using System;

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

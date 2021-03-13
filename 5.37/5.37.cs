/*5.37 (Factorials) The factorial of a nonnegative integer n is written as n! (pronounced “n factorial”) and is defined as follows:
        n! = n · (n – 1) · (n – 2) · … · 1 (for values of n greater than or equal to 1)
and
        n! = 1 (for n = 0)
For example, 5! = 5 · 4 · 3 · 2 · 1, which is 120. Write an app that reads a nonnegative integer and
computes and displays its factorial. */
using System;

class Program
{
    static void Main(string[] args)
    {
        decimal x, y;
        Console.WriteLine("Enter nonegative integer: ");
        x = Convert.ToDecimal(Console.ReadLine());

        if (x > 0)
        {
            y = x * --x;
            while (x > 1)
            {
                y *= --x;
            }

            Console.WriteLine("Factorial is \n{0}", y);
            Console.ReadKey();
        }
        if (x == 0)
        {
            Console.WriteLine("Factorial is 1");
            Console.ReadLine();
        }
    }
}
//This app work (but only to 1!-27!). But I am really not sure that it works right. 
/*6.23 (Displaying a Diamond) Write an app that displays the following diamond shape. 
       You may use output statements that display a single asterisk (*), a single space or a single newline character.
       Maximize your use of repetition (with nested for statements) and minimize the number of output statements.

    *
   ***
  *****
 *******
*********
 *******
  *****
   ***
    *     */

using System;
class Program
{
    static void Main(string[] args)
    {
        int x, y;
        int number = 5;
        int count = 1;
        count = number - 1;
        for (y = 1; y <= number; y++)
        {
            for (x = 1; x <= count; x++)
                Console.Write(" ");
            count--;
            for (x = 1; x <= 2 * y - 1; x++)
                Console.Write("*");
            Console.WriteLine();
        }
        count = 1;
        for (y = 1; y <= number - 1; y++)
        {
            for (x = 1; x <= count; x++)
                Console.Write(" ");
            count++;
            for (x = 1; x <= 2 * (number - y) - 1; x++)
                Console.Write("*");
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}


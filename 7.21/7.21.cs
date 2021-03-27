/* 7.21 (Separating Digits) Write code segments that accomplish each of the following tasks:
        a) Calculate the integer part of the quotient when integer a is divided by integer b.
        b) Calculate the integer remainder when integer a is divided by integer b.
        c) Use the app pieces developed in parts (a) and (b) to write a method DisplayDigits that receives an integer between 1 and 99999 and displays
           it as a sequence of digits, separating each pair of digits by two spaces. For example, the integer 4562 should appear as: 4562.
        d) Incorporate the method developed in part (c) into an app that inputs an integer and calls DisplayDigits by passing the method the integer entered. Display the results.

Answers:

        a) c = a / b;
        b) c = a % b;
*/
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the integer from 1 to 99999: ");
        int inputValue = Convert.ToInt32(Console.ReadLine());

        DisplayDigits(inputValue);      //d)
        Console.ReadLine();
    }
    public static void DisplayDigits(int a)   // c)
    {
        int b = 10000;
        int c = 10;
        for (int i = 0; i < 5; i++)
        {
            if (a / b != 0)
            {
                Console.Write("{0}  ", a / b % c);
            }
            b /= 10;
        }
    }
}

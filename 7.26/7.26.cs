/*7.26 (Reversing Digits) Write a method that takes an integer value and returns the number with its digits reversed.
       For example, given the number 7631, the method should return 1367. Incorporate the method into an app that reads a value from the user and displays the result.
 */
using System;
class Program
{
    public static void DisplayReverseDigits(int a)   
    {
        int b = 1;
        int c = 10;
        while(a / b != 0)
        {
            if (a / b != 0)
            {
                Console.Write("{0}", a / b % c);
            }
            b *= 10;
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the integer: ");
        int integer = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Reverse digit is: ");
        DisplayReverseDigits(integer);
        Console.ReadLine();
    }
}

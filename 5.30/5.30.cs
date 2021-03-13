/*5.30 (Palindromes) A palindrome is a sequence of characters that reads the same backward as forward. 
       For example, each of the following five-digit integers is a palindrome: 12321, 55555, 45554 and 11611. 
       Write an app that reads in a five-digit integer and determines whether it’s a palindrome.
       If the number is not five digits long, display an error message and allow the user to enter a new value.
       [Hint: Use the remainder and division operators to pick off the number’s digits one at a time, from right to left.]*/


using System;

class Program
{
    static void Main(string[] args)
    {
        int digit = 0, n1, n2, n4, n5;

        while (digit != -1)
        {
            Console.Write("\nEnter five-digit integer : ");
            digit = Convert.ToInt32(Console.ReadLine());

            if (digit >= 10000)
            {
                if (digit <= 99999)
                {
                    n1 = digit / 10000;
                    n2 = digit / 1000 % 10;
                    n4 = digit / 10 % 10;
                    n5 = digit % 10;

                    if (n1 == n5)
                    {
                        if (n2 == n4)
                            Console.WriteLine("Digit is palindrome");
                    }
                    else
                        Console.WriteLine("Digit is not palindrome");
                }
            }
            else
                Console.WriteLine("Error. You must enter only five-digit integer!");
        }
    }
}

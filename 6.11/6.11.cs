/*6.11(Find the Smallest Value) Write an app that finds the smallest of several integers. Assume
that the first value read specifies the number of values to input from the user.*/

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of values: ");
        int numberOfValues = Convert.ToInt32(Console.ReadLine());
        int smallestValue = 2147483647;

        for (int counter = 1; counter <= numberOfValues; ++counter)
        {
            Console.Write("Enter value: ");
            int inputValue = Convert.ToInt32(Console.ReadLine());
            if (inputValue < smallestValue)
                smallestValue = inputValue;
        }

        Console.WriteLine("Smallest value is: {0}", smallestValue);
        Console.ReadLine();
    }
}
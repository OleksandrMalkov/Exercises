using System;

class LargestInteger
{
    public static void Main(string[] args)
    {
        int counter = 1;
        int number, largest;

        Console.Write("Enter first integer: ");
        largest = Convert.ToInt32(Console.ReadLine());

        while (counter <= 10)
        {
            counter++;
            Console.Write("Enter next integer: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number > largest)
                largest = number;
        }

        Console.Write("\nThe largest number is: {0}", largest);
        Console.ReadKey();
    }
}

/*7.17 (Even or Odd) Write method IsEven that uses the remainder operator (%) to determine
       whether an integer is even. The method should take an integer argument and return true if the integer is even and false otherwise. 
       Incorporate this method into an app that inputs a sequence of integers (one at a time) and determines whether each is even or odd.
 */
using System;

class Program
{
    public static void IsEven(int number)
    {
        bool result = number % 2 == 0;
        Console.Write("{0} is even? - {1}\n", number, result);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter integers to determines if they even or odd\n" +
            "To end type <end> and press Enter");
        while (1==1)
        {
            Console.WriteLine("\nEnter the integer: ");
            string end = Console.ReadLine();
            if (end == "end")
                break;
            else
            {
                int number = Convert.ToInt32(end);
                IsEven(number);
            }
        }
    }
}

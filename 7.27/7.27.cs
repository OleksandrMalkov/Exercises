/*7.27 (Greatest Common Divisor) The greatest common divisor (GCD) of two integers is the largest integer that evenly divides each of the two numbers.
       Write method Gcd that returns the greatest common divisor of two integers. Incorporate the method into an app that reads two values from the user and displays the result.
 */
using System;
class Program
{
    public static int GCD(int num1, int num2)
    {
        int counter = Math.Min(num1, num2);
        int diviner = 1;
        int gcd = 1;
        for (int i = 1; i <= counter; i++)
        {
            if (num1 % diviner == 0 && num2 % diviner == 0)
                gcd = diviner;
            diviner++;
        }
        return gcd;
    }
    static void Main(string[] args)
    {
        Console.Write("Enter first integer: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second integer: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Greatest common divisor is: {0}", GCD(a, b));
        Console.ReadLine();
    }
}

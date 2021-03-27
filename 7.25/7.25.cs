/* 7.25 (Prime Numbers) An integer is said to be prime if it’s greater than 1 and divisible by only 1 and itself. For example, 2, 3, 5 and 7 are prime, but 4, 6, 8 and 9 are not.
        a) Write a method that determines whether a number is prime.
        b) Use this method in an app that displays all the prime numbers less than 10,000.
        c) Initially, you might think that n/2 is the upper limit for which you must test to see whether a number is prime, but you need only go as high as the square root of n.
           Rewrite the app, and run it both ways.
 */
using System;

class Program
{
    public static string DeterminePrime (int input)  // a)
    {
        int divider = 2;
        string prime = "prime";
        for (int i = 1; i < input/2; i++)
        {
            if (input % divider == 0)
                prime = "not prime";
            divider++;
        }
        return prime;
    }
    public static string DeterminePrimeV2(int input)  // c)
    {
        int divider = 2;
        string prime = "prime";
        for (int i = 1; i <= Math.Sqrt(input); i++)
        {
            if (input % divider == 0)
                prime = "not prime";
            divider++;
        }
        if (input == 2)
            prime = "prime";
        return prime;
    }
    static void Main(string[] args)   // b)
    {
        int numbers = 2;
        for (int i = 1; i <= 10000; i++)
        {
            if (DeterminePrime(numbers) == "prime")
                Console.Write("{0} ", numbers);

            numbers++;
        }

        Console.WriteLine();
        numbers = 2;
        for (int i = 1; i <= 10000; i++)
        {
            if (DeterminePrimeV2(numbers) == "prime")
                Console.Write("{0} ", numbers);

            numbers++;
        }
        Console.ReadLine();
    }


}

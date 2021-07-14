/*5.22 (Tabular Output) Write a C# app that uses looping to display the following table of values:
        
        N 10*N 100*N 1000*N
        1 10   100   1000
        2 20   200   2000
        3 30   300   3000
        4 40   400   4000
        5 50   500   5000
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        int number = 0;

        while (number <= 5)
        {
            if (number == 0)
                Console.WriteLine("N  10*N  100*N   1000*N\n");
            else
                Console.WriteLine("{0}  {1}    {2}     {3}", number, number * 10, number * 100, number * 1000);
            
            number++;
        }

        Console.ReadLine();
    }
}


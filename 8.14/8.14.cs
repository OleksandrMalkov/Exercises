/*8.14 (Variable-Length Argument List) Write an app that calculates the product of a series of integers that are passed to method product using a variable-length argument list.
       Test your method with several calls, each with a different number of arguments.
 */
using System;

class Program
{
    public static int SummingInt(params int[] integers)
    {
        int sum = 0;

        foreach (int item in integers)
        {
            sum += item;
        }
        return sum;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(SummingInt(12, 23, 97));
        Console.WriteLine(SummingInt(1,1,1,1,1,1,1));
        Console.WriteLine(SummingInt( 2, 3));
        Console.ReadLine();
    }
}

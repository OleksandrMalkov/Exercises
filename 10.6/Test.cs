using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Test
{
    public static void Main(string[] args)
    {
        Date example = new Date(19,10,1991);
        Console.WriteLine(example.ToString());

        for (int i = 0; i < 30; i++)    //a) adding 30 days (for next month)
        {
            example.NextDay(example);
        }
        Console.WriteLine(example.ToString());

        for (int i = 0; i < 150; i++)       //b) adding 150 days (for next year)
        {
            example.NextDay(example);
        }
        Console.WriteLine(example.ToString());

        Console.ReadLine();
    }
}

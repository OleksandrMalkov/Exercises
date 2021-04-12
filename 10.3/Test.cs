using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Class1
{
    public static void Main(string[] args)
    {
        Rectangle r1 = new Rectangle();  // initializing r1 with default attributes

        Console.WriteLine("r1 length is {0}",r1.Length);
        Console.WriteLine("r1 width is {0}", r1.Width);
        Console.WriteLine("r1 perimeter is {0}", r1.Perimeter);
        Console.WriteLine("r1 area is {0}", r1.Area);
        Console.WriteLine();

        Rectangle r2 = new Rectangle(12.3, 19.1);  // initializing r1 with custom attributes

        Console.WriteLine("r2 length is {0}", r2.Length);
        Console.WriteLine("r2 width is {0}", r2.Width);
        Console.WriteLine("r2 perimeter is {0}", r2.Perimeter);
        Console.WriteLine("r2 area is {0}", r2.Area);
        Console.WriteLine();

        try                                        // initializing r1 with invalid attributes

        {
            Rectangle a = new Rectangle(120, 3);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Exception while initializing a:");
            Console.WriteLine(ex.Message);
        }

        Console.ReadLine();
    }
}

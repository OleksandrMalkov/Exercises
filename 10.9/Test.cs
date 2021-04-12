using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Test
{ 
    public static void Main(string[] args)
    {
        Rational test1 = new Rational(3, 11);
        Rational test2 = new Rational(12);

        Console.WriteLine("test1 fraction is {0}", test1.StringForm(test1));  //e) Display Rational numbers in the form a/b, where a is the numerator and b is the denominator.
        test1.StringForm(test1);
        Console.WriteLine("test2 fraction is {0}",test2.StringForm(test2));
        test2.StringForm(test2);
        Console.WriteLine();
        Console.Write("test1 + test2 = ");  
        test1.Add(test1, test2);                //a) Add two Rational numbers.
        Console.Write("test1 - test2 = ");
        test1.Subtract(test1, test2);           //b) Subtract two Rational numbers.
        Console.Write("test1 * test2 = ");
        test1.Multiply(test1, test2);           //c) Multiply two Rational numbers.
        Console.Write("test1 / test2 = ");
        test1.Divide(test1, test2);             //d) Divide two Rational numbers.
        Console.WriteLine("test1 in floating-point number is: ");
        test1.FloatingPointFormat(test1);       //f) Display Rational numbers in floating-point format. (Consider providing formatting capabilities that enable
                                                //   the user of the class to specify the number of digits of precision to the right of the decimal point.)
        Console.ReadLine();
    }
}

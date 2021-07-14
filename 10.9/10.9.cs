/*10.9 (Rational Numbers) Create a class called Rational for performing arithmetic with fractions. Write an app to test your class.
       Use integer variables to represent the private instance variables of the class—the numerator and the denominator.
       Provide a constructor that enables an object of this class to be initialized when it’s declared. The constructor should store the fraction in reduced form.
       The fraction
            2/4
       is equivalent to 1/2 and would be stored in the object as 1 in the numerator and 2 in the denominator.
       Provide a parameterless constructor with default values in case no initializers are provided. Provide public methods that perform each of the following operations 
       (all calculation results should be stored in a reduced form):
            a) Add two Rational numbers.
            b) Subtract two Rational numbers.
            c) Multiply two Rational numbers.
            d) Divide two Rational numbers.
            e) Display Rational numbers in the form a/b, where a is the numerator and b is the denominator.     
            f) Display Rational numbers in floating-point format.
               (Consider providing formatting capabilities that enable the user of the class to specify the number of digits of precision to the right of the decimal point.)
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Rational
{
    public Rational(int intNumerator = 0, int intDenominator = 1)
    {
        Numenator = intNumerator;
        Denominator = intDenominator;
    }
    public int Numenator { get; set; }
    public int Denominator { get; set; }

    public static int GreatestCommonDivisor(int a, int b)
    {
        if (a > b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        else
        {
            while (a != 0)
            {
                int temp = a;
                a = b % a;
                b = temp;
            }
            return b;
        }
    }
    public static int LowestCommonMultiple(int a, int b)
    {
        return a * b / GreatestCommonDivisor(a, b);
    }



    public  void Add(Rational x, Rational y)   //a) Add two Rational numbers.
    {
        int denom = LowestCommonMultiple(x.Denominator, y.Denominator);
        int FirstMultiplierNumen = denom / x.Denominator;
        int SecondMultiplierNumen = denom / y.Denominator;
        int numen = x.Numenator*FirstMultiplierNumen + y.Numenator*SecondMultiplierNumen;
        Console.WriteLine("{0}/{1}", numen, denom);
    }
    public void Subtract(Rational x, Rational y)    //b) Subtract two Rational numbers.
    {
        int denom = LowestCommonMultiple(x.Denominator, y.Denominator);
        int FirstMultiplierNumen = denom / x.Denominator;
        int SecondMultiplierNumen = denom / y.Denominator;
        int numen = x.Numenator * FirstMultiplierNumen - y.Numenator * SecondMultiplierNumen;
        if (numen < 0)
            denom = -denom;
        Console.WriteLine("{0}/{1}", numen, denom);
    }
    public void Multiply(Rational x, Rational y)    // c) Multiply two Rational numbers.
    {
        int denom = x.Denominator * y.Denominator;
        int numen = x.Numenator * y.Numenator;
        Console.WriteLine("{0}/{1}", numen, denom);
    }
    public void Divide(Rational x, Rational y)  //d) Divide two Rational numbers.
    {
        int denom = x.Denominator * y.Numenator;
        int numen = x.Numenator * y.Denominator;
        Console.WriteLine("{0}/{1}", numen, denom);
    }
    public string StringForm(Rational x)  //e) Display Rational numbers in the form a/b, where a is the numerator and b is the denominator.
    {
        return string.Format("{0}/{1}",x.Numenator,x.Denominator);
    }
    public void FloatingPointFormat(Rational x) //f) Display Rational numbers in floating-point format. (Consider providing formatting capabilities that enable
                                                //   the user of the class to specify the number of digits of precision to the right of the decimal point.)
    {
        Console.WriteLine("Specify the number of digits of precision to the right of the decimal point: ");
        int i = Convert.ToInt32(Console.ReadLine());
        decimal num = (decimal)x.Numenator / (decimal)x.Denominator;
        num = Math.Round(num,i);
        Console.WriteLine( num);
    }
}

/*7.14 (Exponentiation) Write a method IntegerPower( base, exponent ) that returns the value of base exponent
       For example, IntegerPower( 3, 4 ) calculates 34 (or 3*3*3*3). Assume that exponent is a positive integer and that base is an integer.
       Method IntegerPower should use a for or while loop to control the calculation. Do not use any Math-library methods. 
       Incorporate this method into an app that reads integer values for base and exponent and performs the calculation with the IntegerPower method.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    public static int IntegerMethod(int @base, uint exponent)
    {
        int result = @base;
        for ( int counter = 1; counter < exponent; ++counter)
        {
            result *= @base;
        }
        return result;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(IntegerMethod(3, 4));
        Console.ReadLine();
    }
}

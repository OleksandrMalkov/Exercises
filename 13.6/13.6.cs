/*13.6 (Constructor Failure) Exceptions can be used to indicate problems that occur when an object is being constructed.
       Write a program that shows a constructor passing information about constructor failure to an exception handler. 
       The exception thrown also should contain the arguments sent to the constructor.
 */
using System;

class Program
{
    public class ConstructorFailure
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Num3 { get; set; }
        public ConstructorFailure(int a, int b)
        {
            Num1 = a;
            Num2 = b;

            try
            {
                Num3 = a / b;
            }
            catch (DivideByZeroException divideByZeroException)
            {
                Console.WriteLine("You cannot create this object. " +
                    "\nFirst argument is a = {0}" +
                    "\nSecond argument is b = {1}" +
                    "\nThird argument is a / b",a, b);
                Console.WriteLine( divideByZeroException.Message);
                Console.WriteLine("Zero is an invalid denominator.\n");
            }
        }
    }
    static void Main(string[] args)
    {
        ConstructorFailure obj1 = new ConstructorFailure(12, 0);
      
        Console.ReadLine();
    }
}

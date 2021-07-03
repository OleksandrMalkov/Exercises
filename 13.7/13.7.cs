/*13.7 (Rethrowing and Exception) Write a program that demonstrates rethrowing an exception.
 */
using System;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            
            ThrowExceptionCatchRethrow();
            
        }
        catch (Exception exceptionParameter)
        {
            Console.WriteLine("In Main");
            Console.WriteLine("Caught {0} from ThrowExceptionCatchRethrow", exceptionParameter.Message);
        }
        Console.ReadLine();
    }

    public static void ThrowExceptionCatchRethrow()
    {
        try
        {
            Console.WriteLine("In ThrowExceptionCatchRethrow");
            throw new Exception("***Test Exception***");
        }
        catch (Exception exceptionParameter)
        {
            Console.WriteLine("Caught {0} in ThrowExceptionCatchRethrow", exceptionParameter.Message);
            Console.WriteLine("Rethrow {0} from ThrowExceptionCatchRethrow", exceptionParameter.Message);
            throw;   // rethrow exception for further processing
        }
    }
}




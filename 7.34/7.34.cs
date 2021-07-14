/*7.34 (Binary, Octal and Hexadecimal) Write an app that displays a table of the binary, octal,
       and hexadecimal equivalents of the decimal numbers in the range 1–256. If you’re not familiar with
       these number systems, read Appendix D first.
 */
using System;

class Program

{
    static void Main(string[] args)
    {
        int counter = 1;
        Console.WriteLine("Decimal{0,20}",    "Binary");
        for (int i = 1; i <= 256; i++)
        {
            Console.WriteLine("{0,6}{1,20:C}", counter, Binary.DisplayBinary(counter));
            counter++;
        }

        counter = 1;
        Console.WriteLine("\nDecimal{0,20}", "Octal");
        for (int i = 1; i <= 256; i++)
        {
           Console.WriteLine("{0,6}{1,20:C}", counter, Octal.DisplayOctal(counter));
            counter++;
        }

        counter = 1;
        Console.WriteLine("\nDecimal{0,20}", "Hexademical");
        for (int i = 1; i <= 256; i++)
        {
            Console.WriteLine("{0,6}{1,20:C}", counter, Hexademical.DisplayHexademical(counter));
            counter++;
        }
        Console.ReadLine();
    }

   
   
    

}

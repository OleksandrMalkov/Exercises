/*13.10 (FormatExceptions) Create an app that inputs miles driven and gallons used, and calculates miles per gallon.
        The example should use exception handling to process the FormatExceptions that occur when converting the input strings to doubles.
        If invalid data is entered, display a message informing the user.
 */
using System;

class Program
{
    static void Main(string[] args)
    {
        MilesPerGallon milesPerGallon = new MilesPerGallon();
        milesPerGallon.InitMiles();
        milesPerGallon.InitGallons();
        milesPerGallon.InitMilesPerGallons();

        Console.ReadLine();
    }
}


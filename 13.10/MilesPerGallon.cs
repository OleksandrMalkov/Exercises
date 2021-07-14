using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class MilesPerGallon
{
    public double Miles { get; set; }
    public double Gallons { get; set; }
    public double MilesPerGallonVariable { get; set; }

    public void InitMiles()
    {
        bool continueMethod = true;
        while (continueMethod == true)
        {
            try
            {
                Console.Write("Enter driven miles: ");
                Miles = Convert.ToDouble(Console.ReadLine());
                continueMethod = false;
            }
            catch (FormatException)
            {
                Console.WriteLine("Entered value must be floaping-point number" +
                    "\nPlease enter vald value");
            }
        }
    }
    public void InitGallons()
    {
        bool continueMethod = true;
        while (continueMethod == true)
        {
            try
            {
                Console.Write("Enter used gallons: ");
                Gallons = Convert.ToDouble(Console.ReadLine());
                continueMethod = false;
            }
            catch (FormatException)
            {
                Console.WriteLine("Entered value must be floaping-point number" +
                    "\nPlease enter vald value");
            }
        }
    }
    public void InitMilesPerGallons()
    {
        MilesPerGallonVariable = Miles / Gallons;
        Console.WriteLine("Miles per gallon is {0:F}", MilesPerGallonVariable);
    }
}

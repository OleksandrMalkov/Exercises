/*7.32 (Distance Between Two Points) Write method Distance to calculate the distance between two points (x1, y1) and (x2, y2).
       All numbers and return values should be of type double. Incorporate this method into an app that enables the user to enter the coordinates of the points.
 */
using System;

class Program
{
    public static void DistanceCalculation(double x1, double y1, double x2, double y2)
    {
        double resultX = Math.Max(x1, x2) - Math.Min(x1, x2);
        double resultY = Math.Max(y1, y2) - Math.Min(y1, y2);

        Console.WriteLine("Distance between points is x: {0}, y: {1}", resultX, resultY);
    }
    static void Main(string[] args)
    {
        Console.Write("Enter coordinates x of first point: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter coordinates y of first point: ");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter coordinates x of second point: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter coordinates y of second point: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        DistanceCalculation(x1, y1, x2, y2);
        Console.ReadLine();
    }
}

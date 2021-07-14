using System;

public class CommissionCalc
{
    public static void Main(string[] args)
    {
        double total = 0;
        double itemValue;
        double commission;

        Console.Write("Enter item value or -1 to quit: ");
        itemValue = Convert.ToDouble(Console.ReadLine());

        while (itemValue != -1)
        {
            total += itemValue;

            Console.Write("Enter item value or -1 to quit: ");
            itemValue = Convert.ToDouble(Console.ReadLine());
        }

        commission = total * 0.09 + 200;

        Console.WriteLine("\nSalesperson receive: {0:C}", commission);
        Console.ReadLine();
    }
}

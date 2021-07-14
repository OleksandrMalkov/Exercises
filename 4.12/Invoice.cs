using System;

public class Invoice
{
    private int quantity;
    private decimal pricePerItem;

    public string PartNumber { get; set; }
    public string PartDescription { get; set; }

    public int Quantity
    {
        get
        {
            return quantity;
        }
        set
        {
            if (value >= 0)
                quantity = value;
        }
    }

    public decimal PricePerItem
    {
        get
        {
            return pricePerItem;
        }
        set
        {
            if (value >= 0)
                pricePerItem = value;
        }
    }

    public Invoice(string number, string description, int quant, decimal price)
    {
        PartNumber = number;
        PartDescription = description;
        Quantity = quant;
        PricePerItem = price;
    }

    public void Validation()
    {
        Console.WriteLine(
            "Part Number is: {0}\n" +
            "Part Description is: {1}\n" +
            "Quantity is:{2}\n" +
            "Price per Item is:{3}",
            PartNumber, PartDescription, Quantity, pricePerItem); //method for validation
    }

    public decimal GetInvoiceAmount()
    {
        return Quantity * PricePerItem;
    }
}


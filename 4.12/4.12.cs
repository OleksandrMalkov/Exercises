﻿/* 4.12 (Invoice Class) Create a class called Invoice that a hardware store might use to represent an invoice for an item sold at the store.
        An Invoice should include four pieces of information as either instance variables or automatic properties—a part number (type string),
        a part description (type string), a quantity of the item being purchased (type int) and a price per item (decimal).
        Your class should have a constructor that initializes the four values. Provide a property with a get and set accessor for any instance variables. 
        For the Quantity and PricePerItem properties, if the value passed to the set accessor is negative, the value of the instance variable should be left unchanged.
        Also, provide a method named GetInvoiceAmount that calculates the invoice amount (i.e.,multiplies the quantity by the price per item), then returns the amount as a decimal value.
        Write a test app named InvoiceTest that demonstrates class Invoice’s capabilities.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._12
{
    class InvoiceTest
    {
        public static void Main(string[] args)
        {
            Invoice item1 = new Invoice("111a111", "monitor LG model qwer1234", 2, 140.99m);
            Invoice item2 = new Invoice("222b222", "mouse Asus ROG PL2", 12, 95m);

            item1.Validation();
            Console.WriteLine();
            item2.Validation();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Invoice for item1 is: ");
            item1.GetInvoiceAmount();
            Console.WriteLine();
            Console.WriteLine("Invoice for item2 is: ");
            item2.GetInvoiceAmount();
            Console.ReadLine();
        }

    }
}

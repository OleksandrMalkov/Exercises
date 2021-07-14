/*9.5 (Sorting Letters and Removing Duplicates) Write a console app that inserts 30 random letters into a List< char >. Perform the following queries on the List and display your results: 
      [Hint: Strings can be indexed like arrays to access a character at a specific index.]
            a) Use LINQ to sort the List in ascending order.
            b) Use LINQ to sort the List in descending order.
            c) Display the List in ascending order with duplicates removed.
 */
using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        List<char> letters = new List<char>();

        for (int i = 0; i < 30; i++)
        {
            letters.Add((char)rnd.Next('a', 'z'));
        }

        var ascOrder =                      // a)
            from item in letters
            orderby item
            select item;

        var desOrder =                      // b)
            from item in letters
            orderby item descending
            select item;

        foreach (var item in ascOrder.Distinct())    // c)
        {
            Console.WriteLine(item);
        }
        Console.ReadLine();
    }
}

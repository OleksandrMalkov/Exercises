/*9.4 (Duplicate Word Removal) Write a console app that inputs a sentence from the user (assume no punctuation), then determines and displays the nonduplicate words in alphabetical order.
      Treat uppercase and lowercase letters the same. 
      [Hint: You can use string method Split with no arguments, as in sentence. Split(), to break a sentence into an array of strings containing the individual words.
      By default, Split uses spaces as delimiters. Use string method ToLower in the select and orderby clauses of your LINQ query to obtain the lowercase version of each word.]
 */
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a sentence (without punctuation): ");
        string input = Console.ReadLine();

        string[] sentence = input.Split();

        var filtered =
            from e in sentence
            orderby e
            select e.ToLower();

        Console.WriteLine("\nNonduplicate words in alphabetical order: ");
        foreach (var item in filtered.Distinct() )
        {
            Console.WriteLine(item);
        }
        Console.ReadLine();
    }
}

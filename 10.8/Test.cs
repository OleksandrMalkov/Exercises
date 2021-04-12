using System;

class Test
{
    public static void Main(string[] args)
    {
        IntegerSet n1 = new IntegerSet(2);
        IntegerSet n2 = new IntegerSet(2);

        n1.Initializing();
        Console.WriteLine();
        n2.Initializing();
        Console.WriteLine();

        IntegerSet n3 = n1.Union(n1,n2);                        // Testing method Union
        IntegerSet n4 = n1.Intersection(n1, n2);                // Testing Method Intersection

        n3.ToString(n3);                                        // Testing method ToString
        Console.WriteLine();
        n4.ToString(n4);

        n1.InsertElement(n1, 15);                               // Testing Method InsertElement

        IntegerSet n5 = n1.Union(n1, n2);
        IntegerSet n6 = n1.Intersection(n1, n2);

        n5.ToString(n5);
        Console.WriteLine();
        n6.ToString(n6);

        n1.DeleteElement(n1, 15);                               //Testing Method DeleteElement

        IntegerSet n8 = n1.Union(n1, n2);
        IntegerSet n9 = n1.Intersection(n1, n2);

        n8.ToString(n8);
        Console.WriteLine();
        n9.ToString(n9);

        n1.IsEqualTo(n1, n2);                                   // Testing method IsEqualTo

        Console.ReadLine();
    }
}

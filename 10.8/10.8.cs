/*10.8 (Set of Integers) Create class IntegerSet. Each IntegerSet object can hold integers in the range 0–100. The set is represented by an array of bools.
       Array element a[i] is true if integer i is in the set. Array element a[j] is false if integer j is not in the set. 
       The parameterless constructor initializes the array to the “empty set” (i.e., a set whose array representation contains all false values).
       Provide the following methods:
            a) Method Union creates a third set that’s the set-theoretic union of two existing sets 
               (i.e., an element of the third set’s array is set to true if that element is true in either or both of the existing sets—otherwise, the element of the third set is set to false).
            b) Method Intersection creates a third set which is the set-theoretic intersection of two existing sets 
               (i.e., an element of the third set’s array is set to false if that element is false in either or both of the existing sets—otherwise, the element of the third set is set to true).
            c) Method InsertElement inserts a new integer k into a set (by setting a[k] to true).
            d) Method DeleteElement deletes integer m (by setting a[m] to false).
            e) Method ToString returns a string containing a set as a list of numbers separated by spaces.
               Include only those elements that are present in the set. Use --- to represent an empty set.
            f) Method IsEqualTo determines whether two sets are equal.
        Write an app to test class IntegerSet. Instantiate several IntegerSet objects. Test that all your methods work properly.
 */
using System;

class IntegerSet
{
    private int[] integerArray;
    private bool[] boolArray = new bool[101];


    public int Length { get; set; }

    public IntegerSet(int length)
    {
        Length = length;
        integerArray = new int[Length];
    }
    public void Initializing()
    {
        int value;
        for (int i = 0; i < Length; i++)
        {
            Console.WriteLine("Enter integer[{0}] value (between 0-100): ", i);
            value = Convert.ToInt32(Console.ReadLine());
            if (value > 0 && value <= 100)
                integerArray[i] = value;
            else
            {
                Console.WriteLine("Value must be between 0-100!");
                i--;
            }
        }

        for (int y = 0; y < integerArray.Length; y++)
        {
            boolArray[integerArray[y]] = true;
        }
    }


    public int Max(int[] a, int[] b)
    {
        int maxLength;
        if (a.Length <= b.Length)
        {
            maxLength = b.Length;
        }
        else
        {
            maxLength = a.Length;
        }
        return maxLength;
    }

    public IntegerSet Union(IntegerSet a, IntegerSet b)
    {

        IntegerSet c = new IntegerSet(Max(a.integerArray, b.integerArray));

        for (int i = 0; i < 101; i++)
        {
            if (a.boolArray[i] == true || b.boolArray[i] == true)
                c.boolArray[i] = true;
        }
        return c;
    }


    public IntegerSet Intersection(IntegerSet a, IntegerSet b)
    {

        IntegerSet c = new IntegerSet(Max(a.integerArray, b.integerArray)); ;

        for (int i = 0; i < 101; i++)
        {
            if (a.boolArray[i] == false || b.boolArray[i] == false)
                c.boolArray[i] = false;
            else
                c.boolArray[i] = true;
        }
        return c;
    }
    public void InsertElement(IntegerSet a, uint num)
    {
        if (a.boolArray.Length > num)
            a.boolArray[num] = true;
        else
            Console.WriteLine("Insert element dont exist in array" );
    }
    public void DeleteElement(IntegerSet a, uint num)
    {
        if (a.boolArray.Length > num)
            a.boolArray[num] = false;
        else
            Console.WriteLine("Insert element dont exist in {0} array", a);
    }

    public void ToString(IntegerSet a)
    {
        for (int i = 0; i < 101; i++)
        {
            if (a.boolArray[i] == false)
                Console.Write(" --- ");
            else
                Console.Write("{0,4} ", i);
            if (i % 10 == 0)
                Console.WriteLine();
        }
    }
    public void IsEqualTo(IntegerSet a, IntegerSet b)
    {
        Console.WriteLine("Sets equal in: ");
        for (int i = 0; i < 101; i++)
        {
            if (a.boolArray[i] == b.boolArray[i])
                Console.Write("{0,3} ", i);
            else
                Console.Write("--- ");
            if (i % 10 == 0)
                Console.WriteLine();
        }
    }
}

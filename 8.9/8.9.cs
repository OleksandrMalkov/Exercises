/*8.9 
Consider the two-by-three rectangular integer array t.
a) Write a statement that declares t and creates the array.
b) How many rows does t have?
c) How many columns does t have?
d) How many elements does t have?
e) Write the names of all the elements in row 1 of t.
f) Write the names of all the elements in column 2 of t.
g) Write a single statement that sets the element of t in row 0 and column 1 to zero.
h) Write a sequence of statements that initializes each element of t to 1. Do not use a repetition statement.
i) Write a nested for statement that initializes each element of t to 3.
j) Write a nested for statement that inputs values for the elements of t from the user.
k) Write a sequence of statements that determines and displays the smallest value in t.
l) Write a statement that displays the elements of row 0 of t.
m) Write a statement that totals the elements of column 2 of t.
n) Write a sequence of statements that displays the contents of t in tabular format. List the
   column indices as headings across the top, and list the row indices at the left of each row.

Answers:

a) int[,] t = new int[2, 3];
b) t have 2 rows
c) t have 3 collumns
d) t have 6 elements
e) t[0,0], t[0,1], t[0,2]
f) t{1,0], t[1,1], t[1,2]
g) t[0,0] = 0;
h) t[0,1] = 1;
   t[0,2] = 1; 
   t[1,0] = 1;
   t[1,1] = 1;
   t[1,2] = 1;
 i) for (int row = 0; row < t.GetLength(0); row++)
        {
            for (int column = 0; column < t.GetLength(1); column++)
            {
                t[row, column] = 3;
            }
        }
j)  for (int row = 0; row < t.GetLength(0); row++)
        {
            for (int column = 0; column < t.GetLength(1); column++)
            {
                Console.WriteLine(t[row, column]);
            }
        }

k) int lowValue = t[0];
   foreach (double elem in w)
   {
    if (elem < lowValue)
    lowValue = elem;
   }
   Console.WriteLine( lowValue );

l)for (int column = 0; column < t.GetLength(1); ++column)
  {
       Console.WriteLine(t[0,column]);
  }

m)int total = 0;
  for (int row = 0; row < t.GetLength(0); ++row)
  {
       total += t[row, 1];
  }

n) Console.Write("       ");
        for (int headerColumn = 0; headerColumn < t.GetLength(1); ++headerColumn)
            Console.Write("Column {0} ", headerColumn + 1);
        Console.WriteLine();

        for (int row = 0; row < t.GetLength(0); ++row)
        {
            Console.Write("Row {0,-2} ", row);

            for (int column = 0; column < t.GetLength(1); ++column)
                Console.Write("{0,-9}", t[row, column]);
            Console.WriteLine();
        }
 */
using System;

    class Program
    {
        static void Main(string[] args)
        {
        int[,] t = { { 12, 3, 2 }, { 10, 6, 9 } };
        Console.Write("       ");
        for (int headerColumn = 0; headerColumn < t.GetLength(1); ++headerColumn)
            Console.Write("Column {0} ", headerColumn + 1);
        Console.WriteLine();

        for (int row = 0; row < t.GetLength(0); ++row)
        {
            Console.Write("Row {0,-2} ", row);

            for (int column = 0; column < t.GetLength(1); ++column)
                Console.Write("{0,-9}", t[row, column]);
            Console.WriteLine();
        }
        
            Console.ReadLine();
        }
    }

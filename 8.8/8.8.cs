/*  8.8 Write C# statements to accomplish each of the following tasks:
        a) Display the value of the element of character array f with index 6.
        b) Initialize each of the five elements of one-dimensional integer array g to 8.
        c) Total the 100 elements of floating-point array c.
        d) Copy 11-element array a into the first portion of array b, which contains 34 elements.
        e) Determine and display the smallest and largest values contained in 99-element floatingpoint array w.

Answers:

a) Console.Write( f[6] );

b) for (int i = 0; i < f.Length; ++i)
       f[i] = 8;

c) double total = 0;
   for (int i = 0; i < 100; i++)
   {
    total += c[i];
   }

d) for (int i = 0; i < 11; ++i)
       b[i] = a[i];

c) double highValue = w[0];
   double lowValue = w[0];

   foreach (double elem in w)
   {
    if (elem > highValue)
    highValue = elem; 
   }

   foreach (double elem in w)
   {
    if (elem < lowValue)
    lowValue = elem;
   }

   Console.WriteLine("Highest value is: {0}\n"+
                     "LowestValue is: {1}", highValue, lowValue);
*/
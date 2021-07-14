/*5.16 (What Does This Program Do?) What does the following app display?
  
// Ex. 5.16: Mystery.cs
using System;

public class Mystery
{
    public static void Main(string[] args)
       {
         int y;
         int x = 1;
         int total = 0;
        
         while (x <= 10)
            {
               y = x * x;
               Console.WriteLine( y );
               total += y;
                ++x;
            } // end while
 
         Console.WriteLine( "Total is {0}", total );
      } // end Main
} // end class Mystery  

Answer:

This app displays square of numbers from 1 to 10(each next in new line) and the total sum of them.
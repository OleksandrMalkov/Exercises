/*5.25 (What Does This Program Do?) What does the following app display?

1 // Ex. 5.25: Mystery2.cs
2 using System;
3
4 public class Mystery2
5 {
6   public static void Main( string[] args )
7       {
8        int count = 1;
9
10       while ( count <= 10 )
11          {
12           Console.WriteLine( count % 2 == 1 ? "****" : "++++++++" );
13           ++count;
14           } // end while
15      } // end Main
16 } // end class Mystery2 

Answer:

This app displays **** in first line(because сondition is satisfied),  ++++++++ in next line(because сondition isn`t satisfied) and repeat it 5 times.



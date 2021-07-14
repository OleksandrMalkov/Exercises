/* 6.10 (What Does This Code Do?) What does the following app do?
        
// Exercise 6.10 Solution: Printing.cs
using System;

public class Printing
{
    public static void Main( string[] args )
    {
         for ( int i = 1; i <= 10; ++i )
         {
             for ( int j = 1; j <= 5; ++j )
                Console.Write( '@' );

             Console.WriteLine();
         } // end outer for
    } // end Main
} // end class Printing

Answer: 

This app display:

@@@@@
@@@@@
@@@@@
@@@@@
@@@@@
@@@@@
@@@@@
@@@@@
@@@@@
@@@@@

Loop for is executed 10 times according to its parameters.
In each itereation of the loop is executed statement for from the body of the loop and positions the screen cursor at the beginning of the next line( according to method WriteLine ). 
Statement for from the body is executed  5 times according to its parameters and in each iteration is displayed characters @.    */
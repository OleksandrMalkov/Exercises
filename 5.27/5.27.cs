/*5.27 (Dangling-else Problem) Determine the output for each of the given sets of code when x
       is 9 and y is 11 and when x is 11 and y is 9. The compiler ignores the indentation in a C# app. Also, the C# compiler always associates an else
       with the immediately preceding if unless told to do otherwise by the placement of braces ({}). On first glance, you may not be sure which if an else
       matches—this situation is referred to as the “dangling-else problem.” We’ve eliminated the indentation from the following code to make the problem more challenging.
       [Hint: Apply the indentation conventions you’ve learned.]

a)  if (x< 10 )
    if (y> 10 )
    Console.WriteLine( "*****" );
    else
    Console.WriteLine( "#####" );
    Console.WriteLine( "$$$$$" );

b)  if (x< 10 )
    {
    if (y> 10 )
    Console.WriteLine( "*****" );
    }
    else
    {
    Console.WriteLine( "#####" );
    Console.WriteLine( "$$$$$" );
    }

Answer:
 
a) Compiler interprets the statements as: 
   
    if (x< 10 )
        if (y> 10 )
            Console.WriteLine( "*****" );
        else
            Console.WriteLine( "#####" );
    Console.WriteLine( "$$$$$" );

    So, if x = 9 and y = 11 this set of code output as: 

******
$$$$$$

    If x = 11 and y = 9 this set of code output as:

$$$$$

b) Compiler interprets the statements as:
    
    if (x< 10 )
       {
        if (y> 10 )
           Console.WriteLine( "*****" );
       }
    else
       {
        Console.WriteLine( "#####" );
        Console.WriteLine( "$$$$$" );
       }

    So, if x = 9 and y = 11 this set of code output as:

*****

    If x = 11 and y = 9 this set of code output as:

#####
$$$$$


*/

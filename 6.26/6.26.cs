/*6.26 (What Does This Code Do?) What does the following code segment do?
       
       for ( int i = 1; i <= 5; ++i )
       {
            for ( int j = 1; j <= 3; ++j )
            {
                for ( int k = 1; k <= 4; ++k )
                    Console.Write( '*' );
                Console.WriteLine();
            } // end middle for
            Console.WriteLine();
       } // end outer for     


Answer: 
 
This app have only two output statements:
    - Console.Write( '*' ); - is performed every loop iteration in loop for ( int k = 1; k <= 4; ++k )
    - Console.WriteLine();  - is performed every loop iteration in loop for ( int j = 1; j <= 3; ++j )

Loop for ( int k = 1; k <= 4; ++k ) is performed 4 times, so it display 
****
Loop for ( int j = 1; j <= 3; ++j ) execute nested loop for ( int k = 1; k <= 4; ++k ) 3 times and then execute Console.WriteLine();, so it display
****
****
****

Loop for ( int i = 1; i <= 5; ++i ) execute nested loop for ( int j = 1; j <= 3; ++j ) 5 times, so it display
****
****
****
 
****
****
****
 
****
****
****
 
****
****
****
 
****
****
****
 
*/
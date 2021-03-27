/*6.9 Find and correct the error(s) in each of the following segments of code:
      a) For (i= 100, i >= 1, ++i )
            Console.WriteLine( i );
      
      b) The following code should display whether integer value is odd or even:
            switch ( value % 2 )
            {
             case 0:
                Console.WriteLine( "Even integer" );
             case 1:
                Console.WriteLine( "Odd integer" );
            } // end switch
      
      c) The following code should output the odd integers from 19 to 1:
            for ( int i = 19; i >= 1; i += 2 )
                Console.WriteLine( i );
      d) The following code should output the even integers from 2 to 100:
            counter = 2;
            do
            {
             Console.WriteLine( counter );
             counter += 2;
            } While ( counter < 100 );

Answers:

    a) Error: Keyword for should be written with lower letter.
       Correction: Write for with lower letter.
       Error: In for statement should be used semicolon separator, not comma.
       Correction: Replace comma separator with semicolon separator.
      

    b) Error: case statements should include break statement for correct work switch statement.
       Correction: Add break statement to each case.

    c) Error: In for statement is used wrong increment (it add 2 to i every iteration of the loop).
       Correction: Replace increment i +== 2 with decrement i -=2.

    e) Error: In initialization of variable counter should be indicated type of variable.
       Correction: Add type int to statement counter = 2.
       Error: Condition counter < 100 means that loop will be terminated before counter will be equal to 100.
       Correction: Replace operator < with operator <=.
       Error: Keyword while should be written with lower letter.
       Correction: Write while with lower letter.    */
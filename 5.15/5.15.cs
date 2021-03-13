/* 5.15(Find the Error) Identify and correct the errors in each of the following pieces of code.
       [Note: There may be more than one error in each piece of code.]

a) if (age >= 65) ;                                                                                       
      Console.WriteLine("Age greater than or equal to 65");
   else
      Console.WriteLine("Age is less than 65 )";              

b) int x = 1, total;
   while (x <= 10)
   {
    total += x;
    ++x;
   }

c) while (x <= 100)
      total += x;
      ++x;

d) while (y > 0)
  {
    Console.WriteLine(y);
    ++y;

Answers:

   a) Error: The semicolon after if condition makes statement complete, so compiler considers next lines as another statements.
      Correction: Remove the semicolon after if condition.
      Error: The quotation mark after right parenthese is out of place and makes logic error.
      Correction: Move quotation mark before right parenthese.
   b) Error: Local variable total can`t be used without initializing.
      Correction: Initialize variable total.
   c) Error: Statement ++y isn`t situated in body of repetition while and as result loop while is infinite.
      Correction: Add braces to loop body or use single line statement ( total += x++; ).
   d) Error: The closing right brace of the while statement’s body is missing.
      Correction: Add a closing right brace after the statement ++y;.  */
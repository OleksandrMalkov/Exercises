/* 7.37 (What Does This Code Do?) What does the following method do?
        // Parameter b must be positive to prevent infinite recursion
        public static int Mystery( int a, int b )
        {
            if ( b == 1 )
               return a;
            else
               return a + Mystery( a, b - 1 );
 
 Answer:

This method obtains two integers(a and b) and returns one integer. If b is 1, method returns value of a. But if b has another positive integer value,
method calls itself with decrement value of b and adding result to a until b will be 1. After method returns result of a.

 
 */

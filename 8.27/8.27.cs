/*8.27 (Sieve of Eratosthenes) A prime number is any integer greater than 1 that’s evenly divisible only by itself and 1.
       The Sieve of Eratosthenes finds prime numbers. It operates as follows: 
            a) Create a simple type bool array with all elements initialized to true. Array elements with prime indices will remain true.
               All other array elements will eventually be set to false.
            b) Starting with array index 2, determine whether a given element is true. If so, loop through the remainder of the array and set to false every element
               whose index is a multiple of the index for the element with value true. Then continue the process with the next element with value true.
               For array index 2, all elements beyond element 2 in the array with indices that are multiples of 2 (indices 4, 6, 8, 10, etc.) will be set to false;
               for array index 3, all elements beyond element 3 in the array with indices that are multiples of 3 (indices 6, 9, 12, 15, etc.) will be set to false; and so on.
       When this process completes, the array elements that are still true indicate that the index is a prime number. These indices can be displayed.
       Write an app that uses an array of 1000 elements to determine and display the prime numbers between 2 and 999. Ignore elements 0 and 1.
 */
using System;
class Program
{
    static void Main(string[] args)
    {
        bool[] prime = new bool[1000];

        for (int i = 0; i < prime.Length; i++)
        {
            prime[i] = true;
        }
        for (int b = 2; b * b <= prime.Length; b++)
        {
            if (prime [b] == true)
            {
                for (int c = b*b; c < prime.Length; c+= b)
                {
                    prime[c] = false;
                }
            }
        }

        for (int elem = 2; elem < prime.Length; elem++)
        {
            if (prime[elem] == true)
                Console.Write("{0},", elem );
        }
        Console.ReadLine();
    }
}


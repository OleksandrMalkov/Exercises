/*6.21 (Pythagorean Triples) A right triangle can have sides whose lengths are all integers. 
       The set of three integer values for the lengths of the sides of a right triangle is called a Pythagorean triple (en.wikipedia.org/wiki/Pythagorean_triple).
       The lengths of the three sides must satisfy the relationship that the sum of the squares of two of the sides is equal to the square of the hypotenuse.
       Write an app to find all Pythagorean triples for side1, side2 and the hypotenuse, all no larger than 500.
       Use a triple-nested for loop that tries all possibilities. This method is an example of “bruteforce” computing. 
       You’ll learn in more advanced computer science courses that there are many interesting problems for which there’s no known algorithmic approach other than using sheer brute force.  */

using System;

class Program
{
    static void Main(string[] args)
    {

        // side1*side1 + side2*side2 = hypotenuse*hypotenuse
        for (int hypotenuse = 1; hypotenuse <= 500; hypotenuse++)
        {
            for (int side1 = 1; side1 <= 500; side1++)
            {
                for (int side2 = 1; side2 <= 500; side2++)
                {
                    if (side1 * side1 + side2 * side2 == hypotenuse * hypotenuse)
                    {
                        Console.WriteLine("{0} * {0} + {1} * {1} = {2} * {2}", side1, side2, hypotenuse );
                    }
                }
            }
        }
        Console.ReadLine();
    }
}

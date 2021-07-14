/*20.8 (Overloading a Generic Method) Overload generic method DisplayArray of Fig. 20.3 so that it takes two additional int arguments: lowIndex and highIndex.
       A call to this method displays only the designated portion of the array. Validate lowIndex and highIndex. If either is out of range,
       or if highIndex is less than or equal to lowIndex, the overloaded DisplayArray method should throw an IndexOutOfRangeException; otherwise, DisplayArray should
       return the number of elements displayed. Then modify Main to exercise both versions of DisplayArray on arrays intArray, doubleArray and charArray. 
       Test all capabilities of both versions of DisplayArray.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_8
{
    class Program
    {
        public static void Main(string[] args)
        {
            // create arrays of int, double and char
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

            Console.Write("Array intArray contains: ");
            DisplayArray(intArray); // pass an int array argument
            Console.Write("Array doubleArray contains: ");
            DisplayArray(doubleArray); // pass a double array argument
            Console.Write("Array charArray contains: ");
            DisplayArray(charArray); // pass a char array argument

            Console.Write("Array intArray in range from 2 to 4 contains: ");
            DisplayArray(intArray, 2, 4); // pass an int array argument in range from 2 to 4
            Console.Write("Array doubleArray in range from 2 to 4 contains: ");
            DisplayArray(doubleArray, 2, 4); // pass a double array argument in range from 2 to 4
            Console.Write("Array charArray in range from 2 to 4 contains: ");
            DisplayArray(charArray, 2, 4); // pass a char array argument in range from 2 to 4
            try
            {
                Console.Write("Array intArray in range from 2 to 10 contains: ");
                DisplayArray(intArray, 2, 10); // pass an int array argument in range from 2 to 10
                Console.Write("Array doubleArray in range from -5 to 4 contains: ");
                DisplayArray(doubleArray, -5, 4); // pass a double array argument in range from -5 to 4
                Console.Write("Array charArray in range from 5 to 4 contains: ");
                DisplayArray(charArray, 5, 4); // pass a char array argument in range from 5 to 4
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("\nHigh index must be bigger that low index or low or high index is out of array range");
            }
            try
            {
                Console.Write("Array doubleArray in range from -5 to 4 contains: ");
                DisplayArray(doubleArray, -5, 4); // pass a double array argument in range from -5 to 4
                
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("\nHigh index must be bigger that low index or low or high index is out of array range");
            }
            try
            {
                Console.Write("Array charArray in range from 5 to 4 contains: ");
                DisplayArray(charArray, 5, 4); // pass a char array argument in range from 5 to 4
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("\nHigh index must be bigger that low index or low or high index is out of array range");
            }
            Console.ReadLine();
        }

        // output array of all types                           
        private static void DisplayArray<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }
        private static void DisplayArray<T>(T[] inputArray, int lowIndex, int highIndex)
        {
            if (highIndex <= lowIndex)
            {
               
                throw new IndexOutOfRangeException();
            }
            else if (lowIndex < 0 || highIndex > inputArray.Length - 1)
            {
               
                throw new IndexOutOfRangeException();
            }
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                if (lowIndex >= i ^ highIndex <= i)
                {
                    Console.Write($"{inputArray[i]} ");
                }
            }

            Console.WriteLine();
        }
    }
}

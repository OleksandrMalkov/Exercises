/*20.7 (Generic Linear Search Method) Write a generic method, Search, that implements the linear-search algorithm. Method Search should compare the search key with each element
       in its array parameter until the search key is found or until the end of the array is reached. If the search key is found, return its location in the array;
       otherwise, return -1. Write a test app that inputs and searches an int array and a double array. Provide buttons that the user can click to randomly generate int
       and double values. Display the generated values in a TextBox, so the user knows what values they can search for [Hint: Use (T : IComparable< T >) in the where clause for
       method Search so that you can use method CompareTo to compare the search key to the elements in the array.]*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._7
{
    class Program
    {
        static void Main(string[] args)
        {

            var generator = new Random();
            var intArray = new int[10];

            for (var i = 0; i < intArray.Length; ++i)
            {
                intArray[i] = generator.Next(10, 100);
            }

            Console.WriteLine(string.Join(" ", intArray) + "\n"); // display array

            // input first int from user
            Console.Write("Enter an integer value (-1 to quit): ");
            var searchInt = int.Parse(Console.ReadLine());

            // repeatedly input an integer; -1 terminates the app
            while (searchInt != -1)
            {
                // perform linear search
                int position = GenericLinearSearch(intArray, searchInt);

                if (position != -1) // integer was found
                {
                    Console.WriteLine($"The integer {searchInt} was found in " +
                       $"position {position}.\n");
                }
                else // integer was not found
                {
                    Console.WriteLine(
                       $"The integer {searchInt} was not found.\n");
                }

                // input next int from user
                Console.Write("Enter an integer value (-1 to quit): ");
                searchInt = int.Parse(Console.ReadLine());
            }

            var doubleArray = new double[10];
            for (var i = 0; i < intArray.Length; ++i)
            {
                doubleArray[i] = Math.Round((generator.NextDouble() * (10.00 - 100.00) + 100.00), 2);
            }
            Console.WriteLine(string.Join(" ", doubleArray) + "\n");

            Console.Write("Enter an double-precision floating-point number (-1 to quit): ");
            var searchDouble = double.Parse(Console.ReadLine());

            while (searchDouble != -1)
            {
                // perform linear search
                int position = GenericLinearSearch(doubleArray, searchDouble);

                if (position != -1) // double was found
                {
                    Console.WriteLine($"The double {searchDouble} was found in " +
                       $"position {position}.\n");
                }
                else // double was not found
                {
                    Console.WriteLine(
                       $"The double {searchDouble} was not found.\n");
                }

                // input next double from user
                Console.Write("Enter an double-precision floating-point number (-1 to quit): ");
                searchDouble = double.Parse(Console.ReadLine());
            }
        }


        public static int GenericLinearSearch<T>(T[] values, T searchKey)
        where T : IComparable<T>
        {
            // loop through array sequentially

            for (var i = 0; i < values.Length; ++i)
            {
                if (values[i].CompareTo(searchKey) == 0)
                {
                    return i; // return the element's index       
                }
            }

            return -1; //value was not found                     
        }
    }
}


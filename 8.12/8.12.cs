/*8.12 (Duplicate Elimination) Use a one-dimensional array to solve the following problem:
        Write an app that inputs five numbers, each of which is between 10 and 100, inclusive. As each number is read,
        display it only if it’s not a duplicate of a number already read. Provide for the “worst case,” in which all five numbers are different.
        Use the smallest possible array to solve this problem. Display the complete set of unique values input after the user inputs each new value.
 */
using System;

class Program
{
    static void Main(string[] args)
    {
        int counter = 0;
        int[] array = new int[5];
        bool dublCheck = true;

        while (counter < 5)
        {
            Console.Write("Enter number between 10 and 100, inclusive: ");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input >= 10 && input <= 100)
            {
                foreach (int dubl in array)     //begin cheсk for dublicate
                {
                    if (input == dubl)
                        dublCheck = false;

                }
                if (dublCheck == true)               
                {
                    array[counter] = input;   
                    counter++;                  //add counter by 1 if there is no dublicates
                }                               //end check for dublicate
                foreach (int elem in array)
                {
                    if (elem != 0)
                        Console.WriteLine(elem);
                }
            }
            else
                Console.WriteLine("Error! Enter correct number");
        }
        Console.ReadLine();
    }

}

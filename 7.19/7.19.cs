/*7.19 (Displaying a Square of Any Character) Modify the method created in Exercise 7.18 to
       form the square out of whatever character is contained in character parameter FillCharacter.
       Thus, if side is 5 and FillCharacter is '#', the method should display

#####
#####
#####
#####
#####

[Hint: Use the expression Convert.ToChar(Console.Read()) to read a character from the user.]
 */
using System;
class Program
{

    static void Main(string[] args)
    {
        Console.Write("Enter parameter side: ");
        int inputSide = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter fill character: ");
        char inputChar = Convert.ToChar(Console.ReadLine());

        SquareOfAsterics(inputSide, inputChar);
        Console.ReadLine();
    }
    public static void SquareOfAsterics(int side, char fillCharacter)
    {
        for (int counter1 = 1; counter1 <= side; counter1++)
        {
            for (int counter2 = 1; counter2 <= side; counter2++)
                Console.Write("{0}", fillCharacter);
            Console.WriteLine();
        }
    }
}

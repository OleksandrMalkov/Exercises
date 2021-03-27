/*6.15 (Displaying Triangles) Write an app that displays the following patterns separately, one below the other. Use for loops to generate the patterns. All asterisks (*) should be displayed by a single
statement of the form Console.Write( '*' ); which causes the asterisks to display side by side. A
statement of the form Console.WriteLine(); can be used to move to the next line. A statement of
the form Console.Write( ' ' ); can be used to display a space for the last two patterns. There
should be no other output statements in the app. [Hint: The last two patterns require that each line
begin with an appropriate number of blank spaces.]

(a)          (b)         (c)         (d)
*            **********  **********             *
**           *********    *********            **
***          ********      ********           ***
****         *******        *******          ****
*****        ******          ******         *****
******       *****            *****        ******
*******      ****              ****       *******
********     ***                ***      ********
*********    **                  **     *********
**********   *                    *    **********             */

using System;

class Program
{
    static void Main(string[] args)
    {
        //Fig a
        int asteriskCounter = 0;
        int nextLine = 1;
        for (int counter = 0; counter < 55; ++counter)
        {
            Console.Write('*');
            asteriskCounter++;

            if (asteriskCounter == nextLine)
            {
                Console.WriteLine();
                nextLine++;
                asteriskCounter = 0;
            }

        }

        //Fig b
        nextLine = 10;
        for (int counter = 0; counter < 55; ++counter)
        {
            Console.Write('*');
            asteriskCounter++;

            if (asteriskCounter == nextLine)
            {
                Console.WriteLine();
                nextLine--;
                asteriskCounter = 0;
            }

        }
       
        //Fig c
        nextLine = 10;
        int lineCounter = 0;
        int whileLoopCounter; 
        for (int counter = 0; counter < 55; ++counter)
        {
            Console.Write('*');
            asteriskCounter++;

            if (asteriskCounter == nextLine && nextLine!= 1)
            {
                Console.WriteLine();
                lineCounter++;
                whileLoopCounter = 0;
                while (lineCounter > whileLoopCounter)// Indent
                {
                    Console.Write(' ');
                    whileLoopCounter++;
                }
                nextLine--;
                asteriskCounter = 0;
            }

        }
        Console.WriteLine();
        
        //Fig d
        nextLine = 1;
        lineCounter = 0;
        asteriskCounter = 0;

        for (int counter = 0; counter < 55; ++counter)
        {
            if (nextLine == 1) // Need for first line indent
            {
                int x = 0;
                while (x < 9)
                {
                    Console.Write(' ');
                    x++;
                }
            }

            Console.Write('*');
            asteriskCounter++;

            if (asteriskCounter == nextLine)
            {
                Console.WriteLine();
                lineCounter++;
                whileLoopCounter = 9;
                while (lineCounter < whileLoopCounter)// Indent
                {
                    Console.Write(' ');
                    whileLoopCounter--;
                }
                nextLine++;
                asteriskCounter = 0;
            }

        }
        Console.ReadLine();
    }
}

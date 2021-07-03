/*19.4 (Reversing a Line of Text with a Stack) Write a program that inputs a line of text and uses a stack object to display the line reversed*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text to reverse: ");
            string input = Console.ReadLine();
            string [] inputText = input.Split(' ');

            Stack ToReverse = new Stack();

            foreach (string item in inputText)
            {
                ToReverse.Push(item);
            }

            Console.WriteLine("Reverse text is: ");

            ToReverse.Display();

            Console.ReadLine();
        }
    }
}

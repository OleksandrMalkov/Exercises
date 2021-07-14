//21.16 (Reversing a LinkedList) Write an app that creates a LinkedList object of 10 characters, then creates a second list object containing a copy of the first list, but in reverse order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._16
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<char> list = new LinkedList<char>();
            LinkedList<char> reversed = new LinkedList<char>();

            list.AddFirst('0');
            list.AddFirst('1');
            list.AddFirst('2');
            list.AddFirst('3');
            list.AddFirst('4');
            list.AddFirst('5');
            list.AddFirst('6');
            list.AddFirst('7');
            list.AddFirst('8');
            list.AddFirst('9');

            foreach (var item in list)
            {
                reversed.AddFirst(item);
            }

            Console.WriteLine("List contains: ");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Reversed list contains: ");
            foreach (var item in reversed)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}

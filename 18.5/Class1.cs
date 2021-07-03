using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._5
{
    class Class1
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }

            foreach (var item in array)
            {
                Console.Write(item);
                Console.Write(' ');
            }
            
            Console.WriteLine();
            
            Program.BubbleSort(array);

            foreach (var item in array)
            {
                Console.Write(item);
                Console.Write(' ');
            }
            Console.ReadLine();
        }
    }
}

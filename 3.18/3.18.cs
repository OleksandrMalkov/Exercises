/* 
3.18 (Displaying Shapes with Asterisks) Write an app that displays a box, an oval, an arrow and
     a diamond using asterisks (*), as follows: 
*/
using System;

namespace _3._16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "*********    ***       *        *\n" +
                "*       *  *     *    ***      * *\n" +
                "*       * *       *  *****    *   *\n" +
                "*       * *       *    *     *     *\n" +
                "*       * *       *    *    *       *\n" +
                "*       * *       *    *     *     *\n" +
                "*       * *       *    *      *   *\n" +
                "*       *  *     *     *       * *\n" +
                "*********    ***       *        *");

            Console.ReadKey();
        }
    }
}

/*18.5 (Bubble Sort) Implement the bubble sort—another simple, yet inefficient, sorting technique. It’s called bubble sort or sinking sort because smaller values 
       gradually “bubble” their way to the top of the array (i.e., toward the first element) like air bubbles rising in water, while the larger values sink to
       the bottom (end) of the array. The technique uses nested loops to make several passes through the array. Each pass compares successive overlapping pairs of elements
       (i.e., elements 0 and 1, 1 and 2, 2 and 3,etc.). If a pair is in increasing order (or the values are equal), the bubble sort leaves the values as they are.
       If a pair is in decreasing order, the bubble sort swaps their values in the array. The first pass compares the first two elements of the array and swaps them if necessary.
       It then compares the second and third elements. The end of this pass compares the last two elements in the array and swaps them if necessary.
       After one pass, the largest element will be in the last position. After two passes, the largest two elements will be in the last two positions.
       Explain why bubble sort is an O(n2) algorithm.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._5
{
    class Program
    {
        public static void BubbleSort(int[] arrayForSorting)
        {
            int temp;

            for (int i = 0; i < arrayForSorting.Length - 1; i++)
            {
                for (int y = 0; y < arrayForSorting.Length - (1 + i); y++)
                {
                    if (arrayForSorting[y] > arrayForSorting[y + 1])
                    {
                        temp = arrayForSorting[y + 1];
                        arrayForSorting[y + 1] = arrayForSorting[y];
                        arrayForSorting[y] = temp;
                    }
                }
            }
        }
    }
}

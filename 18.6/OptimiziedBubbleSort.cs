/*18.6 (Enhanced Bubble Sort) Make the following simple modifications to improve the performance of the bubble sort you developed in Exercise 18.5:
       a) After the first pass, the largest number is guaranteed to be in the highest-numbered element of the array (for an array being sorted in ascending order); after the second pass,
          the two highest numbers are “in place”; and so on. Instead of making nine comparisons on every pass of a 10-element array, modify the bubble sort to make eight comparisons
          on the second pass, seven on the third pass and so on.
       b) The data in the array may already be in the proper order or near-proper order, so why make nine passes of a 10-element array if fewer will suffice? Modify the sort to check at
          the end of each pass whether any swaps have been made. If none have been made, the data must already be in the proper order, so the app should terminate. If swaps have
          been made, at least one more pass is needed
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._6
{
    class OptimiziedBubbleSort

    {
       
        public static void BubbleSort(int[] arrayForSorting)
        {
            int temp;
            bool swap;

            for (int i = 0; i < arrayForSorting.Length - 1; i++)
            {
                swap = false;
                for (int y = 0; y < arrayForSorting.Length - (1 + i); y++)
                {
                    if (arrayForSorting[y] > arrayForSorting[y + 1])
                    {
                        temp = arrayForSorting[y + 1];
                        arrayForSorting[y + 1] = arrayForSorting[y];
                        arrayForSorting[y] = temp;
                        swap = true;
                    }
                }
                if (swap == false)
                    break;
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._10
{
    class QuickSorting
    {
        //a) Partitioning Step
        static int Partition(int[] array, int minIndex, int maxIndex)
        {
            int pivot = minIndex - 1;
            for (int i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    int temporary = array[pivot];
                    array[pivot] = array[i];
                    array[i] = temporary;
                }
            }

            pivot++;
            int temp = array[pivot];
            array[pivot] = array[maxIndex];
            array[maxIndex] = temp;
            return pivot;
        }
        //b) Recursive Step
        static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            int pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        public static int[] QuickSort(int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Algorithms
{
    public class QuickSort
    {

        public QuickSort() { }

        public int[] Sort(int[] arr)
        {
            
            QSort(arr, 0, arr.Length - 1);

            return arr;
        }

        private void QSort(int[] array, int leftBoudary, int rightBoundary) 
        {
            if (leftBoudary < rightBoundary) 
            { 
                var pivotPositionIndex = Partition(array, leftBoudary, rightBoundary);
                //Sort the left side of the array.
                QSort(array, leftBoudary, pivotPositionIndex - 1);
                //Sort the right side of the array.
                QSort(array, pivotPositionIndex + 1, rightBoundary);
            }
        }

        private int Partition(int[] array, int left, int right)
        {
            int pivotPositionIndex = left;
            int pivot = array[left];
            for (int i = left + 1; i <= right; i++)
            {
                if (array[i] < pivot)
                {                 
                    pivotPositionIndex++;
                    Swap(array, pivotPositionIndex, i);
                    
                }
            }
            Swap(array, pivotPositionIndex, left);
            return pivotPositionIndex;
        }

        private void Swap(int[] array, int positionOneIndex, int positionTwoIndex) 
        {
            int temp = array[positionOneIndex];
            array[positionOneIndex] = array[positionTwoIndex];
            array[positionTwoIndex] = temp;
        }
    }
}

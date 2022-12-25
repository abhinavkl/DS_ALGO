using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_ALGO.Programs
{
    internal class _009_Kth_Smallest_In_Unsorted_Array_Heap_Sort_WO_Auxl_Space
    {
        private int[] arr { get; set; }
        private int n { get { return arr.Length; } }
        private int k;
        public _009_Kth_Smallest_In_Unsorted_Array_Heap_Sort_WO_Auxl_Space()
        {
            arr = new int[] {12, 7, 0, 3, 18, 15, 19, 6, 1, 8,
              11, 10, 9, 5, 13, 16, 2, 14, 17, 4};
            k = 5;
        }

        public void Solve()
        {
            //make the 0th index the lowest.
            SetLowestElementTo0(); //logn

            SetRemainingLowestElemnts(); //klogn

            Console.WriteLine($" {k}th smallest element is : {arr[n-k]}");
        }

        void SetRemainingLowestElemnts()
        {
            for (int i = n-1, j = 0; i >=0 && j < k; i--, j++)
            {
                Swap(i, 0);
                Heapify(i,0);
            }
        }

        void SetLowestElementTo0()
        {
            for (int index = n/2-1;index>=0;index--)
            {
                Heapify(n-1,index);
            }
        }

        void Heapify(int lastElementIndex,int index)
        {
            int left = 2 * index + 1;
            int right = 2 * index + 2;

            int minValueIndex = index;

            if (left < lastElementIndex && arr[left] < arr[minValueIndex])
                minValueIndex = left;

            if (right < lastElementIndex && arr[right] < arr[minValueIndex])
                minValueIndex = right;

            if (minValueIndex != index)
            {
                Swap(minValueIndex,index);
                Heapify(lastElementIndex,minValueIndex);
            }
        }

        void Swap(int swapFrom,int swapTo)
        {
            if (arr[swapFrom] != arr[swapTo])
            {
                arr[swapFrom] = arr[swapFrom] ^ arr[swapTo];
                arr[swapTo] = arr[swapFrom] ^ arr[swapTo];
                arr[swapFrom] = arr[swapFrom] ^ arr[swapTo];
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_ALGO.Programs
{
    internal class _014_Find_First_K_smallest_elements_in_Unsorted_Array
    {
        int[] arr { get; set; }
        int n { get { return arr.Length; } }
        int k;
        public _014_Find_First_K_smallest_elements_in_Unsorted_Array()
        {
            arr = new int[] {12, 7, 0, 3, 18, 15, 19, 6, 1, 8,
              11, 10,22, 9, 5, 21,13, 16, 2, 14,20, 17, 4};
            k = 7;
        }

        public void Solve()
        {
            SetFirstSmallestNumber(); //logn

            SetKRemainingSmallestNumber(); //klogn

            Console.WriteLine($"The {k} smallest elements are : {string.Join(",", arr.TakeLast(k).Reverse())} ");
        }

        void SetFirstSmallestNumber()
        {
            for (int i = arr.Length/2-1; i >= 0; i--)
            {
                Heapify(n,i);
            }
        }

        void SetKRemainingSmallestNumber()
        {
            for(int i=n-1,j=0;i>=0 && j < k;i--, j++)
            {
                Swap(i,0);
                Heapify(i,0);
            }
        }

        void Heapify(int lastElementIndex,int index)
        {
            int left = 2 * index + 1;
            int right = 2 * index + 2;

            int actualMinIndex = index;

            if (left < lastElementIndex && arr[left] < arr[actualMinIndex])
                actualMinIndex = left;

            if (right < lastElementIndex && arr[right] < arr[actualMinIndex])
                actualMinIndex = right;

            if(actualMinIndex != index)
            {
                Swap(actualMinIndex,index);
                Heapify(lastElementIndex,actualMinIndex);
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

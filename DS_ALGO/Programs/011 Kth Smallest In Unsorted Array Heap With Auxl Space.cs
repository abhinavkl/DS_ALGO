using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_ALGO.Programs
{
    internal class _011_Kth_Smallest_In_Unsorted_Array_Heap_With_Auxl_Space
    {
        private int[] arr { get; set; }
        private int k;
        private int n { get { return arr.Length; } }
        public _011_Kth_Smallest_In_Unsorted_Array_Heap_With_Auxl_Space()
        {
            arr = new int[] {12, 7, 0, 3, 18, 15, 19, 6, 1, 8,
              11, 10, 9, 5, 13, 16, 2, 14, 17, 4};
            k = 5;
        }

        public void Solve()
        { 
            Sort(k); //O(klogk)

            for (int i = k; i < arr.Length; i++)
            {
                if(arr[i] < arr[k-1])
                {
                    Swap(i,k-1);
                    Sort(k);
                }
            }
        }

        void Sort(int elementCount)
        {
            //QuickSort(0, elementCount-1); // in worst case sorting is k, not logk. better use heapsort.
            HeapSort(elementCount);
        }
      
        void HeapSort(int elementCount)
        {
            SetFirstSmallElement(elementCount);

            for(int i = elementCount-1; i >= 0; i--)
            {
                Swap(i,0);
                Heapify(i,0);
            }
        }

        void SetFirstSmallElement(int elementCount)
        {
            for (int i = elementCount/2 - 1; i >=0; i--)
            {
                Heapify(elementCount, i);
            }
        }

        void Heapify(int lastElementIndex,int index)
        {
            int left = 2 * index + 1;
            int right = 2 * index + 2;

            int maxPosition = index;

            if (left < lastElementIndex && arr[left] > arr[maxPosition])
                maxPosition = left;

            if (right < lastElementIndex && arr[right] > arr[maxPosition])
                maxPosition = right;

            if (maxPosition != index)
            {
                Swap(maxPosition, index);
                Heapify(lastElementIndex, maxPosition);
            }
        }

        void QuickSort(int start,int end)
        {
            if (start < end)
            {
                int pivot = GetPivot(start, end);
                QuickSort(start, pivot - 1);
                QuickSort(pivot + 1, end);
            }
        }

        int GetPivot(int start,int end)
        {
            int pivot = arr[end];
            int countOfElemLessThanPivot = start - 1;

            for (int i = start; i < end ; i++)
            {
                if (arr[i] < pivot)
                {
                    Swap(++countOfElemLessThanPivot, i);
                }
            }
            Swap(++countOfElemLessThanPivot, end);

            return countOfElemLessThanPivot;
        }

        void Swap(int swapFrom,int swapTo)
        {
            if (arr[swapFrom] != arr[swapTo])
            {
                arr[swapFrom] = arr[swapTo] ^ arr[swapFrom];
                arr[swapTo] = arr[swapTo] ^ arr[swapFrom];
                arr[swapFrom] = arr[swapTo] ^ arr[swapFrom];
            }
        }
    }
}

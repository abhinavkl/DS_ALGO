using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_ALGO.Programs
{
    internal class _010_Kth_Smallest_In_Unsorted_Array_Quick_Select
    {
        private int[] arr { get; set; }
        private int k;
        private int n { get { return arr.Length; } }
        public _010_Kth_Smallest_In_Unsorted_Array_Quick_Select()
        {
            arr = new int[] {12, 7, 0, 3, 18, 15, 19, 6, 1, 8,
              11, 10, 9, 5, 13, 16, 2, 14, 17, 4};
            k = 5;
        }

        public void Solve()
        {
            QuickSelect(0, n - 1);
            Console.WriteLine($" {k}th smallest element is : {arr[k]}");
        }

        int QuickSelect(int start,int end)
        {
            while (start < end)
            {
                int pivot = GetPivot(start, end);

                if(pivot>k)
                    return QuickSelect(start, pivot-1);
                else if (pivot < k)
                    return QuickSelect(pivot+1, end);
                return arr[k];
            }
            return arr[k];
        }

        int GetPivot(int start,int end)
        {
            int pivot = arr[end];
            int countOfElemLessThanPivot = start - 1;

            for (int i = start; i < end; i++)
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

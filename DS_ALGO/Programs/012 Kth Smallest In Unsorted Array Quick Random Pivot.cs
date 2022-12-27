using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_ALGO.Programs
{
    internal class _012_Kth_Smallest_In_Unsorted_Array_Quick_Random_Pivot
    {
        int[] arr { get; set; }
        int n { get { return arr.Length; } }
        int k;
        public _012_Kth_Smallest_In_Unsorted_Array_Quick_Random_Pivot()
        {
            arr = new int[] {12, 7, 0, 3, 18, 15, 19, 6, 1, 8,
              11, 10, 9, 5, 13, 16, 2, 14, 17, 4};
            k = 5;
        }

        public void Solve()
        {
            QuickSort(0,n-1);
        }

        void QuickSort(int start,int end)
        {
            if (start < end)
            {
                int randomPivotPosition = RandomPivotPosition(start, end);
                //for normal sorting
                //QuickSort(start, randomPivotPosition - 1);
                //QuickSort(randomPivotPosition + 1, end); 

                //to get kth smallest element.
                if (randomPivotPosition > k)
                    QuickSort(start, randomPivotPosition - 1);
                else if (randomPivotPosition < k)
                    QuickSort(randomPivotPosition + 1, end);
                else
                    Console.WriteLine($" {k}th smallest element is : {arr[k]} ");
            }
        }

        int NextPivot(int start,int end)
        {
            int pivotValue = arr[end];
            int noOfElemLessThanPivot = start - 1;

            for (int i = start; i < end; i++)
            {
                if (arr[i] < pivotValue)
                    Swap(++noOfElemLessThanPivot,i);
            }
            Swap(++noOfElemLessThanPivot,end);

            return noOfElemLessThanPivot;
        }

        int RandomPivotPosition(int start,int end)
        {
            int noOfElem = end - start + 1;
            Random random = new Random();
            int pivot = random.Next(noOfElem);
            Swap(start+pivot,end);
            return NextPivot(start,end);
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

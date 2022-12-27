using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_ALGO.Programs
{
    internal class _013_Kth_Smallest_In_Unsorted_Array_Quick_Worst_Linear_Time
    {
        int[] arr { get; set; }
        int n { get { return arr.Length; } }
        int k;
        public _013_Kth_Smallest_In_Unsorted_Array_Quick_Worst_Linear_Time()
        {
            arr = new int[] {12, 7, 0, 3, 18, 15, 19, 6, 1, 8,
              11, 10,22, 9, 5, 21,13, 16, 2, 14,20, 17, 4};
            k = 7;
        }

        public void Solve()
        {
            int kthValue=QuickSort(0, n-1);
            Console.WriteLine($" {k}th smallest value is : {kthValue} ");
         }

        int QuickSort(int start,int end)
        {
            if (start < end)
            {
                int pivotValue = PivotValueByMedians(arr, start, end);
                
                MovePivotToEnd(pivotValue,end);
                
                int pivot = NextPivot(arr, start, end, pivotValue);
                if (pivot == k)
                    return arr[pivot];
                else if (pivot > k)
                    return QuickSort(start, pivot - 1);
                else return QuickSort(pivot + 1, end);
            }
            return arr[k];
        }

        void MovePivotToEnd(int pivotValue,int end)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == pivotValue)
                {
                    Swap(arr,i,end);
                }
            }
        }
        
        int PivotValueByMedians(int[] inputArray,int start,int end)
        {
            int noOfElem = end - start + 1;
            int[] medians=new int[(noOfElem+4) / 5];
            int i;
            //all-but-not-last group's median
            for (i = 0; i < noOfElem/5; i++)
            {
                int[] input = inputArray.Skip(5 * i+start).Take(5).ToArray();
                medians[i] = FindMedian(input);
            }

            //last-one median
            if(i*5 < noOfElem)
            {
                int[] input = inputArray.Skip(5*i+start).Take(noOfElem % 5).ToArray();
                medians[i]=FindMedian(input);
                i++;
            }

            int finalMedian = (i == 1) ? medians[0] : PivotValueByMedians(medians,0,medians.Length-1);

            return finalMedian;
        }

        int FindMedian(int[] inputArray)
        {
            Sort(inputArray, 0, inputArray.Length-1);
            return inputArray[inputArray.Length/2];
        }

        void Sort(int[] inputArray,int start,int end)
        {
            if (start < end)
            {
                int nextPivot = NextPivot(inputArray,start, end, inputArray[end]);
                Sort(inputArray,start,nextPivot-1);
                Sort(inputArray,nextPivot + 1, end);
            }
        }

        int NextPivot(int[] inputArray,int start,int end,int pivotValue)
        {
            int noOfElemLessThanPivot = start - 1;

            for (int i = start; i < end; i++)
            {
                if (inputArray[i] < pivotValue)
                {
                    Swap(inputArray,++noOfElemLessThanPivot, i);
                }
            }
            Swap(inputArray,++noOfElemLessThanPivot,end);

            return noOfElemLessThanPivot;
        }

        void Swap(int[] inputArray,int swapFrom,int swapTo)
        {
            if (inputArray[swapFrom] != inputArray[swapTo])
            {
                inputArray[swapTo] = inputArray[swapFrom] ^ inputArray[swapTo];
                inputArray[swapFrom] = inputArray[swapFrom] ^ inputArray[swapTo];
                inputArray[swapTo] = inputArray[swapFrom] ^ inputArray[swapTo];
            }
        }

    }
}

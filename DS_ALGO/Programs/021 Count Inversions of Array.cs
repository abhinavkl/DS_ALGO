using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_ALGO.Programs
{
    internal class _021_Count_Inversions_of_Array
    {
        int[] arr { get; set; }
        int n { get { return arr.Length; } }
        public _021_Count_Inversions_of_Array()
        {
            arr = new int[] { 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 1, 2, 3, 4, 5, 6, 7 };            
        }

        public void Solve()
        {
            int inversionCount = 0;
            int[] result = new int[n];
            arr.CopyTo(result, 0);
            InversionCount(ref inversionCount, 0, n - 1);
            arr = result;
        }

        void InversionCount(ref int inversionCount,int start,int end)
        {
            if (start < end)
            {
                int mid = (end - start) / 2 + start;
                InversionCount(ref inversionCount,start,mid);
                InversionCount(ref inversionCount,mid+1,end);
                CountInversionsWhileMerging(ref inversionCount,start,mid,end);
            }
        }

        void CountInversionsWhileMerging(ref int inversionCount,int start,int mid,int end)
        {
            int left = start;
            int right= mid+1;

            int res = 0;
            int[] result = new int[end-start+1];

            while( left<=mid && right <= end)
            {
                if (arr[left] < arr[right])
                { 
                    result[res++] = arr[left++];
                }
                else
                {
                    inversionCount+=(mid-left)+1;
                    result[res++] = arr[right++];
                }
            }

            while(left<=mid)
                result[res++]=arr[left++];

            while (right <= end)
                result[res++] = arr[right++];

            result.CopyTo(arr, start);

        }



    }
}

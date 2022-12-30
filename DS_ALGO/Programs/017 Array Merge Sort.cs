using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_ALGO.Programs
{
    internal class _017_Array_Merge_Sort
    {
        int[] arr { get; set; }
        int n { get { return arr.Length; } }
        public _017_Array_Merge_Sort()
        {
            arr = new int[] {12, 7, 0, 3, 18, 15, 19, 6, 1, 8,11, 10,22, 9, 5, 21,13, 16, 2, 14,20, 17, 4};
        }

        public void Solve()
        {
            MergeSort(0,n-1);
        }

        void MergeSort(int start,int end)
        {
            if (start < end)
            {
                int mid = (end - start) / 2 + start;
                MergeSort(start, mid);
                MergeSort(mid + 1, end);
                Merge(start, mid, end);
            }
        }
        
        void Merge(int start,int mid,int end)
        {
            int left = start;
            int right = mid + 1;
            int res = 0;

            int[] result=new int[end-start+1];

            while(left<=mid && right <= end)
            {
                if (arr[left] < arr[right])
                    result[res++]=arr[left++];
                else
                    result[res++] = arr[right++];
            }

            while (left <= mid)
                result[res++] = arr[left++];
            while (right <= end)
                result[res++] = arr[right++];

            for(int i = start; i <= end; i++)
            {
                arr[i] = result[i - start];
            }
        }
    }
}

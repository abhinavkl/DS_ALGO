using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_ALGO.Programs
{
    internal class _018_Rearrange_Positives_Negatives_With_Same_Order
    {
        int[] arr { get; set; }
        int n { get { return arr.Length; } }
        public _018_Rearrange_Positives_Negatives_With_Same_Order()
        {
            arr = new int[] {-12, 7, 0, 3, -18, 15, 19, -6, 1, -8,
              11, -10,-22, 9, 5, 21,13, -16, -2, -14,-20, 17, -4};

        }

        public void Solve()
        {
            DivideAndSolve(0,n-1);   
         }

        void DivideAndSolve(int start,int end)
        {
            if (start < end)
            {
                int mid = (end - start) / 2 + start;
                DivideAndSolve(start,mid);
                DivideAndSolve(mid + 1, end);
                SeperateElements(start,mid,end);
            }
        }

        void SeperateElements(int start,int mid,int end)
        {
            int left=start;
            int right=mid+1;

            while (left <= mid && arr[left] < 0)
                left++;

            while (right <= end && arr[right] < 0)
                right++;

            Reverse(left, mid);
            Reverse(mid + 1, right - 1);
            Reverse(left, right - 1);

        }

        void Reverse(int start,int end)
        {
            while (start < end)
            {
                arr[start] = arr[start] ^ arr[end];
                arr[end] = arr[start] ^ arr[end];
                arr[start] = arr[start] ^ arr[end];
                start++;
                end--;
            }
        }

    }
}

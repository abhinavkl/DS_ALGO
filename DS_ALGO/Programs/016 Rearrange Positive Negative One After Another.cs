using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_ALGO.Programs
{
    internal class _016_Rearrange_Positive_Negative_One_After_Another
    {
        int[] arr { get; set; }
        int n { get { return arr.Length; } }

        int posIndex;
        
        public _016_Rearrange_Positive_Negative_One_After_Another()
        {
            arr = new int[] {-12, 7, 0, 3, -18, 15, 19, -6, 1, -8,
              11, -10,-22, 9, 5, 21,13, -16, -2, -14,-20, 17, -4};

            //arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -1, -2, -3, -4 };

            posIndex = 0;
        }

        //+ve numbers at even position, -ve numbers at odd position.
        public void Solve()
        {
            //bring all positives to one side and negatives to one side.
            //then swap by two pointers.

            int negCount = -1;

            for(int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    Swap(++negCount, i);
                }
            }
            Swap(++negCount, n-1);

            posIndex = negCount;
            for(int i = 0,j=negCount; j>0; j--,i+=2)
            {
                Swap(i, posIndex++);
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

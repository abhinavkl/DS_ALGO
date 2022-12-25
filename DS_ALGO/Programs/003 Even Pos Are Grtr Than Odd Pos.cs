using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_ALGO.Programs
{
    internal class _3_Even_Positions_Are_Greater_Than_Odd
    {
        public int[] arr { get; set; }
        public _3_Even_Positions_Are_Greater_Than_Odd()
        {
            arr= new int[] { 1,9,2,8,3,7,4,6,5,10 };
        }

        public void Solve()
        {
            for (int index = 1; index < arr.Length; index++)
            {
                //even
                //swap when current position is lesser than its previous.
                if ((index % 2) == 0) 
                {
                    if (arr[index] < arr[index - 1])
                    {
                        Swap(index);
                    }
                }
                //odd
                //swap when current position is greater than its previous.
                else
                {
                    if (arr[index] > arr[index - 1])
                    {
                        Swap(index);
                    }
                }
            }
        }

        void Swap(int index)
        {
            arr[index] = arr[index - 1] ^ arr[index];
            arr[index - 1] = arr[index - 1] ^ arr[index];
            arr[index] = arr[index - 1] ^ arr[index];
        }

    }
}

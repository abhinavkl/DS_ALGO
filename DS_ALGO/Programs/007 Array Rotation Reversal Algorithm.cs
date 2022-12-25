using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_ALGO.Programs
{
    internal class _007_Array_Rotation_Reversal_Algorithm
    {
        public int[] arr { get; set; }
        private int rotation;
        public _007_Array_Rotation_Reversal_Algorithm()
        {
            arr = new int[] {1,2,3,4,5,6,7,8,9,10};
            rotation = 5;
        }

        public void Solve()
        {
            Reverse(0, rotation-1);
            Reverse(rotation, arr.Length-1);
            Reverse(0, arr.Length-1);
        }

        void Reverse(int start,int end)
        {
            for (int i = start,j=end; i < j; i++,j--)
            {
                if (arr[i] != arr[j])
                {
                    arr[i] = arr[i] ^ arr[j];
                    arr[j] = arr[i]^arr[j];
                    arr[i] = arr[i] ^ arr[j];
                }
            }
        }

    }
}

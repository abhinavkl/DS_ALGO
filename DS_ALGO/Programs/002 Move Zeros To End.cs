using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_ALGO.Programs
{
    internal class _2_Move_Zeros_To_End
    {
        public int[] arr { get; set; }
        public int NonZeroElementCount { get; set; }
        public _2_Move_Zeros_To_End()
        {
            arr= new int[] { 1, 2, 0, 4, 3, 0, 5, 0 };
        }

        public void Solve()
        {
            for(int index = 0; index < arr.Length; index++)
            {
                MoveElement(index);
            }

            for (int index = NonZeroElementCount; index < arr.Length; index++)
            {
                arr[index] = 0;
            }
        }

        void MoveElement(int index)
        {
            if(arr[index] != 0)
            {
                arr[NonZeroElementCount++] = arr[index];
            }
        }


    }
}

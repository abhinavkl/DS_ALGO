using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_ALGO.Programs
{
    internal class _2_Move_Zeros_To_End
    {
        public int[] InputArray { get; set; }
        public int NonZeroElementCount { get; set; }
        public _2_Move_Zeros_To_End()
        {
            InputArray= new int[] { 1, 2, 0, 4, 3, 0, 5, 0 };
        }

        public void Solve()
        {
            for(int index = 0; index < InputArray.Length; index++)
            {
                MoveElement(index);
            }

            for (int index = NonZeroElementCount; index < InputArray.Length; index++)
            {
                InputArray[index] = 0;
            }
        }

        void MoveElement(int index)
        {
            if(InputArray[index] != 0)
            {
                InputArray[NonZeroElementCount++] = InputArray[index];
            }
        }


    }
}

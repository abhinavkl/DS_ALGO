using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_ALGO.Programs
{
    internal class _3_Even_Positions_Are_Greater_Than_Odd
    {
        public int[] InputArray { get; set; }
        public _3_Even_Positions_Are_Greater_Than_Odd()
        {
            InputArray= new int[] { 1,9,2,8,3,7,4,6,5,10 };
        }

        public void Solve()
        {
            for (int index = 1; index < InputArray.Length; index++)
            {
                if ((index % 2) == 0) 
                {
                    if (InputArray[index] < InputArray[index - 1])
                    {
                        Swap(index);
                    }
                }
                //odd
                else
                {
                    if (InputArray[index] > InputArray[index - 1])
                    {
                        Swap(index);
                    }
                }
            }
        }

        void Swap(int index)
        {
            InputArray[index] = InputArray[index - 1] ^ InputArray[index];
            InputArray[index - 1] = InputArray[index - 1] ^ InputArray[index];
            InputArray[index] = InputArray[index - 1] ^ InputArray[index];
        }

    }
}

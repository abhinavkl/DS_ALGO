using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_ALGO.Programs
{
    internal class _004_First_Max_First_Min_Consecutive_For_Sorting_Array_Auxl_Space
    {
        public int[] arr { get; set; }
        public int[] Output = new int[] { };
        private int maxPointer;
        private int minPointer;
        public _004_First_Max_First_Min_Consecutive_For_Sorting_Array_Auxl_Space()
        {
            arr=new int[] {1,2,3,4,5,6,7,8,9,10};
            Array.Resize(ref Output, arr.Length);
            minPointer = arr.Length-1;
        }

        public void Solve()
        {
            for (int index = 0; index < arr.Length; index++)
            {
                Arrange(index);
            }
        }

        void Arrange(int index)
        {
            if (index % 2 == 0)
            {
                Output[index] = arr[maxPointer++];
            }
            else
            {
                Output[index]=arr[minPointer--];
            }
        }


    }
}

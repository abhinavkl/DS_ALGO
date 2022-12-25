using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_ALGO.Programs
{
    internal class _008_Array_Rotation_GCD
    {
        private int[] arr { get; set; }
        private int rotation;
        private int n { get { return arr.Length; } }
        public _008_Array_Rotation_GCD()
        {
            arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11,12,13,14,15,16,17,18 };
            rotation = 4;
        }

        public void Solve()
        {
            rotation = rotation % n;
            int loops = GCD(rotation, n);

            for (int loop = 0; loop < loops; loop++)
            {

                int curIndex = loop;
                int nexIndex = curIndex+rotation;
                int startingLoopValue = arr[curIndex];

                while (nexIndex != loop)
                {
                    arr[curIndex] = arr[nexIndex];

                    curIndex = nexIndex;
                    nexIndex=(curIndex+rotation)%n;
                }

                arr[curIndex] = startingLoopValue;
            }
        }


        int GCD(int first,int second)
        {
            if(first==0)
            {
                return second;
            }
            else
            {
                return GCD(second%first,first);
            }
        }

    }
}

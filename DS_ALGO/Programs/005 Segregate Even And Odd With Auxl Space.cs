using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_ALGO.Programs
{
    internal class _005_Segregate_Even_And_Odd
    {
        public int[] arr { get; set; }
        public int[] Output = new int[] { };
        private int evenCounter;
        public _005_Segregate_Even_And_Odd()
        {
            arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Array.Resize(ref Output,arr.Length);
        }

        public void Solve()
        {
            for (int index = 0; index < arr.Length; index++)
            {
                Arrange(index,true);
            }

            for (int index = 0; index < arr.Length; index++)
            {
                Arrange(index,false);
            }
        }

        void Arrange(int index,bool evenInsert)
        {
            if ((arr[index] % 2 == 0) && evenInsert )
            {
                Output[evenCounter++]=arr[index];
            }
            else if(arr[index] % 2 != 0  && !evenInsert )
            {
                Output[evenCounter++] = arr[index];
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_ALGO.Programs
{
    internal class _006_Segregate_Even_And_Odd_With_No_Space
    {
        public int[] arr { get; set; }
        private int lastOddIndex;
        public _006_Segregate_Even_And_Odd_With_No_Space()
        {
            arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
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
            if (arr[index] % 2 == 0)
            {
                Swap(index);
                lastOddIndex++;
            }
        }

        void Swap(int index)
        {
            arr[index] = arr[index] ^ arr[lastOddIndex];
            arr[lastOddIndex] = arr[index] ^ arr[lastOddIndex];
            arr[index] = arr[index] ^ arr[lastOddIndex];
        }

    }
}

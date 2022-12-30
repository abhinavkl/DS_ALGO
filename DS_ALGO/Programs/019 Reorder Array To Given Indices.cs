using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_ALGO.Programs
{
    internal class _019_Reorder_Array_To_Given_Indices
    {
        int[] arr { get; set; }
        int n { get { return arr.Length; } }
        int[] indices { get; set; }
        public _019_Reorder_Array_To_Given_Indices()
        {
            arr = new int[] { 50, 40, 70, 60, 90 };
            indices = new int[n];
            indices = new int[] { 3, 0, 4, 1, 2 };
        }

        public void Solve()
        {
            Reorder();
        }

        void Reorder()
        {
            for(int i = 0; i < n; i++)
            {
                if(indices[i] != i)
                {
                    int valueInActualIndex=arr[i];
                    arr[i] = arr[indices[i]];
                    arr[indices[i]] = valueInActualIndex;

                    int indexInActualIndex = indices[indices[i]];
                    indices[indices[i]] = indices[i];
                    indices[i] = indexInActualIndex;

                }
            }
        }

    }
}

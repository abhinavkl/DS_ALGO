using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_ALGO.Programs
{
    internal class _1_ArrayOfI_EqualsTo_I
    {
        public int[] arr { get; set; }
        public _1_ArrayOfI_EqualsTo_I()
        {
            arr = new int[] { 19, 7, 0, 3, 18, 15, 12, 6, 1, 8,
              11, 10, 9, 5, 13, 16, 2, 14, 17, 4};
        }

        public void Solve()
        {
            for(int index = 0; index < arr.Length; index++)
            {
                SwapRepeatedly(index);
            }
        }

        public void SwapRepeatedly(int index)
        {

            //if current element is -1, then ignore it.
            //if it is not -1, and if it is at current position then ignore it. 
            if (arr[index] != -1 && arr[index] != index)
            {
                //if the other element is -1 then set current element to -1 and other to current value.
                if (arr[arr[index]] == -1)
                {
                    arr[arr[index]]=arr[index];
                    arr[index] = -1;
                }
                else
                {
                    //if other element is not -1 then the swap both of them and so atleast one will be in correct place
                    //then do swaprepeatedly for other value.
                    int swapElement = arr[index];
                    int swapWith = arr[arr[index]];
                    arr[arr[index]] = swapElement;
                    arr[index] = swapWith;                      
                    SwapRepeatedly(arr[index]);
                }
            }
        }

    }
}

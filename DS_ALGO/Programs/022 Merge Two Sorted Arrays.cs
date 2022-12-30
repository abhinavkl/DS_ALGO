using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_ALGO.Programs
{
    internal class _022_Merge_Two_Sorted_Arrays
    {
        int[] arr1;
        int [] arr2;
        int n1 { get { return arr1.Length; } }
        int n2 { get { return arr2.Length; } }
        public _022_Merge_Two_Sorted_Arrays()
        {
            arr1 = new int[] { 6, 8, 10, 11, 12, 15 };
            arr2 = new int[] { 1, 3, 5, 7, 9, 13, 14 }; 
        }

        public void Solve()
        {
            if (n1 > n2)
            {
                MergeSwap(arr2, arr1);
            }
            else
            {
                MergeSwap(arr1,arr2);
            }
        }

        void MergeSwap(int[] smallerArray, int[] largerArray)
        {
            int largerArrayPointer = 0;
            int smallerArrayPointer = 0;

            int largerArrayLength = largerArray.Length;
            int smallerArrayLength=smallerArray.Length;

            while(smallerArrayPointer<smallerArrayLength && largerArrayPointer < largerArrayLength)
            {
                int searchKey = smallerArray[smallerArrayPointer] > largerArray[largerArrayPointer] ? smallerArray[smallerArrayPointer] : largerArray[largerArrayPointer];
                if (searchKey == smallerArray[smallerArrayPointer])
                {
                    smallerArrayPointer = NextGreaterElementIndex(largerArray, 0, largerArrayLength, searchKey);
                }
                else
                {
                    largerArrayPointer = NextGreaterElementIndex(smallerArray,0,smallerArrayPointer,searchKey);
                }
                break;
            }
        }

        int NextGreaterElementIndex(int[] searchArray,int searchFrom,int searchTo,int searchKey)
        {
            if (searchFrom<searchTo)
            {
                int mid = (searchTo - searchFrom) / 2 + searchFrom;

                if (searchArray[mid] == searchKey)
                    return mid;
                else if (searchArray[mid] > searchKey)
                    return NextGreaterElementIndex(searchArray, searchFrom, mid, searchKey);
                else
                    return NextGreaterElementIndex(searchArray, mid + 1, searchTo, searchKey);
            }
            return searchFrom;
        }


    }
}

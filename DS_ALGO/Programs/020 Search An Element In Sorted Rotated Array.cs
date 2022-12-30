using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_ALGO.Programs
{
    internal class _020_Search_An_Element_In_Sorted_Rotated_Array
    {
        int[] arr { get; set; }
        int n { get { return arr.Length; } }
        int key;
        
        public _020_Search_An_Element_In_Sorted_Rotated_Array()
        {
            //arr = new int[]  { 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 1, 2, 3, 4, 5, 6, 7 };
            arr = new int[] { 3, 3, 1, 2, 3, 3 };
            key = 20;
        }

        //here first we find the index of the rotation.
        public void Solve()
        {
            int rotatedAt = RotatedAt();
            
            if(arr[rotatedAt]==key)
            {
                Console.WriteLine($" {key} present at {rotatedAt} index ");
            }
            else if (arr[0]<key)
            {
                int found = Search(rotatedAt+1,n);
                Console.WriteLine($" {key} present at {found} index ");
            }
            else
            {
                int found = Search(0,rotatedAt);
                Console.WriteLine($"  {key} present at {found} index ");
            }
        }

        int RotatedAt()
        {
            int left = 0,right=n;
            while (left < right)
            {
                int mid = (right - left) / 2 + left;
                if (arr[left] < arr[mid])
                {
                    left = mid;
                }
                else
                {
                    right = mid;
                }
            }
            return left+1;
        }

        int Search(int start,int end)
        {
            if (start < end)
            {
                int mid = (end - start) / 2 + start;
                if (arr[mid] == key)
                    return mid;
                else if (arr[mid] > key)
                    return Search(start, mid);
                else
                    return Search(mid + 1, end);
            }
            else
                return -1;
        }

    }
}

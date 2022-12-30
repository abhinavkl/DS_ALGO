using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_ALGO.Programs
{
    internal class _015_Find_Continuous_Subarray_With_Sum_Positive_Integers
    {
        int[] arr { get; set; }
        int n { get { return arr.Length; } }
        int sum=0;
        int cumSum = 0;
        public _015_Find_Continuous_Subarray_With_Sum_Positive_Integers()
        {
            arr = new int[] {12, 7, 0, 3, 18, 15, 19, 6, 1, 8,
              11, 10,22, 9, 5, 21,13, 16, 2, 14,20, 17, 4};
            sum = 21;
        }

        public void Solve()
        {
            int startIndex = 0,endIndex=0;
            for (int i = -1; i < arr.Length;)
            {
                if(cumSum==sum)
                {
                    endIndex = i;
                    Console.WriteLine($" The sum is found from {startIndex} to {endIndex} ");
                    break;
                }

                while (cumSum > sum)
                {
                    cumSum = cumSum - arr[startIndex++];

                }

                while (cumSum < sum)
                {
                    cumSum = cumSum + arr[++i];
                }
            }
        }


        

    }
}

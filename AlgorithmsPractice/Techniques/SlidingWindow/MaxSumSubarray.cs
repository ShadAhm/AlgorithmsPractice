using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPractice.Techniques.DynamicProgrammingMemoization.SlidingWindow
{
    /* Find the max sum of subarray of a fixed size K
     * 
     * Example input: [4, 2, 1, 7, 8, 1, 2, 8, 1, 0]
     * 
     ***
     * This example problem demonstrates the fixed-size sliding window
     ***/
    public class MaxSumSubarray
    {
        public int Solve(int[] array, int k)
        {
            int maxValue = int.MinValue;
            int currentRunningSum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                currentRunningSum += array[i];

                if(i >= k - 1)
                {
                    maxValue = Math.Max(maxValue, currentRunningSum);
                    currentRunningSum -= array[i - (k - 1)];
                }
            }
            return maxValue;
        }
    }
}

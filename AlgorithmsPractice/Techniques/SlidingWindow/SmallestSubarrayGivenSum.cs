using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPractice.Techniques.SlidingWindow
{
    /* This problem demonstrates the dynamic variant sliding window
     */
    public class SmallestSubarrayGivenSum
    {
        public int Solve(int[] array, int targetSum)
        {
            int minWindowSize = int.MaxValue;
            int currentWindowSum = 0;
            int windowStart = 0;

            for (int windowEnd = 0; windowEnd < array.Length; windowEnd++)
            {
                currentWindowSum += array[windowEnd];

                while(currentWindowSum >= targetSum)
                {
                    minWindowSize = Math.Min(minWindowSize, (windowEnd - windowStart) + 1);
                    currentWindowSum -= array[windowStart];
                    windowStart++;
                }
            }

            return minWindowSize;
        }
    }
}

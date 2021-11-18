using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPractice.Problems.CoinStacks
{
    public class CoinStacksSolverWithSorting
    {
        public int Solve(int[] A)
        {
            Array.Sort(A);
            int inHand = 0;

            for (int i = 0; i < A.Length; i++)
            {
                bool isLastStack = i == A.Length - 1;

                A[i] += inHand;

                if (isLastStack)
                    return A[i];

                int currAmount = A[i];
                inHand = currAmount / 2;

                A[i] = currAmount % 2;
            }

            return -1;
        }
    }
}

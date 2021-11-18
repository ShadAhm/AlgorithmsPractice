using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsForPracticing.Algo.CoinStacks
{
    public class CoinStacksSolverSplitArray
    {
        public int Solve(int[] A)
        {
            var array = A;

            var biggestIndex = FindBiggestIndex(array);

            int[] leftOfArray;
            int[] rightOfArray;
            Split<int>(array, biggestIndex, out leftOfArray, out rightOfArray);

            leftOfArray = TakeFromLeft(leftOfArray);

            rightOfArray[0] = leftOfArray[leftOfArray.Length - 1];

            rightOfArray = TakeFromRight(rightOfArray);

            return rightOfArray[0];
        }

        private int[] TakeFromLeft(int[] A)
        {
            int inHand = 0;

            for (int i = 0; i < A.Length; i++)
            {
                A[i] += inHand;

                if(i != A.Length - 1)
                {
                    int currAmount = A[i];
                    inHand = currAmount / 2;

                    A[i] = currAmount % 2;
                }
            }

            return A;
        }

        private int[] TakeFromRight(int[] A)
        {
            int inHand = 0;

            for (int i = A.Length - 1; i >= 0; i--)
            {
                A[i] += inHand;

                if (i != 0)
                {
                    int currAmount = A[i];
                    inHand = currAmount / 2;

                    A[i] = currAmount % 2; 
                }
            }

            return A;
        }

        private int FindBiggestIndex(int[] array)
        {
            int max = 0;
            int maxIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        private void Split<T>(T[] source, int index, out T[] first, out T[] last)
        {
            int len2 = source.Length - index;
            first = new T[index + 1];
            last = new T[len2];
            Array.Copy(source, 0, first, 0, index + 1);
            Array.Copy(source, index, last, 0, len2);
        }
    }
}

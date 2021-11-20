using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPractice.Problems.TwoSum;

//https://leetcode.com/problems/two-sum/
public class TwoSumSolver
{
    public int[] Solve(int[] nums, int target)
    {
        if (nums.Length == 1)
            return new int[] { 0 };

        return Calculate(nums, target, 0, 1, new HashSet<int>());
    }

    private int[] Calculate(int[] nums, int target, int index, int index2, HashSet<int> deadPaths)
    {
        if (index != index2)
        {
            if (nums[index] + nums[index2] == target)
                return new int[2] { index, index2 };

            if (nums[index] >= target)
            {
                deadPaths.Add(index);
            }

            index2++;

            if (index2 == nums.Length - 1)
            {
                index2 = 0;
                index++;
            }
        }
        else
        {
            index2++;
        }

        return Calculate(nums, target, index, index2, deadPaths);
    }
}

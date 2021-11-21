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

        return Calculate(nums, target, 0, 1);
    }

    private int[] Calculate(int[] nums, int target, int index, int index2)
    {
        if (index != index2)
        {
            if (nums[index] + nums[index2] == target)
                return new int[2] { index, index2 };
        }

        index2++;

        if (index2 == nums.Length - 1)
        {
            index2 = 0;
            index++;
        }

        return Calculate(nums, target, index, index2);
    }
}

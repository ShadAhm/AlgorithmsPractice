using Xunit;
using AlgorithmsPractice.Problems.TwoSum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPractice.Problems.TwoSum.Tests
{
    public class TwoSumSolverTests
    {
        private readonly TwoSumSolver _solver;

        public TwoSumSolverTests()
        {
            _solver = new TwoSumSolver();
        }

        [Theory()]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [InlineData(new int[] { 3, 2, 3 }, 6, new int[] { 0, 2 })]
        public void SolveTest(int[] nums, int target, int[] expected)
        {
            var actual = _solver.Solve(nums, target);

            Assert.Equal(expected, actual);
        }
    }
}
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

        [Fact()]
        public void SolveTest()
        {
            var nums = new int[] { 2, 7, 11, 15 };
            var target = 9;

            var actual = _solver.Solve(nums, target);

            Assert.Equal(new int[] { 0, 1 }, actual);
        }
    }
}
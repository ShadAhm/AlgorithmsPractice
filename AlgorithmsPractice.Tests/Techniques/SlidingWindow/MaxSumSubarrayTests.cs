using Xunit;
using AlgorithmsPractice.Techniques.DynamicProgrammingMemoization.SlidingWindow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPractice.Techniques.DynamicProgrammingMemoization.SlidingWindow.Tests
{
    public class MaxSumSubarrayTests
    {
        private readonly MaxSumSubarray _service;

        public MaxSumSubarrayTests()
        {
            _service = new MaxSumSubarray();
        }

        [Fact()]
        public void SolveTest()
        {
            var actual = _service.Solve(new int[] { 4, 2, 1, 7, 8, 1, 2, 8, 1, 0 }, 3);

            Assert.Equal(16, actual);
        }
    }
}
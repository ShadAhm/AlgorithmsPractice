using Xunit;
using AlgorithmsPractice.Techniques.SlidingWindow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPractice.Techniques.SlidingWindow.Tests
{
    public class SmallestSubarrayGivenSumTests
    {
        private readonly SmallestSubarrayGivenSum _service;

        public SmallestSubarrayGivenSumTests()
        {
            _service = new SmallestSubarrayGivenSum();
        }

        [Fact()]
        public void SolveTest()
        {
            var actual = _service.Solve(new int[] { 1, 2, 5, 7, 8 }, 8);
            Assert.Equal(1, actual);
        }
    }
}
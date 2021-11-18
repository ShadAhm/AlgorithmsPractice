using Xunit;
using AlgorithmsForPracticing.Algo.CoinStacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsForPracticing.Algo.CoinStacks.Tests
{
    public class CoinStacksSolverTests
    {
        private readonly CoinStacksSolver _service;

        public CoinStacksSolverTests()
        {
            _service = new CoinStacksSolver();
        }

        [Theory]
        [InlineData(new[] { 2, 3, 1, 3 })]
        [InlineData(new[] { 2, 3, 3, 1 })]
        [InlineData(new[] { 3, 2, 1, 3 })]
        [InlineData(new[] { 3, 3, 1, 2 })]
        public void Test1(int[] inputs)
        {
            var result = _service.Solve(inputs);

            Assert.Equal(5, result);
        }

        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(1, 2, 0)]
        [InlineData(1, 3, 0)]
        [InlineData(2, 3, 1)]
        public void WhoShouldReceiveTest(int left, int right, int direction)
        {
            var result = _service.WhoShouldReceive(left, right);

            Assert.Equal(direction, result);
        }
    }
}
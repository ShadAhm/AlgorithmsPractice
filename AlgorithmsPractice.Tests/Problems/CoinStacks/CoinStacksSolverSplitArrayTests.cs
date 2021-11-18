using Xunit;
using AlgorithmsPractice.Problems.CoinStacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPractice.Problems.CoinStacks.Tests
{
    public class CoinStacksSolverSplitArrayTests
    {
        private readonly CoinStacksSolverSplitArray _service;

        public CoinStacksSolverSplitArrayTests()
        {
            _service = new CoinStacksSolverSplitArray();
        }

        [Theory]
        [InlineData(new[] { 2, 3, 1, 3 })]
        public void Test1(int[] inputs)
        {
            var result = _service.Solve(inputs);

            Assert.Equal(5, result);
        }

        [Theory]
        [InlineData(new[] { 3, 7, 0, 5 })]
        public void Test2(int[] inputs)
        {
            var result = _service.Solve(inputs);

            Assert.Equal(9, result);
        }

        [Theory]
        [InlineData(new[] { 1, 1, 1, 1 })]
        public void Test3(int[] inputs)
        {
            var result = _service.Solve(inputs);

            Assert.Equal(1, result);
        }
    }
}
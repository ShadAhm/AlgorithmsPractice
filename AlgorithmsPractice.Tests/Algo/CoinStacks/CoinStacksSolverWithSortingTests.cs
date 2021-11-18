using Xunit;
using AlgorithmsForPracticing.Algo.CoinStacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsForPracticing.Algo.CoinStacks.Tests
{
    public class CoinStacksSolverWithSortingTests
    {
        private readonly CoinStacksSolverWithSorting _service;

        public CoinStacksSolverWithSortingTests()
        {
            _service = new CoinStacksSolverWithSorting();
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

            Assert.Equal(10, result);
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
using Xunit;
using AlgorithmsPractice.Techniques.DynamicProgrammingMemoization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPractice.Techniques.DynamicProgrammingMemoization.Tests
{
    public class GridTravellerSolverTests
    {
        private readonly GridTravellerSolver _service;

        public GridTravellerSolverTests()
        {
            _service = new GridTravellerSolver(); 
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(2, 3, 3)]
        [InlineData(3, 2, 3)]
        [InlineData(3, 3, 6)]
        [InlineData(18, 18, 2333606220)]
        public void SolveTest(uint rows, uint columns, uint expectedResult)
        {
            var actual = _service.Solve(rows, columns);

            Assert.Equal(actual, expectedResult);
        }
    }
}
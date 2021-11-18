using Xunit;
using AlgorithmsPractice.Problems.ImaginaryCodingInterview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPractice.Problems.ImaginaryCodingInterview.Tests
{
    public class ImaginaryCodingInterviewSolverTests
    {
        ImaginaryCodingInterviewSolver _imaginaryCodingInterviewSolver;

        public ImaginaryCodingInterviewSolverTests()
        {
            _imaginaryCodingInterviewSolver = new ImaginaryCodingInterviewSolver();
        }

        [Theory()]
        [InlineData(new int[] { 5, 5, 10, 10, 15, 15, 20, 20 }, 120, "qualified")]
        [InlineData(new int[] { 2, 3, 8, 6, 5, 12, 10, 18 }, 120, "qualified")]
        [InlineData(new int[] { 2, 3, 8, 6, 5, 12, 10, 18 }, 64, "qualified")]
        [InlineData(new int[] { 5, 5, 10, 10, 25, 15, 20, 20 }, 120, "disqualified")]
        [InlineData(new int[] { 5, 5, 10, 10, 15, 15, 20 }, 120, "disqualified")]
        [InlineData(new int[] { 5, 5, 10, 10, 15, 15, 20, 20 }, 130, "disqualified")]
        [InlineData(new int[] { 5, 5, 10, 10, 15, 20, 50 }, 160, "disqualified")]
        [InlineData(new int[] { 5, 5, 10, 10, 15, 15, 40 }, 120, "disqualified")]
        [InlineData(new int[] { 10, 10, 15, 15, 20, 20 }, 150, "disqualified")]
        [InlineData(new int[] { 5, 5, 10, 20, 15, 15, 20, 20 }, 140, "disqualified")]
        public void SolveTest(int[] arr, int tot, string expected)
        {
            var actual = _imaginaryCodingInterviewSolver.Solve(arr, tot);

            Assert.Equal(actual, expected);
        }
    }
}
using System;
using System.Diagnostics;
using NinetyNineProblems.Arithmetic;
using Xunit;

namespace NinetyNineProblems.Tests.Arithmetic
{
    public class P38Test
    {
        [Fact]
        public void ShouldReturnSameResult()
        {
            var result1 = this.RunWithStopWatch(P34.TotientPhi);
            var result2 = this.RunWithStopWatch(P37.Phi);

            Assert.Equal(result1, result2);
        }

        private int RunWithStopWatch(Func<int, int> solution)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            int result = solution.Invoke(10090);
            stopWatch.Stop();

            var timeSpan = stopWatch.Elapsed;

            return result;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Fibonacci.Test
{
    public class RecursiveFibonacciScenarios
    {
        private IFibonacci recursiveFib = new RecursiveFibonacci();

        [Fact]
        public void FirstOne()
        {
            var fibs = recursiveFib.Generate(1);

            Assert.Equal<int>(fibs, new int[] { 0 });
        }

        [Fact]
        public void FirstThree()
        {
            var fibs = recursiveFib.Generate(3);

            Assert.Equal<int>(fibs, new int[] { 0, 1, 1 });
        }

        [Fact]
        public void FirstTen()
        {
            var fibs = recursiveFib.Generate(10);

            Assert.Equal<int>(fibs, new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 });
        }

        [Fact]
        public void ThrowsErrorOnNonPositiveCount()
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                recursiveFib.Generate(-1);
            });
        }
    }

    public class LoopyFibonacciScenarios
    {
        private IFibonacci recursiveFib = new LoopyFibonacci();

        [Fact]
        public void FirstOne()
        {
            var fibs = recursiveFib.Generate(1);

            Assert.Equal<int>(fibs, new int[] { 0 });
        }

        [Fact]
        public void FirstThree()
        {
            var fibs = recursiveFib.Generate(3);

            Assert.Equal<int>(fibs, new int[] { 0, 1, 1 });
        }

        [Fact]
        public void FirstTen()
        {
            var fibs = recursiveFib.Generate(10);

            Assert.Equal<int>(fibs, new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 });
        }

        [Fact]
        public void ThrowsErrorOnNonPositiveCount()
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                recursiveFib.Generate(-1);
            });
        }
    }
}

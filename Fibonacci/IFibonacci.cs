using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public interface IFibonacci
    {
        IEnumerable<int> Generate(int count);
    }

    public class RecursiveFibonacci : IFibonacci
    {
        public IEnumerable<int> Generate(int count)
        {
            if (count <= 0) throw new ArgumentOutOfRangeException("count must be a positive int");

            if (count == 1)
                return new int[] { 0 };
            else if (count == 2)
                return new int[] { 0, 1 };
            else
            {
                var oldFibs = Generate(count - 1);
                var newNum = oldFibs.Skip(oldFibs.Count() - 2).Sum();
                return Enumerable.Concat(oldFibs, new int[] { newNum });
            }
        }
    }

    public class LoopyFibonacci : IFibonacci
    {
        public IEnumerable<int> Generate(int count)
        {
            if (count <= 0) throw new ArgumentOutOfRangeException("count must be a positive int");

            var fibs = new List<int>();
            for (int i = 0; i < count; i++)
            {
                if (i == 0)
                    fibs.Add(0);
                else if (i == 1)
                    fibs.Add(1);
                else
                {
                    fibs.Add(fibs[i - 1] + fibs[i - 2]);
                }
            }

            return fibs;
        }
    }
}

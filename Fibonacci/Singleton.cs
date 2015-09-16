using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public sealed class Singleton
    {
        private Singleton() { }

        private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());

        public static Singleton Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }

    public sealed class LazySingleton
    {
        private LazySingleton()
        { }

        private static readonly Lazy<LazySingleton> lazy = new Lazy<LazySingleton>(() => new LazySingleton());

        public static LazySingleton Instance
        {
            get
            {
                return lazy.Value;
            }
        }

    }
}

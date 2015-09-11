using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class BaseClass
    {
        public virtual void Method1()
        {
            Console.WriteLine("Base - Method1");
        }

        public void Method2()
        {
            Console.WriteLine("Base - Method2");
        }
    }

    class DerivedClass: BaseClass
    {
        public override void Method1()
        {
            Console.WriteLine("Derived - Method1");
            
        }

        public new void Method2()
        {
            Console.WriteLine("Derived - Method2");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BaseClass a = new BaseClass();
            DerivedClass b = new DerivedClass();
            BaseClass c = new DerivedClass();

            Console.WriteLine("\n\nObject a:");
            a.Method1();
            a.Method2();

            Console.WriteLine("\n\nObject b:");
            b.Method1();
            b.Method2();

            Console.WriteLine("\n\nObject c:");
            c.Method1();
            c.Method2();

            Console.ReadLine();
        }
    }
}

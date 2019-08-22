using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Ha
    {
        protected int a = 10;
        protected int b = 20;

    }
    class Hb : Ha
    {
        public void sum()
        {
            Console.WriteLine("sum is :{0}", a + b);
        }
    }
    class Hc : Ha
    {
        public void sub()
        {
            Console.WriteLine("sub is :{0}", a - b);
        }
    }
    class Class2
    {
        static void Main(string[] args)
        {
            new Hb().sum();
            new Hc().sub();
        }
    }
}

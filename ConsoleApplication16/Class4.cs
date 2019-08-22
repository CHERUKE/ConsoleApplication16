using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Ma
    {
        protected int a, b;
        public void Readab(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void Show()
        {
            Console.WriteLine("a = {0}  b ={1}", a, b);
        }

    }
    interface Ib
    {
        void Sum();
        void Sub();
    }
    interface Ic
    {
        void Mul();
        void Div();

    }
    class Md : Ma, Ib, Ic
    {
        public void Sum()
        {
            Console.WriteLine("sum of a and b is :{0}", a + b);
        }
        public void Sub()
        {
            Console.WriteLine("sub of a and b is :{0}", a - b);
        }
        public void Mul()
        {
            Console.WriteLine("Mul of a and b is :{0}", a * b);
        }
        public void Div()
        {
            Console.WriteLine("Div of a and b is :{0}", a / b);
        }

    }

    class Class4
    {
        static void Main(string[] args)
        {
            Md p = new Md();
            p.Readab(5, 2);
            p.Show();
            p.Sum();
            p.Sub();
            p.Mul();
            p.Div();

        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    abstract class Abc
    {
        protected int a, b;
        public void Read()
        {
            Console.Write("Enter a value : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter b value : ");
            b = int.Parse(Console.ReadLine());
        }
        public void Show()
        {
            Console.WriteLine("a = {0}  b = {1}", a, b);
        }
        public abstract void sum();
    }
    class Child : Abc
    {
        public override void sum()
        {
            Console.WriteLine(" sum is :{0}", a + b);
        }
        public void sub()
        {
            Console.WriteLine(" sub is :{0}", a - b);
        }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            Child p = new Child();
            p.Read();
            p.Show();
            p.sum();
            p.sub();
        }
    }
}

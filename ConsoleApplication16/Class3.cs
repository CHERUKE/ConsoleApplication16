using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class pare
    {
        public virtual void Hi()
        {
            Console.WriteLine("hi this a hi method from parent class");
        }
    }
    class chil : pare
    {
        public void bye()
        {
            Console.WriteLine("hi this bye mehod from child class");
        }
        public override void Hi()
        {
            Console.WriteLine("hi this is hi method definrd in child class");
        }
    }
    class class3
    {
        static void Main(string[] args)
        {
            pare p;
            p = new chil();
            p.Hi();
            p = new pare();
            p.Hi();
            chil q;
            q = new chil();
            q.bye();
           
        }
    }
}

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_superclass
{
    class A
    {
        protected int a;
        public virtual void print()
        {
            Console.WriteLine(a);
        }
    }

    class B : A 
    {
        int a;

        public B(int x,int y)
        {
            base.a = x;
            this.a = y;
        }

        public override void print()
        {
            base.print();
            Console.WriteLine(a);
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
          B b = new B(1,2);
            b.print();

            Console.ReadKey();
        }
    }
}*/

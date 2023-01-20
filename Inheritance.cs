using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_superclass
{
    public class Calculator
    {
        protected int x;
        protected int y;

        public Calculator(int x, int y) 
        {
            this.x = x;
            this.y = y;
        }

        public int plus() 
        {
            return this.x+this.y;
        }
    }

    class BetterCalculator: Calculator
    {
        public BetterCalculator(int x, int y): base(x, y)
        {

        }

        public int minus()
        {
            return this.x-this.y;
        }
    }

    class MultiplyCalculator: BetterCalculator
    {
        public MultiplyCalculator(int x, int y): base(x, y)
        {

        }

        public int multi() 
        {
            return this.x*this.y;
        }
    }

    class DivisionCalculator: MultiplyCalculator
    {
        public DivisionCalculator(int x, int y): base(x, y)
        {

        }

        public double divide()
        { 
            return (float)this.x/this.y;
        }
    }

    internal class Inheritance
    {
        static void Main(string[] args)
        {
            DivisionCalculator bc = new DivisionCalculator(10, 50);

            Console.WriteLine("Plus Result: " + bc.plus());
            Console.WriteLine("Minus Result:" + bc.minus());
            Console.WriteLine("Multi Result: " + bc.multi());
            Console.WriteLine("Divide Result: " + bc.divide());
            Console.ReadKey();
        }
    }
}

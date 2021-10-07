using System;

namespace polymorphism
{
    public class Calculate
    {
        public void AddNumbers(int a, int b)
        {
            Console.WriteLine("a + b = {0}", a + b);
        }
        public void AddNumbers(int a, int b, int c)
        {
            Console.WriteLine("a + b + c = {0}", a + b + c);
        }

    }

    public class pClass
    {
        public virtual void hair()
        {
            Console.WriteLine("brown");
        }
    }
    public class cClass : pClass
    {
        public override void hair()
        {
            Console.WriteLine("black");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculate c = new Calculate();

            //compile time polymorphism
            c.AddNumbers(1, 2);
            c.AddNumbers(1, 2, 3);

            //runtime polymorphism
            cClass d = new cClass();
            d.hair();
            pClass b = new pClass();
            b.hair();

        
        }
    }
}

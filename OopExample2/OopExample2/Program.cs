using System;

namespace OopExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Console.WriteLine(circle.getArea());
            Circle circle1 = new Circle(2.0);
            Console.WriteLine(circle1.getArea());
            Circle circle2 = new Circle(3.0,"blue");
            Console.WriteLine(circle2.getArea());

            Cylinder cylinder = new Cylinder();
            Console.WriteLine(cylinder.getVolume());
            Cylinder cylinder1 = new Cylinder(2.0);
            Console.WriteLine(cylinder1.getVolume());
            Cylinder cylinder2 = new Cylinder(3.0,2.0);
            Console.WriteLine(cylinder2.getVolume());
            Cylinder cylinder3 = new Cylinder(4.0, 3.0,"blue");
            Console.WriteLine(cylinder3.getVolume());
        }
    }
}

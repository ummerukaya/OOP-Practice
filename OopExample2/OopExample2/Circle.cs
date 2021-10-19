using System;
using System.Collections.Generic;
using System.Text;

namespace OopExample2
{
    class Circle
    {
        private double radius = 1.0;
        private string color = "red";
        public Circle()
        {
            
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius,string color)
        {
            this.radius = radius;
            this.color = color;
        }
        public double getRadius()
        {
            return this.radius;
        }
        public void setRadius(double radius)
        {
            this.radius = radius;
        }
        public string getColor()
        {
            return this.color;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public double getArea()
        {
            Console.Write(toString()+" ");
            return (Math.PI * this.radius*this.radius);
        }
        public string toString()
        {
            string r = Convert.ToString(this.radius);
            string c = this.color;
            return c;
        }
    }
}

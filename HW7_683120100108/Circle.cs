using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab7
{
    using System;

    class Circle
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Area()
        {
            return Math.PI * radius * radius;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Circle");
            Console.WriteLine($"radius = {radius}");
            Console.WriteLine($"area = {Area():F2}");
        }
    }

}

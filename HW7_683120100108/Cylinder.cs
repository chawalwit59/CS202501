using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab7
{

    class Cylinder
    {
        private double radius;
        private double length;

        public Cylinder(double radius, double length)
        {
            this.radius = radius;
            this.length = length;
        }

        public double Area()
        {
            return 2 * Math.PI * radius * (radius + length);
        }

        public double Volume()
        {
            return Math.PI * radius * radius * length;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Cylinder");
            Console.WriteLine($"radius = {radius}, length = {length}");
            Console.WriteLine($"surface area = {Area():F2}");
            Console.WriteLine($"volume = {Volume():F2}");
        }
    }

}

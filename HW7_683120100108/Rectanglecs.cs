using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab7
{
    

    class Rectangle
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Area()
        {
            return width * height;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Rectangle");
            Console.WriteLine($"width = {width}, height = {height}");
            Console.WriteLine($"area = {Area():F2}");
        }
    }

}

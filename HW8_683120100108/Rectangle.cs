using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_OOP
{
    public class Rectangle : Shape
    {
        protected double width;
        protected double height;

        public Rectangle(string name, double width, double height)
            : base(name)
        {
            this.width = width;
            this.height = height;
        }

        public override double Area()
        {
            return width * height;
        }
    }

}

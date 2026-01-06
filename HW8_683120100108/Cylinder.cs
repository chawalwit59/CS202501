using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_OOP
{
    public class Cylinder : Circle
    {
        private double length;

        public Cylinder(string name, double radius, double length)
            : base(name, radius)
        {
            this.length = length;
        }

        public double Volume()
        {
            return Area() * length;
        }
    }

}

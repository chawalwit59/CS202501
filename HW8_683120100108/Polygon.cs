using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_OOP
{
    public class Polygon : Rectangle
    {
        private int n;

        public Polygon(string name, double width, double height, int n)
            : base(name, width, height)
        {
            this.n = n;
        }

        public double Volume()
        {
            return Area() * n;
        }
    }

}

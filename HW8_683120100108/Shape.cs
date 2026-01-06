using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_OOP
{
    using System;

    public class Shape
    {
        protected string name;

        public Shape(string name)
        {
            this.name = name;
        }

        public virtual double Area()
        {
            return 0.0;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Shape name: " + name);
        }
    }

}

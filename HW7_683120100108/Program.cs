using System.Drawing;

namespace CS_Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(5);
            c.PrintInfo();

            Rectangle r = new Rectangle(4, 6);
            r.PrintInfo();

            Cylinder cy = new Cylinder(3, 10);
            cy.PrintInfo();
        }
    }
}

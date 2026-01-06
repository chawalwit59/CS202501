using CS_OOP;

class Program
{
    static void Main()
    {
        Circle c = new Circle("Circle", 5);
        Console.WriteLine("Area Circle = " + c.Area());

        Cylinder cy = new Cylinder("Cylinder", 3, 10);
        Console.WriteLine("Volume Cylinder = " + cy.Volume());

        Rectangle r = new Rectangle("Rectangle", 4, 6);
        Console.WriteLine("Area Rectangle = " + r.Area());

        Polygon p = new Polygon("Polygon", 4, 6, 5);
        Console.WriteLine("Volume Polygon = " + p.Volume());
    }
}

public class Cylinder extends Circle {
    private double length;

    public Cylinder(String name, double radius, double length) {
        super(name, radius);
        this.length = length;
    }

    public double volume() {
        return area() * length;
    }
}

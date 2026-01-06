public class Polygon extends Rectangle {
    private int n;

    public Polygon(String name, double width, double height, int n) {
        super(name, width, height);
        this.n = n;
    }

    public double volume() {
        return area() * n;
    }
}

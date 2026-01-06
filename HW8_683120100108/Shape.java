public class Shape {
    protected String name;

    public Shape(String name) {
        this.name = name;
    }

    public double area() {
        return 0;
    }

    public void printInfo() {
        System.out.println("Shape: " + name);
    }
}

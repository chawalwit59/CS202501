#include <iostream>
#include <cmath>
using namespace std;

const double PI = 3.141592653589793;

// ================= Shape =================
class Shape {
protected:
    string name;

public:
    Shape(string name) {
        this->name = name;
    }

    virtual double area() {
        return 0.0;
    }

    void printInfo() {
        cout << "Shape name: " << name << endl;
    }
};

// ================= Circle =================
class Circle : public Shape {
protected:
    double radius;

public:
    Circle(string name, double radius)
        : Shape(name) {
        this->radius = radius;
    }

    double area() override {
        return PI * radius * radius;
    }

};

// ================= Cylinder =================
class Cylinder : public Circle {
private:
    double length;

public:
    Cylinder(string name, double radius, double length)
        : Circle(name, radius) {
        this->length = length;
    }

    double volume() {
        return area() * length;
    }
};

// ================= Rectangle =================
class Rectangle : public Shape {
protected:
    double width;
    double height;

public:
    Rectangle(string name, double width, double height)
        : Shape(name) {
        this->width = width;
        this->height = height;
    }

    double area() override {
        return width * height;
    }
};

// ================= Polygon =================
class Polygon : public Rectangle {
private:
    int n;

public:
    Polygon(string name, double width, double height, int n)
        : Rectangle(name, width, height) {
        this->n = n;
    }

    double volume() {
        return area() * n;
    }
};

// ================= main =================
int main() {
    Circle c("Circle", 5);
    cout << "Area Circle = " << c.area() << endl;

    Cylinder cy("Cylinder", 3, 10);
    cout << "Volume Cylinder = " << cy.volume() << endl;

    Rectangle r("Rectangle", 4, 6);
    cout << "Area Rectangle = " << r.area() << endl;

    Polygon p("Polygon", 4, 6, 5);
    cout << "Volume Polygon = " << p.volume() << endl;

    return 0;
}

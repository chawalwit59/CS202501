import math

class Shape:
    def __init__(self, name):
        self._name = name

    def area(self):
        return 0.0


class Circle(Shape):
    def __init__(self, name, radius):
        super().__init__(name)
        self._radius = radius

    def area(self):
        return math.pi * self._radius ** 2


class Cylinder(Circle):
    def __init__(self, name, radius, length):
        super().__init__(name, radius)
        self._length = length

    def volume(self):
        return self.area() * self._length


class Rectangle(Shape):
    def __init__(self, name, width, height):
        super().__init__(name)
        self._width = width
        self._height = height

    def area(self):
        return self._width * self._height


class Polygon(Rectangle):
    def __init__(self, name, width, height, n):
        super().__init__(name, width, height)
        self._n = n

    def volume(self):
        return self.area() * self._n


if __name__ == "__main__":
    c = Circle("Circle", 5)
    print("Area Circle =", c.area())

    cy = Cylinder("Cylinder", 3, 10)
    print("Volume Cylinder =", cy.volume())

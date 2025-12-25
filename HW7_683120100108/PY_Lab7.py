import math

class Circle:
    def __init__(self, radius):
        self.__radius = radius

    @property
    def radius(self):
        return self.__radius
    
    @radius.setter
    def radius(self, value):
        self.__radius = value

    def area(self):
        return math.pi * self.__radius ** 2
    
    def printInfo(self):
        print("Circle")
        print(f"radius = {self.__radius}")
        print(f"area = {self.area():.2f}")


class Rectanle:
    def __init__(self, width, height):
        self.__width = width
        self.__height = height

    @property
    def width(self):
        return self.__width
    
    @property
    def heigth(self):
        return self.__height
    
    def area(self):
        return self.__width * self.__height
    

    def printInfo(self):
        print("Radtangle")
        print(f"width = {self.__width}, height = {self.__height}")
        print(f"area = {self.area():.2f}")


class Cylinder:
    def __init__(self, radius, length):
        self.__radius = radius
        self.__length = length

    @property
    def radius(self):
        return self.__radius

    @property
    def length(self):
        return self.__length

    def area(self):
        return 2 * math.pi * self.__radius * (self.__radius + self.__length)

    def volume(self):   
        return math.pi * self.__radius ** 2 * self.__length

    def printInfo(self):
        print("Cylinder")
        print(f"radius = {self.__radius}, length = {self.__length}")
        print(f"surface area = {self.area():.2f}")
        print(f"volume = {self.volume():.2f}")



#======== main =======
c = Circle(5)
c.printInfo()

r = Rectanle(4, 6)
r.printInfo()

cy = Cylinder(3, 10)
cy.printInfo()
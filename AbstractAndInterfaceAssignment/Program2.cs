using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2.Write a C# program to create an abstract class Shape with abstract methods calculateArea()
// and calculatePerimeter(). 
//Create subclasses Circle and Triangle that inherit the Shape class and implement the respective methods 
//to calculate the area and perimeter of each shape.


abstract class Shape
{
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
}

class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }
}

class Triangle : Shape
{
    private double a, b, c;

    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public override double CalculateArea()
    {
        double s = (a + b + c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

    public override double CalculatePerimeter()
    {
        return a + b + c;
    }
}

class Program
{
    //static void Main()
    //{
    //    Shape circle = new Circle(5);
    //    Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
    //    Console.WriteLine($"Circle Perimeter: {circle.CalculatePerimeter()}");

    //    Shape triangle = new Triangle(3, 4, 5);
    //    Console.WriteLine($"Triangle Area: {triangle.CalculateArea()}");
    //    Console.WriteLine($"Triangle Perimeter: {triangle.CalculatePerimeter()}");
    //}
}


using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        Square square = new Square("blue", 5);
        Rectangle rectangle = new Rectangle("red", 2.5, 5);
        Circle circle = new Circle("green", 5);

        string color = square.GetColor();
        string color1 = rectangle.GetColor();
        string color2 = circle.GetColor();

        double squareArea = square.GetArea();
        double rectangleArea = rectangle.GetArea();
        double circleArea = circle.GetArea();

        Console.WriteLine($"Square: {color}, {squareArea}");
        Console.WriteLine($"Rectangle: {color1}, {rectangleArea}");
        Console.WriteLine($"Circle: {color2}, {circleArea}");
    }
}
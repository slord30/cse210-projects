using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square("purple", 4.5);
        shapes.Add(square1);

        Rectangle rectangle1 = new Rectangle("green", 3.6, 2);
        shapes.Add(rectangle1);

        Circle circle1 = new Circle("red", 8);
        shapes.Add(circle1);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();
            double roundArea = Math.Round(area, 2);

            Console.WriteLine($"The {color} shape has an area of {roundArea}.");
        }
        

    }
}
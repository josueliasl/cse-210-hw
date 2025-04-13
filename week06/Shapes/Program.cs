using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square s1 = new Square("Red", 4);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 5, 6);
        shapes.Add(s2);

        Circle s3 = new Circle("Blue", 3);
        shapes.Add(s3);
    foreach (Shape shape in shapes)
    {
        string color = shape.GetColor();
        double area = shape.GetArea();
        Console.WriteLine($"The shape color is {color} and the area is {area}");
    }
    }
}
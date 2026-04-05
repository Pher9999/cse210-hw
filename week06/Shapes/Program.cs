using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        List<Shape> shapes = new List<Shape>();
        Square s1 = new Square("Red", 3);
        shapes.Add(s1);
        Rectangle r1 = new Rectangle("Blue", 4, 5);
        shapes.Add(r1);
        Circle circle1 = new Circle("Green", 2);
        shapes.Add(circle1);
        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();


            Console.WriteLine($"Shape: {color} shape has an area of {area}");
        }
    }
}
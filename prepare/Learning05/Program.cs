using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(25, "Red");
        Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle(15, 25, "green");
        Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle(14, "blue");
        Console.WriteLine(circle.GetArea());

        List<Shape> holdShapes = new List<Shape>();
        holdShapes.Add(square);
        holdShapes.Add(rectangle);
        holdShapes.Add(circle);

        foreach (Shape shape in holdShapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}
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
    }
}
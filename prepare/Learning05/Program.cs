using System;

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle("Blue", 12, 10);
        Square square = new Square("Green", 12);
        Circle circle = new Circle("Purple", 12);
        
        List<Shape> shapes = new List<Shape>();
        shapes.Add(rectangle);
        shapes.Add(square);
        shapes.Add(circle);

        foreach(Shape shape in shapes){
            Console.WriteLine(shape.GetArea());
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Square shape1 = new Square("Blue", 3);
        Rectangle shape2 = new Rectangle("Yellow", 2, 5);
        Circle shape3 = new Circle("Red", 2.5);

        List<Shape> shapes = new List<Shape> {shape1, shape2, shape3};
        foreach (Shape shape in shapes) {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}
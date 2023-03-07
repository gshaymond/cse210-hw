using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square shape1 = new Square("Blue", 7);
        // Console.WriteLine(shape1.GetColor());
        // Console.WriteLine(shape1.GetArea());
        shapes.Add(shape1);

        Rectangle shape2 = new Rectangle("Green", 4, 6);
        // Console.WriteLine(shape2.GetColor());
        // Console.WriteLine(shape2.GetArea());
        shapes.Add(shape2);

        Circle shape3 = new Circle("Purple", 9);
        // Console.WriteLine(shape3.GetColor());
        // Console.WriteLine(shape3.GetArea());
        shapes.Add(shape3);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}
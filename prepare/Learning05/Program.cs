using System;

class Program
{
    static void Main(string[] args)
    {   
       List<Shape> shapes = new List<Shape>();

       Square square1 = new Square("Red", 3);
       shapes.Add(square1);

       Rectangle rectangle1 = new Rectangle("Blue", 4, 5);
       shapes.Add(rectangle1);

       Circle circle1 = new Circle("Green", 6);
       shapes.Add(circle1);

        // Add-ons 

        Square square2 = new Square("Lila", 5);
        shapes.Add(square2);

        Rectangle rectangle2 = new Rectangle("Yellow",2,4);
        shapes.Add(rectangle2);

        Circle circle2 = new Circle("Orange", 2.5);
        shapes.Add(circle2);

       foreach (Shape s in shapes)
       {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
       }
    }
}
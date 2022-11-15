using System;

public class Program
{
    private static void Main(string[] args)
    {
        var Circle = new Circle(4);
        var Square = new Square(4);
        var Triangle = new Triangle(4, 2, 5);


        Shape shape1 = Circle;
        Shape shape2 = Square;
        Shape shape3 = Triangle;


        Console.WriteLine(shape1.Perimetr());
        Console.WriteLine(shape1.Area());

        Console.WriteLine(shape2.Perimetr());
        Console.WriteLine(shape2.Area());

        Console.WriteLine(shape3.Perimetr());
        Console.WriteLine(shape3.Area());

    }
}
public abstract class Shape
{


    public abstract double Perimetr();

    public abstract double Area();


}

public abstract class ShapeWithEqualSide : Shape
{
    public double Length { get; set; }
    public ShapeWithEqualSide(double r)
    {
        Length = r;
    }


}
public class Circle : ShapeWithEqualSide
{

    public Circle(double r) : base(r)
    {
    }


    public override double Perimetr()
    {
        return 2 * Math.PI * Length;
    }
    public override double Area()
    {
        return Math.PI * Math.Pow(Length, 2);
    }

}
public class Square : ShapeWithEqualSide
{
    public Square(double a) : base(a)
    {

    }
    public override double Perimetr()
    {
        return Length * 4;
    }

    public override double Area()
    {
        return Math.Pow(Length, 2);
    }
}
public class Triangle : Shape
{
    double p;
    public double Side1 { get; set; }
    public double Side2 { get; set; }
    public double Side3 { get; set; }
    public Triangle(double a, double b, double c)
    {
        Side1 = a;
        Side2 = b;
        Side3 = c;

    }
    public override double Perimetr()
    {
        return Side1 + Side2 + Side3;
    }
    public override double Area()
    {
        p = (Side1 + Side2 + Side3) / 2;
        return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
    }
}



using System;

abstract class Shape
{
    public abstract int GetArea();
}

class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public override int GetArea() => Width * Height;
}

class Square : Shape
{
    public int Side { get; set; }

    public override int GetArea() => Side * Side;
}

class Program
{
    static void Main(string[] args)
    {
        Shape rect = new Rectangle { Width = 5, Height = 10 };
        Console.WriteLine(rect.GetArea()); 

        Shape sq = new Square { Side = 5 };
        Console.WriteLine(sq.GetArea());   
    }
}
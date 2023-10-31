using System.Drawing;

namespace Prototype;

public abstract class Shape
{
    public double X { get; }
    public double Y { get; }
    
    public Color Color { get; }

    protected Shape(double x, double y, Color color)
    {
        X = x;
        Y = y;
        Color = color;
    }

    protected Shape(Shape shape)
    {
        X = shape.X;
        Y = shape.Y;
        Color = shape.Color;
    }

    public abstract Shape Clone();

    public abstract override string ToString();
}
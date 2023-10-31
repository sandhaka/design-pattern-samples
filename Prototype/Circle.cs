using System.Drawing;
using System.Text.Json;

namespace Prototype;

public class Circle : Shape
{
    public int Radius { get; }

    public Circle(double x, double y, Color color, int radius) 
        : base(x, y, color)
    {
        Radius = radius;
    }

    private Circle(Circle source) : base(source)
    {
        Radius = source.Radius;
    }

    public override Shape Clone() => new Circle(this);
    
    public override string ToString() =>
        JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
}
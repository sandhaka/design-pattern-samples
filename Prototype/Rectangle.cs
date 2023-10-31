using System.Drawing;
using System.Text.Json;

namespace Prototype;

public class Rectangle : Shape
{
    public int Width { get; }
    public int Height { get; }

    public Rectangle(double x, double y, Color color, int width, int height)
        : base(x, y, color)
    {
        Width = width;
        Height = height;
    }
    
    private Rectangle(Rectangle source) : base(source)
    {
        Width = source.Width;
        Height = source.Height;
    }
    
    public override Shape Clone() => new Rectangle(this);

    public override string ToString() =>
        JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
}
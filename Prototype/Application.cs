using System.Collections.ObjectModel;
using System.Drawing;

namespace Prototype;

public class Application
{
    private readonly Collection<Shape> _shapes = new();

    public Application()
    {
        var circle = new Circle(0, 0, Color.Aqua, 10);
        var rectangle = new Rectangle(10, 15, Color.Aquamarine, 100, 50);
        
        _shapes.Add(circle);
        _shapes.Add(rectangle);
    }

    public void Run()
    {
        var copies = new Collection<Shape>();

        foreach (var shape in _shapes)
            copies.Add(shape.Clone());

        Console.WriteLine("Copied shapes: ");
        
        foreach (var shape in copies)
        {
            Console.WriteLine(shape.GetType().Name);
            Console.WriteLine(shape.ToString());
        }
    }
}
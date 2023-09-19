using System.Runtime.CompilerServices;

namespace ThePoint;

class Program
{
    static void Main(string[] args)
    {
        List<Point> points = new List<Point>();
        points.Add(new Point());
        points.Add(new Point(2, 3));
        points.Add(new Point(-4, 0));

        foreach (Point p in points)
        {
            Console.WriteLine(p.ToString());
        }

        Console.ReadLine();
    }
}

public class Point
{
    public int X { get; }
    public int Y { get; }
    public Point() : this(0, 0)
    {
    }
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    public override string ToString()
    {
        return $"({X},{Y})";
    }
}
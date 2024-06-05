using System;

namespace PointInSpace;

public class Point
{
    private double x;
    private double y;
    private double z;
    
    public Point(double x, double y, double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }


    public bool AreCoordinatesIntegers()
    {
        return x % 1 == 0 && y % 1 == 0 && z % 1 == 0;
    }


    public bool IsInFirstOctant()
    {
        return x > 0 && y > 0 && z > 0;
    }


    public static Point InputPoint()
    {
        Console.Write("Enter x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter z: ");
        double z = Convert.ToDouble(Console.ReadLine());

        return new Point(x, y, z);
    }


    public void PrintResults()
    {
        Console.WriteLine($"Point coordinates: ({x}, {y}, {z})");
        Console.WriteLine("All coordinates are integers: " + AreCoordinatesIntegers());
        Console.WriteLine("Point is in the first octant: " + IsInFirstOctant());
    }
}

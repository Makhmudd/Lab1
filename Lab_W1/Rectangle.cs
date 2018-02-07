using System;

public class Rectangle
{
    public int Width, Length, Area, Perimetr;
    public float FindArea(int a, int b)
    {
        return a * b;
    }
    public int FindPerimetr(int a, int b)
    {
        return 2 * (a + b);
    }
    public Rectangle()
    {
        Width = 0;
        Length = 0;
    }
    public Rectangle(int a, int b)
    {
        Width = a;
        Length = b;
        Area = FindArea(a, b);
        Perimetr = FindPerimetr(a, b);
    }
    public override string ToString()
    {
        return Width + " " + Length + " " + Perimetr + " " + Area;
    }
}
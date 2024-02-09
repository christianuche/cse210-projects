using System;

public class Shape
{
    private string _color;

    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }

    public Shape(string color)
    {
        Color = color;
    }

    public virtual double GetArea()
    {
        return 0;  // To be implemented in derived classes
    }

    public string GetColor()
    {
        return Color;
    }
}

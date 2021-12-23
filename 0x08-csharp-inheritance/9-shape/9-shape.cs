using System;

/// <summary>Base class.</summary>
public class Shape
{
    /// <summary>This method is not fully implemented.</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>Derived class that inherits from Shape</summary>
public class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>Gets or sets the value of width.</summary>
    public int Width
    {
        get => width;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            else
            {
                width = value;
            }
        }
    }
    
    /// <summary>Gets or sets the value of height.</summary>
    public int Height
    {
        get => height;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            else
            {
                height = value;
            }
        }
    }

    /// <summary>Returns the area of a rectangle.</summary>
    public new int Area()
    {
        return width * height;
    }

    /// <summary>Overrides default string representation of a rectangle.</summary>
    public override string ToString()
    {
        return $"[Rectangle] {width} / {height}";
    }

}

/// <summary></summary>
public class Square : Rectangle
{
    private int size;

    /// <summary></summary>
    public int Size
    {
        get => size;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            else
            {
                size = Height = Width = value;
            }
        }
    }

     /// <summary>Overrides default string representation of a square.</summary>
    public override string ToString()
    {
        return $"[Square] {size} / {size}";
    }
}
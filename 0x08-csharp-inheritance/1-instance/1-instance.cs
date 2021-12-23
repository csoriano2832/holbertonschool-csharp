using System;

/// <summary>Provides static methods for objects.</summary>
public class Obj
{
    /// <summary>Returns True if the object is an instance of, or an instance of a class that inherits from, Array.</summary>
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj is Array)
        {
            return true;
        }
        return false;
    }
}

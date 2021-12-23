using System;

/// <summary>Provides static methods for objects.</summary>
public class Obj
{
    /// <summary>Returns True if the object is an int, otherwise returns False.</summary>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj.GetType() == typeof(int))
        {
            return true;
        }
        return false;
    }
}

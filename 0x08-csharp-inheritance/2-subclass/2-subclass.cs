using System;

/// <summary></summary>
public class Obj
{
    /// <summary></summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return (derivedType.IsSubclassOf(baseType));
    }
}

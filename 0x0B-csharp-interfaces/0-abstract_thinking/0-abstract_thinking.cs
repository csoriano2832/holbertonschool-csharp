using System;

abstract class Base
{
    public string name;

    public override string ToString()
    {
        var type = this.GetType().Name;

        return ($"{name} is a {type}");
    }
}

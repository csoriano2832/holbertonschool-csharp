using System;

///<summary>A generic Queue class</summary>
public class Queue<T>
{
    ///<summary>Returns the type of the Queue that was created</summary>
    public Type CheckType()
    {
        return typeof(T);
    }
}

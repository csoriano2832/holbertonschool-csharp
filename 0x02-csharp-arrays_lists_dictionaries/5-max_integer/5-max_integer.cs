using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        int max = 0;

        if (myList == null || myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return (-1);
        }

        myList.Sort();
        max = myList[myList.Count - 1];

        return (max);
    }
}

using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> divisibleList = new List<bool>();

        foreach (int number in myList)
        {
            if (number % 2 == 0)
            {
                divisibleList.Add(true);
            }
            else
            {
                divisibleList.Add(false);
            }
        }

        return (divisibleList);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> sortedKeys = new List<string>();

        foreach (KeyValuePair<string, string> kvp in myDict.OrderBy(key => key.Key))
        {
            Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
        }
    }
}

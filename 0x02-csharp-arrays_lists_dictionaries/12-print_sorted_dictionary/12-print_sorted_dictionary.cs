using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> sortedKeys = new List<string>();

        foreach (KeyValuePair<string, string> kvp in myDict)
        {
            sortedKeys.Add(kvp.Key);
        }
        sortedKeys.Sort();
        
        foreach (string str in sortedKeys)
        {
            Console.WriteLine("{0}: {1}", str, myDict[str]);
        }
    }
}

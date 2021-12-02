using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int bestScore = 0;
        string name = "";

        if (myList.Count == 0)
        {
            return ("None");
        }

        foreach (KeyValuePair<string, int> kvp in myList)
        {
            if (kvp.Value > bestScore)
            {
                name = kvp.Key;
                bestScore = kvp.Value;
            }
        }

        return (name);
    }
}

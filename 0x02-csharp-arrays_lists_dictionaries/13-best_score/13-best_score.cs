using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int bestScore;

        if (myList.Count == 0)
        {
            return ("None");
        }

        bestScore = myList.Values.Max();
        foreach (string key in myList.Keys)
        {
            if (myList[key] == bestScore)
            {
                return (key);
            }
        }

        return ("None");
    }
}

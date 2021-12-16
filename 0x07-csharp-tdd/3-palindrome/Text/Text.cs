using System;
using System.Linq;
using System.Collections.Generic;

namespace Text
{
    ///<summary>Performs operations on text string inputs.</summary>
    public class Str
    {
        ///<summary>Determines if text is a palindrome.</summary>
        public static bool IsPalindrome(string s)
        {
            List<char> strippedString = new List<char>();
            
            foreach (char letter in s)
            {
                if (!Char.IsPunctuation(letter) && !Char.IsWhiteSpace(letter))
                {
                    strippedString.Add(Char.ToLower(letter));
                }
            }
            
            if (strippedString.Count == 0)
                return (true);
            
            List<char> reversedString = new List<char>(strippedString);
            
            reversedString.Reverse();
            
            return (strippedString.SequenceEqual(reversedString));
        }
    }
}

using System;

namespace Text
{
    /// <summary>Provides some basic string manipulation functionality.</summary>
    public class Str
    {
        /// <summary>Determines how many words are in a string.</summary>
        /// <param name="s">A string.</param>
        /// <returns>Number of words in the string.</returns>
        public static int CamelCase(string s)
        {
            if (s == "" || s == null)
                return 0;
            
            int count = 0;
            
            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (Char.IsUpper(s[i]))
                    count++;
            }
            return (count + 1);
        }
    }
}
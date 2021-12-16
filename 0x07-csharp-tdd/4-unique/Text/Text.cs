using System;

namespace Text
{
    ///<summary>Provides string manipulation functionality.</summary>
    public class Str
    {
        /// <summary>Checks for first instance of non repeating characters in a string.</summary>
        /// <param name="s">A string of characters.</param>
        /// <returns>Index of first non-repeating character or -1 if there is no non-repeating instance.</returns>
        public static int UniqueChar(string s)
        {
            if (s == null)
                return -1;
            
            s = s.ToLower();
            
            char[] arr = s.ToCharArray();
            int c;
            
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                c = 0;
                
                for (int j = 0; j <= arr.Length - 1; j++)
                {
                    if (i != j)
                    {
                        if (arr[i] == arr[j])
                            c += 1;
                    }                    
                }
                
                if (c == 0)
                    return (i);
            }
            
            return -1;
        }
    }
}
using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>Represents basic math operations.</summary>
    public class Operations
    {
        /// <summary>Gets the max (biggest) number in a list.</summary>
        /// <param name="nums">A list of integers.</param>
        /// <returns>The max integer</returns>
        public static int Max(List<int> nums)
        {
            if (nums.Count == 0)
            {
                return 0;
            }

            int max = 0;
            
            nums.Sort();
            max = nums[nums.Count - 1];

            return (max);
        }
    }
}

using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        List<int> numbers = new List<int>();

        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return (null);
        }

        for (int i = 0; i < size; i++)
        {
            numbers.Add(i);
            Console.Write("{0:D}", i);
            if (i != size - 1)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();

        return (numbers);
    }
}

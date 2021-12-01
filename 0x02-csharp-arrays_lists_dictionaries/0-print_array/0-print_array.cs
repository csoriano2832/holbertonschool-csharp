using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        int[] array = new int[0];

        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return (null);
        }

        if (size > 0)
        {
            array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = i;
                
                Console.Write("{0:D}", array[i]);
                if (array[i] != size -1)
                {
                    Console.Write(" ");
                }
            }
        }

        Console.WriteLine();
        return (array);
    }
}

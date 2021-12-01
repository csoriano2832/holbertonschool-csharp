using System;

class Program
{
    static void Main(string[] args)
    {
        int i;
        int j;

        for (i = 0; i <= 8; i++)
        {
            for (j = 1; j <= 9; j++)
            {
                if (i != j && i < j)
                {
                    Console.Write("{0:D}", i);
                    Console.Write("{0:D}, ", j);
                }
            }
            if (i == 8 && j == 9)
            {
                Console.WriteLine("{0:D}{1:D}", i, j);
            }
        }
    }
}

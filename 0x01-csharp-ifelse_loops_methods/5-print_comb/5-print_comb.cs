using System;

class Program
{
    static void Main(string[] args)
    {
        int i;
        for (i = 0; i < 99; i++)
        {
            Console.Write("{0:D}{1:D}, ", (i / 10), (i % 10));
        }
        Console.Write("{0:D}{1:D}\n", (i / 10), (i % 10));
    }
}

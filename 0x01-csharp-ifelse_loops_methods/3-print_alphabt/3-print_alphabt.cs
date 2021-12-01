using System;

class Program
{
    static void Main(string[] args)
    {
        string alphabet = "abcdfghijklmnoprstuvwyxz\0";
        for (int i = 0; alphabet[i] != '\0'; i++)
        {
            Console.Write(alphabet[i]);
        }
    }
}

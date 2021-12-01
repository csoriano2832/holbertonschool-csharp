using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int lastnum = number % 10;
        Console.Write("The last digit of {0:D} is {1:D} ", number, lastnum);
        if (lastnum > 5)
        {
            Console.WriteLine("and is greater than 5");
        }
        else if (lastnum == 0)
        {
            Console.WriteLine("and is 0");
        }
        else
        {
            Console.WriteLine("and is less than 6 and not 0");
        }
    }
}

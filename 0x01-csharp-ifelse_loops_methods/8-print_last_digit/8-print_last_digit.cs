﻿using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int lastDigit = number % 10;

        if (lastDigit < 0)
        {
            lastDigit = lastDigit * -1;
        }
        Console.Write("{0:D}", lastDigit);
        return(lastDigit);
    }
}
using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int res = number % 10;
        if (res < 0)
        {
            res = res * -1;
        }
        Console.Write("{0}", res);
        return res;
    }
}

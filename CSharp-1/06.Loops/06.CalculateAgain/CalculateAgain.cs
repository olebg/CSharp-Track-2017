﻿using System;
using System.Numerics;

class CalculateAgain
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger k = BigInteger.Parse(Console.ReadLine());

        BigInteger nFac = 1;
        BigInteger kFac = 1;

        for (int i = 2, j = 2; i <= n; i++, j++)
        {
            if (j <= k)
            {
                kFac *= j;
            }
            nFac *= i;
        }

        BigInteger result = nFac / kFac;

        Console.WriteLine(result);
    }
}
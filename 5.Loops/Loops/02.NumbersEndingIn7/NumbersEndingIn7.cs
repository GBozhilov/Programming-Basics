﻿using System;

public class NumbersEndingIn7
{
    public static void Main()
    {
        for (int num = 1; num <= 1000; num++)
        {
            if (num % 10 == 7)
            {
                Console.WriteLine(num);
            }
        }
    }
}
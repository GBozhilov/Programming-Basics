﻿using System;

public class PrintingTriangle
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        PrintTriangle(n);
    }

    public static void PrintLine(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();
    }

    public static void PrintTriangle(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            PrintLine(1, i);
        }

        for (int i = n - 1; i > 0; i--)
        {
            PrintLine(1, i);
        }
    }
}
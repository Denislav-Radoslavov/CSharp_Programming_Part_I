﻿//Problem 5. The Biggest of 3 Numbers
//
//    Write a program that finds the biggest of three numbers.

using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.WriteLine("Write a three numbers: ");
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());
        if ((a > b) && (a > c))
        {
            Console.WriteLine(a);
        }
        else if ((b > a) && (b > c))
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine(c);
        }
    }
}

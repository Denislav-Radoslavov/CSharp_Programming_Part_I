﻿//Problem 2. Float or Double?
//
//    Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
//    Write a program to assign the numbers in variables and print them to ensure no precision is lost.

using System;

class FloatorDouble
{
    static void Main()
    {
        double numberA = 34.567839023;
        float numberB = 12.345f;
        double numberC = 8923.1234857;
        float numberD = 3456.091f;

        Console.WriteLine(numberA);
        Console.WriteLine(numberB);
        Console.WriteLine(numberC);
        Console.WriteLine(numberD);
    }
}
﻿//Problem 1. Declare Variables
//
//    Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, 
//      ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
//    Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

using System;

class DeclareVariables
{
    static void Main()
    {
        ushort number1 = 52130;
        sbyte number2 = -115;
        uint number3 = 4825932;
        byte number4 = 97;
        short number5 = -10000;

        Console.WriteLine(number1);
        Console.WriteLine(number2);
        Console.WriteLine(number3);
        Console.WriteLine(number4);
        Console.WriteLine(number5);
    }
}
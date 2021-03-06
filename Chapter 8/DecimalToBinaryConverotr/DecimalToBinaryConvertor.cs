﻿using System;

class DecimalToBinaryConvertor
{
    static void Main(string[] args)
    {
        string inputDecimalNumber = Console.ReadLine();
        long decimalNumber = long.Parse(inputDecimalNumber);

        if (decimalNumber < 0)
        {
            decimalNumber = decimalNumber ^ long.MinValue;
        }

        if (decimalNumber != 0)
        {
            string binaryRepresentation = null;
            while (decimalNumber != 0)
            {
                byte remainder = (byte)(decimalNumber % 2);
                binaryRepresentation = remainder + binaryRepresentation;
                decimalNumber /= 2;
            }

            int fillByte = binaryRepresentation.Length % 4;
            for (int i = 0; i < fillByte; i++)
            {
                binaryRepresentation = "0" + binaryRepresentation;
            }

            Console.WriteLine(binaryRepresentation);

        }
        else
        {
            Console.WriteLine(decimalNumber);
        }

    }
}

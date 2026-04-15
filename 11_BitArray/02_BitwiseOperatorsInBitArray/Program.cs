using System;
using System.Collections;

static class BitwiseOperatorsInBitArray
{
    static void Main(string[] args)
    {
        BitArray bits1 = new BitArray(new bool[] { true, false, false, true, true, true, false, false });
        BitArray bits2 = new BitArray(new bool[] { false, false, true, false, true, true, false, true });

        // Print arrays
        PrintArrays(bits1, bits2);

        // AND
        Console.WriteLine("\n\nBits1 AND Bits2:");
        PrintArrays(bits1, bits2);
        Console.WriteLine("---------------");
        Console.WriteLine(BitArrayToString(bits1.And(bits2)));

        // OR
        Console.WriteLine("\nBits1 OR Bits2");
        PrintArrays(bits1, bits2);
        Console.WriteLine("---------------");
        Console.WriteLine(BitArrayToString(bits1.Or(bits2)));

        // NOT
        Console.WriteLine("\nNOT Bits1");
        PrintArrays(bits1);
        Console.WriteLine("---------------");
        Console.WriteLine(BitArrayToString(bits1.Not()));

        // XOR
        Console.WriteLine("\nBits1 XOR Bits2");
        PrintArrays(bits1, bits2);
        Console.WriteLine("---------------");
        Console.WriteLine(BitArrayToString(bits1.Xor(bits2)));
    }

    static string BitArrayToString(BitArray bits)
    {
        char[] chars = new char[bits.Length];

        for (int i = 0; i < bits.Length; i++)
        {
            chars[i] = bits[i] ? '1' : '0';
        }

        return new string(chars);
    }

    static void PrintArrays(params BitArray[] bits)
    {
        foreach (var bitArr in bits)
        {
            Console.WriteLine(BitArrayToString(bitArr));
        }
    }
}

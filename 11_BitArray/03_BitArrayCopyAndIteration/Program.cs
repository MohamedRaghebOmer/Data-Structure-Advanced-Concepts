using System;
using System.Collections;

static class BitArrayCopyAndIteration
{
    static void Main(string[] args)
    {
        BitArray attendance = new BitArray(new[] { true, false, true, true, false, true, false, false });
        Console.WriteLine("Original bits: " + BitArrayToString(attendance));

        byte[] asBytes = new byte[(attendance.Length + 7) / 8];
        attendance.CopyTo(asBytes, 0);
        Console.WriteLine("As byte[0] : " + Convert.ToString(asBytes[0], 2).PadLeft(8, '0'));

        int[] asInts = new int[1];
        attendance.CopyTo(asInts, 0);
        Console.WriteLine("As int[0]  : " + asInts[0]);

        Console.WriteLine("\nSet bits index:");
        for (int i = 0; i < attendance.Count; i++)
        {
            if (attendance[i])
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine("\n\nIterate with foreach:");
        foreach (bool bit in attendance)
        {
            Console.Write(bit ? "1" : "0");
        }
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
}

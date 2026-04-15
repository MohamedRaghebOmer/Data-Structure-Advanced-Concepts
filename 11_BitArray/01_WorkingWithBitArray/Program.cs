using System;
using System.Collections;

static class WorkingWithBitArray
{
    static void Main(string[] args)
    {
        BitArray bits1 = new BitArray(10, false);
        Console.WriteLine(BitArrayToString(bits1));
        // Assign bits1 value to a bool var and print it
        for (int i = 0; i < bits1.Count; i++)
        {
            bool bitValue = bits1[i];
            Console.WriteLine("Bits1[{0}]: {1}", i, bitValue);
        }


        // Create a bit array from array of Booleans
        bool[] boolArray = { true, false, false, true, false, false, true, true};
        BitArray bitsFromBool = new BitArray(boolArray);
        Console.WriteLine("boolArray Content:\n{0}", BitArrayToString(bitsFromBool));
        for (int i = 0; i < bits1.Length; i++)
        {
            bool bitValue = bitsFromBool[i];
            Console.WriteLine("bitsFromBool[{0}]: {1}", i, bitValue);
        }


        // Create bit array from byte array
        byte[] byteArr = { 0XAA, 0X55 }; // 10101010, 01010101
        BitArray bitsFromByte = new BitArray(byteArr);
        Console.WriteLine("bitsFromByte: {0}", BitArrayToString(bitsFromByte));
        for (int i = 0; i < byteArr.Length; i++)
        {
            Console.WriteLine("bitsFromByte[{0}]: {1}", i, bitsFromByte[i]);
        }


        // Basic operations
        BitArray operations = new BitArray(8);
        operations.Set(0, true);
        operations.Set(1, false);
        operations[2] = true;
        operations[3] = false;

        // Print 'operations' value
        Console.WriteLine("Operations: " + BitArrayToString(operations));
        for (int i = 0; i < operations.Length; i++)
        {
            bool bitValue = operations[i];
            Console.WriteLine("bitValue[{0}]: {1}", i, bitValue);
        }

        operations.SetAll(true); // Set all array's values to true
        Console.WriteLine("Operations: " + BitArrayToString(operations));
        for (int i = 0; i < operations.Length; i++)
        {
            bool bitValue = operations[i];
            Console.WriteLine("bitValue[{0}]: {1}", i, bitValue);
        }
    }

    static string BitArrayToString(BitArray bitArray)
    {
        char[] charArray = new char[bitArray.Length];

        for (int i = 0; i < bitArray.Length; i++)
        {
            charArray[i] = bitArray[i]? '1' : '0';
        }

        return new string(charArray);
    }
}

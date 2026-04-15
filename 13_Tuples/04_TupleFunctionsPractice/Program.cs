using System;
using System.Linq;

static class TupleFunctionsPractice
{
    static void Main(string[] args)
    {
        var person = ParseFullName("Mohamed Ragheb Omer");
        Console.WriteLine("ParseFullName -> First: " + person.FirstName + ", Last: " + person.LastName);

        int[] numbers = { 7, 12, 3, 18, 9 };
        var minMax = GetMinMax(numbers);
        Console.WriteLine("GetMinMax -> Min: " + minMax.Min + ", Max: " + minMax.Max);

        var division = DivideWithRemainder(29, 4);
        Console.WriteLine("DivideWithRemainder -> Quotient: " + division.Quotient + ", Remainder: " + division.Remainder);

        var searchResult = TryFindIndex(numbers, 18);
        Console.WriteLine("TryFindIndex -> Found: " + searchResult.Found + ", Index: " + searchResult.Index);
    }

    static (string FirstName, string LastName) ParseFullName(string fullName)
    {
        string[] parts = fullName.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return (parts.First(), parts.Last());
    }

    static (int Min, int Max) GetMinMax(int[] values)
    {
        return (values.Min(), values.Max());
    }

    static (int Quotient, int Remainder) DivideWithRemainder(int dividend, int divisor)
    {
        return (dividend / divisor, dividend % divisor);
    }

    static (bool Found, int Index) TryFindIndex(int[] values, int target)
    {
        int index = Array.IndexOf(values, target);
        return (index >= 0, index);
    }
}

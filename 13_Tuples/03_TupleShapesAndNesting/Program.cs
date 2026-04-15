using System;

static class TupleShapesAndNesting
{
    static void Main(string[] args)
    {
        Tuple<int> oneItem = Tuple.Create(42);
        Tuple<int, string, double> threeItems = Tuple.Create(7, "Ava", 170.5);
        Tuple<int, int, int, int, int, int, int, Tuple<int>> eightItems =
            new Tuple<int, int, int, int, int, int, int, Tuple<int>>(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8));

        (int Id, string Name, bool IsActive) namedValueTuple = (101, "Noah", true);
        ((string City, string Country) Location, int Year, decimal Revenue) nestedValueTuple =
            (("Cairo", "Egypt"), 2026, 12500.75m);

        Console.WriteLine("Reference Tuple Shapes:");
        Console.WriteLine("1 item: " + oneItem.Item1);
        Console.WriteLine("3 items: " + threeItems.Item1 + ", " + threeItems.Item2 + ", " + threeItems.Item3);
        Console.WriteLine("8th item (Rest): " + eightItems.Rest.Item1);

        Console.WriteLine("\nValueTuple Shapes:");
        Console.WriteLine("Named: Id=" + namedValueTuple.Id + ", Name=" + namedValueTuple.Name + ", Active=" + namedValueTuple.IsActive);
        Console.WriteLine("Nested: " + nestedValueTuple.Location.City + ", " + nestedValueTuple.Location.Country +
                          " | Year=" + nestedValueTuple.Year + " | Revenue=" + nestedValueTuple.Revenue);
    }
}

using System;
using System.Linq;

static class LinqWithJaggedArray
{
    static void Main(string[] args)
    {
        int[][] ordersPerDay =
        {
            new[] { 12, 15, 18, 20 },
            new[] { 8, 9 },
            new[] { 25, 17, 10, 5, 13 },
            new[] { 30 }
        };

        Console.WriteLine("All Orders:");
        foreach (int[] week in ordersPerDay)
        {
            Console.WriteLine(string.Join(", ", week));
        }

        int totalOrders = ordersPerDay.SelectMany(week => week).Sum();
        double averageOrder = ordersPerDay.SelectMany(week => week).Average();
        int[] highOrders = ordersPerDay.SelectMany(week => week).Where(order => order >= 15).ToArray();

        Console.WriteLine("\nTotal Orders: " + totalOrders);
        Console.WriteLine("Average Orders: " + averageOrder.ToString("F2"));
        Console.WriteLine("Orders >= 15: " + string.Join(", ", highOrders));

        var mostProductiveWeek = ordersPerDay
            .Select((week, index) => new { Week = index + 1, Sum = week.Sum() })
            .OrderByDescending(item => item.Sum)
            .First();

        Console.WriteLine("Most Productive Week: Week " + mostProductiveWeek.Week + " (" + mostProductiveWeek.Sum + ")");
    }
}

using System;
using System.Linq;

static class JaggedArrayQuarterlySalesInsights
{
    static void Main(string[] args)
    {
        string[] quarters = { "Q1", "Q2", "Q3", "Q4" };
        int[][] monthlySalesByQuarter =
        {
            new[] { 12000, 13500, 12800 },
            new[] { 14000, 15000 },
            new[] { 16000, 15800, 17000, 17200 },
            new[] { 18000 }
        };

        var quarterSummary = quarters
            .Select((quarter, index) => new
            {
                Quarter = quarter,
                Values = monthlySalesByQuarter[index],
                Total = monthlySalesByQuarter[index].Sum(),
                Average = monthlySalesByQuarter[index].Average()
            })
            .ToArray();

        Console.WriteLine("Quarterly Sales Summary:");
        foreach (var item in quarterSummary)
        {
            Console.WriteLine(
                item.Quarter + " -> Total: " + item.Total +
                ", Average: " + item.Average.ToString("F2") +
                ", Months: [" + string.Join(", ", item.Values) + "]");
        }

        var bestQuarter = quarterSummary.OrderByDescending(item => item.Total).First();
        int companyWideTotal = monthlySalesByQuarter.SelectMany(values => values).Sum();

        Console.WriteLine("\nBest Quarter: " + bestQuarter.Quarter + " (" + bestQuarter.Total + ")");
        Console.WriteLine("Company-Wide Total Sales: " + companyWideTotal);
    }
}

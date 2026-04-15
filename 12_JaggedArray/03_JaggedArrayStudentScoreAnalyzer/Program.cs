using System;
using System.Linq;

static class JaggedArrayStudentScoreAnalyzer
{
    static void Main(string[] args)
    {
        string[] students = { "Ava", "Noah", "Mia", "Liam" };
        int[][] scores =
        {
            new[] { 88, 92, 79 },
            new[] { 95, 91 },
            new[] { 70, 75, 80, 85 },
            new[] { 99 }
        };

        var report = students
            .Select((name, index) => new
            {
                Name = name,
                Scores = scores[index],
                Average = scores[index].Average()
            })
            .OrderByDescending(item => item.Average)
            .ToArray();

        Console.WriteLine("Student Average Scores:");
        foreach (var item in report)
        {
            Console.WriteLine(item.Name + ": " + item.Average.ToString("F2") + " (" + string.Join(", ", item.Scores) + ")");
        }

        var topStudent = report.First();
        int highestSingleScore = scores.SelectMany(studentScores => studentScores).Max();

        Console.WriteLine("\nTop Student: " + topStudent.Name);
        Console.WriteLine("Highest Single Score: " + highestSingleScore);
    }
}

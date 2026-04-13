using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;

class StudyTask : INotifyPropertyChanged
{
    private bool _isDone;

    public string Title { get; set; }
    public string Category { get; set; }
    public int Priority { get; set; }
    public int Hours { get; set; }

    public bool IsDone
    {
        get => _isDone;
        set
        {
            if (_isDone == value) return;
            _isDone = value;
            OnPropertyChanged("IsDone");
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    private void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

static class ObservableCollectionLinqMiniProject
{
    static void Main()
    {
        ObservableCollection<StudyTask> tasks = new ObservableCollection<StudyTask>
        {
            new StudyTask { Title = "Read LINQ basics", Category = "LINQ", Priority = 5, Hours = 2, IsDone = false },
            new StudyTask { Title = "Practice GroupBy", Category = "LINQ", Priority = 4, Hours = 3, IsDone = false },
            new StudyTask { Title = "Build event logger", Category = "ObservableCollection", Priority = 5, Hours = 2, IsDone = true },
            new StudyTask { Title = "Refactor sample app", Category = "C#", Priority = 3, Hours = 4, IsDone = false },
            new StudyTask { Title = "Write notes", Category = "Productivity", Priority = 2, Hours = 1, IsDone = true }
        };

        tasks.CollectionChanged += OnCollectionChanged;
        foreach (StudyTask task in tasks)
        {
            task.PropertyChanged += OnTaskPropertyChanged;
        }

        Console.WriteLine("=== Initial Dashboard ===");
        PrintLinqDashboard(tasks);

        Console.WriteLine("\n=== Collection Operations ===");
        tasks.Add(new StudyTask { Title = "Learn ToLookup", Category = "LINQ", Priority = 4, Hours = 2, IsDone = false });
        tasks.Remove(tasks.First(x => x.Title == "Write notes"));
        tasks[1] = new StudyTask { Title = "Practice SelectMany", Category = "LINQ", Priority = 4, Hours = 2, IsDone = false };
        tasks.Move(0, tasks.Count - 1);

        Console.WriteLine("\n=== Property Update ===");
        StudyTask nextTask = tasks.First(x => x.Title == "Read LINQ basics");
        nextTask.IsDone = true;

        Console.WriteLine("\n=== Updated Dashboard ===");
        PrintLinqDashboard(tasks);
    }

    private static void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
        ObservableCollection<StudyTask> tasks = (ObservableCollection<StudyTask>)sender;

        if (e.NewItems != null)
        {
            foreach (StudyTask task in e.NewItems)
            {
                task.PropertyChanged += OnTaskPropertyChanged;
            }
        }

        if (e.OldItems != null)
        {
            foreach (StudyTask task in e.OldItems)
            {
                task.PropertyChanged -= OnTaskPropertyChanged;
            }
        }

        Console.WriteLine($"Collection action: {e.Action}, Total tasks: {tasks.Count}");
    }

    private static void OnTaskPropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        StudyTask task = (StudyTask)sender;
        Console.WriteLine($"Task updated: {task.Title}, {e.PropertyName} = {task.IsDone}");
    }

    private static void PrintLinqDashboard(ObservableCollection<StudyTask> tasks)
    {
        var pendingHighPriority = tasks
            .Where(x => !x.IsDone && x.Priority >= 4)
            .OrderByDescending(x => x.Priority)
            .ThenBy(x => x.Hours)
            .ToList();

        Console.WriteLine("Pending high-priority tasks:");
        foreach (StudyTask task in pendingHighPriority)
        {
            Console.WriteLine($"- {task.Title} | P{task.Priority} | {task.Hours}h | {task.Category}");
        }

        var summaryByCategory = tasks
            .GroupBy(x => x.Category)
            .Select(g => new
            {
                Category = g.Key,
                Total = g.Count(),
                Done = g.Count(x => x.IsDone),
                RemainingHours = g.Where(x => !x.IsDone).Sum(x => x.Hours)
            })
            .OrderByDescending(x => x.Total)
            .ThenBy(x => x.Category);

        Console.WriteLine("\nSummary by category:");
        foreach (var row in summaryByCategory)
        {
            Console.WriteLine($"{row.Category}: Total={row.Total}, Done={row.Done}, RemainingHours={row.RemainingHours}");
        }

        double completionRate = tasks.Any() ? tasks.Count(x => x.IsDone) * 100.0 / tasks.Count : 0;
        int totalRemainingHours = tasks.Where(x => !x.IsDone).Sum(x => x.Hours);
        StudyTask bestNextTask = tasks
            .Where(x => !x.IsDone)
            .OrderByDescending(x => x.Priority)
            .ThenBy(x => x.Hours)
            .FirstOrDefault();

        Console.WriteLine($"\nCompletion rate: {completionRate:F1}%");
        Console.WriteLine($"Remaining hours: {totalRemainingHours}");
        Console.WriteLine(bestNextTask == null
            ? "Next task: All tasks completed"
            : $"Next recommended task: {bestNextTask.Title} (P{bestNextTask.Priority}, {bestNextTask.Hours}h)");
    }
}

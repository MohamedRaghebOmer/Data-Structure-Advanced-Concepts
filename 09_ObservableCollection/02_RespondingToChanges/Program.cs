using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;

static class RespondingToChanges
{
    static void Main(string[] args)
    {
        ObservableCollection<string> items = new ObservableCollection<string>();

        // Subscribe to the CollectionChanged event.
        items.CollectionChanged += Items_CollectionChanged;

        // Do changes to the collection.
        items.Add("First item");
        items.Add("Second item");
        items.Add("Third item");
        items.Add("Fourth item");
        items.Remove("Second item");
        items.Move(0, 2);
        items.Reverse();
        items[1] = "New item";
    }

    private static void Items_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
        Console.WriteLine("\nCollection Changed:");

        // Handling Collection Changes
        switch (e.Action)
        {
            case NotifyCollectionChangedAction.Add:
                Console.WriteLine("Added:");
                foreach (var newItem in e.NewItems)
                {
                    Console.WriteLine("- " + newItem);
                }
                break;


            case NotifyCollectionChangedAction.Remove:
                Console.WriteLine("Removed:");
                foreach (var oldItem in e.OldItems)
                {
                    Console.WriteLine("- " + oldItem);
                }
                break;


            case NotifyCollectionChangedAction.Replace:
                Console.WriteLine("Replaced:");
                foreach (var oldItem in e.OldItems)
                {
                    Console.WriteLine("- " + oldItem);
                }
                Console.WriteLine("With:");
                foreach (var newItem in e.NewItems)
                {
                    Console.WriteLine("- " + newItem);
                }
                break;


            case NotifyCollectionChangedAction.Move:
                Console.WriteLine("Moved:");
                Console.WriteLine($"- From index {e.OldStartingIndex} to index {e.NewStartingIndex}");
                break;
        }
    }
}

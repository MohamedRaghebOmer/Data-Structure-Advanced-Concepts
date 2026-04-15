using System;
using System.Collections;
using System.Collections.Generic;

class CustomCollectionExample
{
    public class CustomCollection<T> : IEnumerable<T>
    {
        List<T> Items = new List<T>();

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                yield return Items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            Items.Add(item);
        }
    }

    static void Main(string[] args)
    {
        CustomCollection<int> myCollection = new CustomCollection<int>();

        myCollection.Add(1);
        myCollection.Add(2);
        myCollection.Add(3);

        foreach (var item in myCollection)
        {
            Console.WriteLine(item);
        }
    }
}
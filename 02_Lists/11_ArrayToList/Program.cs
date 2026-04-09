using System;
using System.Collections.Generic;

static class ArrayToList
{
    static void Main(string[] args)
    {
        // Array initialization
        int[] numbersArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Converting the array to a list
        List<int> numbersList = new List<int>(numbersArray);

        // Displaying the list elements
        Console.WriteLine("List elements: " + string.Join(", ", numbersList));

        //Console.WriteLine("List elements: " + string.Join(", ",  new List<int>(numbersArray)));
    }
}


using System;
using System.Collections.Generic;

static class Stack
{
    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();


        // Pushing elements into the stack
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        // Peeking at the top element
        Console.WriteLine("Top element: " + stack.Peek()); // Output: 3

        // Popping elements from the stack
        Console.WriteLine("Popped: " + stack.Pop()); // Output: 3
        Console.WriteLine("Popped: " + stack.Pop()); // Output: 2

        // Checking if the stack is empty
        if (stack.Count == 0)
        {
            Console.WriteLine("Stack is empty.");
        }
        else
        {
            Console.WriteLine("Top element: " + stack.Peek());
        }

        // Clearing the stack
        stack.Clear();
    }
}

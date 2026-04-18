/*
Balanced Trees: Implementing AVL Tree concepts (self-balancing BST)
This project demonstrates how balanced trees maintain optimal search performance.
*/

using System;

static class BalancedTrees
{
    static void Main(string[] args)
    {
        AVLTree tree = new AVLTree();

        // Insert values
        int[] values = { 50, 25, 75, 10, 30, 60, 80, 5, 15, 27, 35 };
        foreach (int val in values)
        {
            tree.Insert(val);
        }

        Console.WriteLine("AVL Tree after insertions:");
        Console.WriteLine("In-order traversal:");
        tree.InOrderTraversal();
        Console.WriteLine();

        Console.WriteLine($"Tree height: {tree.GetHeight()}");
        Console.WriteLine($"Is balanced: {tree.IsBalanced()}");

        Console.WriteLine("\nAfter inserting more values to test balancing:");
        tree.Insert(1);
        tree.Insert(2);
        tree.Insert(3);

        Console.WriteLine("In-order traversal:");
        tree.InOrderTraversal();
        Console.WriteLine();

        Console.WriteLine($"Tree height after balancing: {tree.GetHeight()}");
    }
}

class AVLNode
{
    public int Value { get; set; }
    public AVLNode Left { get; set; }
    public AVLNode Right { get; set; }
    public int Height { get; set; }

    public AVLNode(int value)
    {
        Value = value;
        Height = 1;
    }
}

class AVLTree
{
    private AVLNode root;

    public void Insert(int value)
    {
        root = InsertRecursive(root, value);
    }

    private AVLNode InsertRecursive(AVLNode node, int value)
    {
        if (node == null)
            return new AVLNode(value);

        if (value < node.Value)
            node.Left = InsertRecursive(node.Left, value);
        else if (value > node.Value)
            node.Right = InsertRecursive(node.Right, value);
        else
            return node;

        node.Height = 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));

        int balance = GetBalance(node);

        // Left heavy
        if (balance > 1 && value < node.Left.Value)
            return RotateRight(node);

        // Right heavy
        if (balance < -1 && value > node.Right.Value)
            return RotateLeft(node);

        // Left-Right heavy
        if (balance > 1 && value > node.Left.Value)
        {
            node.Left = RotateLeft(node.Left);
            return RotateRight(node);
        }

        // Right-Left heavy
        if (balance < -1 && value < node.Right.Value)
        {
            node.Right = RotateRight(node.Right);
            return RotateLeft(node);
        }

        return node;
    }

    private AVLNode RotateRight(AVLNode node)
    {
        AVLNode temp = node.Left;
        node.Left = temp.Right;
        temp.Right = node;

        node.Height = 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));
        temp.Height = 1 + Math.Max(GetHeight(temp.Left), GetHeight(temp.Right));

        return temp;
    }

    private AVLNode RotateLeft(AVLNode node)
    {
        AVLNode temp = node.Right;
        node.Right = temp.Left;
        temp.Left = node;

        node.Height = 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));
        temp.Height = 1 + Math.Max(GetHeight(temp.Left), GetHeight(temp.Right));

        return temp;
    }

    private int GetBalance(AVLNode node)
    {
        if (node == null)
            return 0;
        return GetHeight(node.Left) - GetHeight(node.Right);
    }

    private int GetHeight(AVLNode node)
    {
        if (node == null)
            return 0;
        return node.Height;
    }

    public int GetHeight()
    {
        return GetHeight(root);
    }

    public bool IsBalanced()
    {
        return IsBalancedRecursive(root);
    }

    private bool IsBalancedRecursive(AVLNode node)
    {
        if (node == null)
            return true;

        int balance = Math.Abs(GetBalance(node));
        if (balance > 1)
            return false;

        return IsBalancedRecursive(node.Left) && IsBalancedRecursive(node.Right);
    }

    public void InOrderTraversal()
    {
        InOrderRecursive(root);
        Console.WriteLine();
    }

    private void InOrderRecursive(AVLNode node)
    {
        if (node != null)
        {
            InOrderRecursive(node.Left);
            Console.Write(node.Value + " ");
            InOrderRecursive(node.Right);
        }
    }
}

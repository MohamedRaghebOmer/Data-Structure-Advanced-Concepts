/*
Binary Search Tree: Implementing a basic BST with search, insert, and delete operations
This project demonstrates how Binary Search Trees maintain sorted order for efficient searching.
*/

using System;
using System.Collections.Generic;

static class BinarySearchTree
{
    static void Main(string[] args)
    {
        BST bst = new BST();

        // Insert values
        int[] values = { 50, 30, 70, 20, 40, 60, 80, 10, 25, 35, 65 };
        foreach (int val in values)
        {
            bst.Insert(val);
        }

        Console.WriteLine("In-order traversal (sorted):");
        bst.InOrderTraversal();

        Console.WriteLine("\nTree structure (pre-order):");
        bst.PreOrderTraversal();

        Console.WriteLine("\nSearching for values:");
        Console.WriteLine($"Search 40: {bst.Search(40)}");
        Console.WriteLine($"Search 100: {bst.Search(100)}");

        Console.WriteLine("\nFinding min and max:");
        Console.WriteLine($"Minimum: {bst.FindMin()}");
        Console.WriteLine($"Maximum: {bst.FindMax()}");

        Console.WriteLine("\nDeleting 20:");
        bst.Delete(20);
        Console.WriteLine("In-order after deletion:");
        bst.InOrderTraversal();

        Console.WriteLine($"\nTree height: {bst.GetHeight()}");
    }
}

class TreeNode
{
    public int Value { get; set; }
    public TreeNode Left { get; set; }
    public TreeNode Right { get; set; }

    public TreeNode(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}

class BST
{
    private TreeNode root;

    public void Insert(int value)
    {
        root = InsertRecursive(root, value);
    }

    private TreeNode InsertRecursive(TreeNode node, int value)
    {
        if (node == null)
            return new TreeNode(value);

        if (value < node.Value)
            node.Left = InsertRecursive(node.Left, value);
        else if (value > node.Value)
            node.Right = InsertRecursive(node.Right, value);

        return node;
    }

    public bool Search(int value)
    {
        return SearchRecursive(root, value);
    }

    private bool SearchRecursive(TreeNode node, int value)
    {
        if (node == null)
            return false;

        if (value == node.Value)
            return true;
        else if (value < node.Value)
            return SearchRecursive(node.Left, value);
        else
            return SearchRecursive(node.Right, value);
    }

    public void InOrderTraversal()
    {
        InOrderRecursive(root);
        Console.WriteLine();
    }

    private void InOrderRecursive(TreeNode node)
    {
        if (node != null)
        {
            InOrderRecursive(node.Left);
            Console.Write(node.Value + " ");
            InOrderRecursive(node.Right);
        }
    }

    public void PreOrderTraversal()
    {
        PreOrderRecursive(root);
        Console.WriteLine();
    }

    private void PreOrderRecursive(TreeNode node)
    {
        if (node != null)
        {
            Console.Write(node.Value + " ");
            PreOrderRecursive(node.Left);
            PreOrderRecursive(node.Right);
        }
    }

    public int FindMin()
    {
        TreeNode current = root;
        while (current.Left != null)
            current = current.Left;
        return current.Value;
    }

    public int FindMax()
    {
        TreeNode current = root;
        while (current.Right != null)
            current = current.Right;
        return current.Value;
    }

    public void Delete(int value)
    {
        root = DeleteRecursive(root, value);
    }

    private TreeNode DeleteRecursive(TreeNode node, int value)
    {
        if (node == null)
            return null;

        if (value < node.Value)
            node.Left = DeleteRecursive(node.Left, value);
        else if (value > node.Value)
            node.Right = DeleteRecursive(node.Right, value);
        else
        {
            if (node.Left == null)
                return node.Right;
            else if (node.Right == null)
                return node.Left;

            TreeNode minRight = node.Right;
            while (minRight.Left != null)
                minRight = minRight.Left;

            node.Value = minRight.Value;
            node.Right = DeleteRecursive(node.Right, minRight.Value);
        }

        return node;
    }

    public int GetHeight()
    {
        return GetHeightRecursive(root);
    }

    private int GetHeightRecursive(TreeNode node)
    {
        if (node == null)
            return 0;

        int leftHeight = GetHeightRecursive(node.Left);
        int rightHeight = GetHeightRecursive(node.Right);

        return 1 + Math.Max(leftHeight, rightHeight);
    }
}

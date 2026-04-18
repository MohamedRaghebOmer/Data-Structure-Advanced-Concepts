/*
Tree Traversal: Demonstrating different tree traversal methods (BFS and DFS)
This project shows Level-order, Depth-first, and Breadth-first traversals.
*/

using System;
using System.Collections.Generic;

static class TreeTraversal
{
    static void Main(string[] args)
    {
        TreeNode root = CreateSampleTree();

        Console.WriteLine("=== Tree Traversal Methods ===\n");

        Console.WriteLine("In-order (Left-Root-Right):");
        InOrderTraversal(root);
        Console.WriteLine();

        Console.WriteLine("Pre-order (Root-Left-Right):");
        PreOrderTraversal(root);
        Console.WriteLine();

        Console.WriteLine("Post-order (Left-Right-Root):");
        PostOrderTraversal(root);
        Console.WriteLine();

        Console.WriteLine("Level-order (Breadth-first):");
        LevelOrderTraversal(root);
        Console.WriteLine();

        Console.WriteLine("Depth (height): " + GetDepth(root));
    }

    static TreeNode CreateSampleTree()
    {
        TreeNode root = new TreeNode(1);
        root.Left = new TreeNode(2);
        root.Right = new TreeNode(3);
        root.Left.Left = new TreeNode(4);
        root.Left.Right = new TreeNode(5);
        root.Right.Left = new TreeNode(6);
        root.Right.Right = new TreeNode(7);
        return root;
    }

    static void InOrderTraversal(TreeNode node)
    {
        if (node != null)
        {
            InOrderTraversal(node.Left);
            Console.Write(node.Value + " ");
            InOrderTraversal(node.Right);
        }
    }

    static void PreOrderTraversal(TreeNode node)
    {
        if (node != null)
        {
            Console.Write(node.Value + " ");
            PreOrderTraversal(node.Left);
            PreOrderTraversal(node.Right);
        }
    }

    static void PostOrderTraversal(TreeNode node)
    {
        if (node != null)
        {
            PostOrderTraversal(node.Left);
            PostOrderTraversal(node.Right);
            Console.Write(node.Value + " ");
        }
    }

    static void LevelOrderTraversal(TreeNode root)
    {
        if (root == null)
            return;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            TreeNode node = queue.Dequeue();
            Console.Write(node.Value + " ");

            if (node.Left != null)
                queue.Enqueue(node.Left);

            if (node.Right != null)
                queue.Enqueue(node.Right);
        }
    }

    static int GetDepth(TreeNode node)
    {
        if (node == null)
            return 0;

        int leftDepth = GetDepth(node.Left);
        int rightDepth = GetDepth(node.Right);

        return 1 + Math.Max(leftDepth, rightDepth);
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

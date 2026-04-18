using System;
using System.Collections.Generic;

public class TreeNode<T>
{
    public T Value { get; set; }
    public List<TreeNode<T>> Children { get; set; }

    public TreeNode(T value)
    {
        this.Value = value;
        this.Children = new List<TreeNode<T>>();
    }

    public void AddChildren(TreeNode<T> node)
    {
        Children.Add(node);
    }
}

public class Tree<T>
{
    public TreeNode<T> Root { get; private set; }

    public Tree(TreeNode<T> root)
    {
        Root = new TreeNode<T>(root.Value);
    }
}


class GeneralTreeImplementation
{
    static void Main(string[] args)
    {
        // Create the root node
        TreeNode<string> root = new TreeNode<string>("CEO");

        // Initialize the tree root
        Tree<string> tree = new Tree<string>(root);

        // Create 'Level 2' Nodes
        TreeNode<string> nodeCFO = new TreeNode<string>("CFO");
        TreeNode<string> nodeCMO = new TreeNode<string>("CMO");
        TreeNode<string> nodeCTO = new TreeNode<string>("CTO");

        // Connect 'Level 2' nodes to tree node
        root.AddChildren(nodeCFO);
        root.AddChildren(nodeCTO);
        root.AddChildren(nodeCMO);

        // Create 'Level 3' nodes (Employees under each manager).
        TreeNode<string> underCFO = new TreeNode<string>("Accountant");
        TreeNode<string> underCMO = new TreeNode<string>("Social Media Manager");
        TreeNode<string> underCTO = new TreeNode<string>("UX Designer");
        TreeNode<string> underCTO2 = new TreeNode<string>("UI Designer");

        // Connect 'Level 3' nodes with 'Level 2 Nodes'
        nodeCTO.AddChildren(underCTO);
        nodeCTO.AddChildren(underCTO2);
        nodeCMO.AddChildren(underCMO);
        nodeCFO.AddChildren(underCFO);

        // Print Tree
        PrintTree(root);
    }

    static public void PrintTree(TreeNode<string> root, string indent = " ")
    {
        Console.WriteLine(indent + root.Value);

        foreach (TreeNode<string> childe in root.Children)
        {
            PrintTree(childe, indent + " ");
        }
    }
}
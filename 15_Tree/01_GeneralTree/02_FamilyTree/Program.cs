using System;
using System.Collections.Generic;

public class TreeNode<T>
{
    public string Value { get; set; }
    public List<TreeNode<T>> Children { get; set; }

    public TreeNode(string value)
    {
        Value = value;
        Children = new List<TreeNode<T>>();
    }

    public void AddChildren(TreeNode<T> child)
    {
        this.Children.Add(child);
    }
}

public class Tree<T>
{
    public string Root { get; private set; }

    public Tree(string root)
    {
        Root = root;
    }
}

internal class FamilyTree
{
    static void Main(string[] args)
    {
        // Create root node 'Level 1'
        TreeNode<string> root = new TreeNode<string>("Grand Parent");

        // Create tree and connect with root
        Tree<string> tree = new Tree<string>(root.Value);

        // Create Parents (Level 2)
        TreeNode<string> parent1 = new TreeNode<string>("First Parent");
        TreeNode<string> parent2 = new TreeNode<string>("Second Parent");
        TreeNode<string> parent3 = new TreeNode<string>("Third Parent");

        // Connect parents with grand parent. Connect (Level 2) with (Level 1 => Root)
        root.AddChildren(parent1);
        root.AddChildren(parent2);
        root.AddChildren(parent3);

        // Create children and connect to parent1 (Level 3)
        parent1.AddChildren(new TreeNode<string>("Child1"));
        parent1.AddChildren(new TreeNode<string>("Child2"));
        parent1.AddChildren(new TreeNode<string>("Child3"));

        // Create children and connect to parent2
        parent2.AddChildren(new TreeNode<string>("Child1"));
        parent2.AddChildren(new TreeNode<string>("Child2"));
        parent2.AddChildren(new TreeNode<string>("Child3"));

        // Create children and connect with parent3
        parent3.AddChildren(new TreeNode<string>("Child1"));
        parent3.AddChildren(new TreeNode<string>("Child2"));
        parent3.AddChildren(new TreeNode<string>("Child3"));

        // Print family tree
        PrintTree(root);
    }

    static void PrintTree(TreeNode<string> root, string indent = " ")
    {
        Console.WriteLine(indent + root.Value);

        foreach (TreeNode<string> child in root.Children)
        {
            PrintTree(child, indent + "   ");
        }
    }
}

using System;
using System.Collections.Generic;

namespace FindOperation
{
    public class TreeNode<T>
    {
        public T Value { get; set; }
        public List<TreeNode<T>> Children { get; private set; }

        public void Add(TreeNode<T> child)
        {
            this.Children.Add(child);
        }

        public TreeNode<T> Find(T value)
        {
            if (EqualityComparer<T>.Default.Equals(this.Value, value))
                return this;

            foreach (TreeNode<T> child in this.Children)
            {
                var result = child.Find(value);
                if (result != null)
                    return child;
            }

            return null;
        }

        public TreeNode(T value)
        {
            Value = value;
            Children = new List<TreeNode<T>>();
        }
    }

    public class Tree<T>
    {
        public TreeNode<T> Root { get; private set; }

        public void Print(string indent = " ")
        {
            Print(this.Root, indent);
        }

        private static void Print(TreeNode<T> node, string indent = " ")
        {
            Console.WriteLine(indent + node.Value);

            foreach (var child in node.Children)
            {
                Print(child, indent + "   ");
            }
        }
            
        public TreeNode<T> Find(T value)
        {
            return Root?.Find(value);
        }

        public Tree(T rootValue)
        {
            Root = new TreeNode<T>(rootValue);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating the tree
            var CompanyTree = new Tree<string>("CEO");
            var Finance = new TreeNode<string>("CFO");
            var Tech = new TreeNode<string>("CTO");
            var Marketing = new TreeNode<string>("CMO");

            // Adding departments to the CEO node
            CompanyTree.Root.Add(Finance);
            CompanyTree.Root.Add(Tech);
            CompanyTree.Root.Add(Marketing);

            // Adding employees to departments
            Finance.Add(new TreeNode<string>("Accountant"));
            Tech.Add(new TreeNode<string>("Developer"));
            Tech.Add(new TreeNode<string>("UX Designer"));
            Marketing.Add(new TreeNode<string>("Social Media Manager"));

            // Printing the tree
            CompanyTree.Print();

            Console.WriteLine("\nFinding Developer...");
            if (CompanyTree.Find("Developer") == null)
                Console.WriteLine("Not Found :-(");
            else
                Console.WriteLine("Found :-)");

            Console.WriteLine("\nFinding DBA...");
            if (CompanyTree.Find("DBA") == null)
                Console.WriteLine("Not Found :-(");
            else
                Console.WriteLine("Found :-)");

        }
    }
}
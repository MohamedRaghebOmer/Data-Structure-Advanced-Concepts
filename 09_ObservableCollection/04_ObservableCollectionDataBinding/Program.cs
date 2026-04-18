/*
ObservableCollection Data Binding: Simulating data binding scenarios
This project demonstrates how ObservableCollection facilitates data binding in MVVM patterns.
*/

using System;
using System.Collections.ObjectModel;

static class ObservableCollectionDataBinding
{
    static void Main(string[] args)
    {
        ObservableCollection<Product> products = new ObservableCollection<Product>();

        // Subscribe to collection changes
        products.CollectionChanged += (sender, e) =>
        {
            Console.WriteLine($"\n[EVENT] Collection changed: {e.Action}");
        };

        // Add products (demonstrates adding items)
        products.Add(new Product { Id = 1, Name = "Laptop", Price = 999.99m });
        products.Add(new Product { Id = 2, Name = "Mouse", Price = 25.99m });
        products.Add(new Product { Id = 3, Name = "Keyboard", Price = 79.99m });

        Console.WriteLine("Current Products:");
        DisplayProducts(products);

        // Update product (demonstrates property change tracking)
        Console.WriteLine("\nUpdating Mouse price to $35.99:");
        products[1].Price = 35.99m;

        // Remove product
        Console.WriteLine("\nRemoving Keyboard:");
        products.RemoveAt(2);

        Console.WriteLine("\nFinal Products:");
        DisplayProducts(products);

        // Calculate total
        decimal total = 0;
        foreach (var product in products)
        {
            total += product.Price;
        }
        Console.WriteLine($"\nTotal value of inventory: ${total}");
    }

    static void DisplayProducts(ObservableCollection<Product> products)
    {
        foreach (var product in products)
        {
            Console.WriteLine($"  {product.Id}. {product.Name} - ${product.Price}");
        }
    }
}

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

using System;
using System.Collections.Generic;

static class SortedDictionaryCustomComparer
{
    static void Main()
    {
        SortedDictionary<string, int> userLogins =
            new SortedDictionary<string, int>(StringComparer.OrdinalIgnoreCase)
            {
                { "Alice", 4 },
                { "bob", 2 },
                { "charlie", 7 }
            };

        userLogins["ALICE"] += 1;
        userLogins["Bob"] += 3;

        Console.WriteLine("Login count (case-insensitive keys):");
        foreach (var user in userLogins)
        {
            Console.WriteLine($"{user.Key}: {user.Value}");
        }

        Console.WriteLine($"\nContains key 'alice': {userLogins.ContainsKey("alice")}");
        Console.WriteLine($"Contains key 'BOB': {userLogins.ContainsKey("BOB")}");
    }
}

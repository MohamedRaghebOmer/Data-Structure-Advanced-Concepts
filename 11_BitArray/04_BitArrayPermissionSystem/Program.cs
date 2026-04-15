using System;
using System.Collections;

enum Permission
{
    Read = 0,
    Write = 1,
    Delete = 2,
    Export = 3,
    Admin = 4
}

static class BitArrayPermissionSystem
{
    static void Main(string[] args)
    {
        BitArray userPermissions = new BitArray(5, false);

        Grant(userPermissions, Permission.Read);
        Grant(userPermissions, Permission.Write);
        Grant(userPermissions, Permission.Export);

        Console.WriteLine("Initial permissions : " + BitArrayToString(userPermissions));
        PrintPermissionStatus(userPermissions);

        Revoke(userPermissions, Permission.Write);
        Grant(userPermissions, Permission.Admin);

        Console.WriteLine("\nUpdated permissions : " + BitArrayToString(userPermissions));
        PrintPermissionStatus(userPermissions);
    }

    static void Grant(BitArray permissions, Permission permission)
    {
        permissions[(int)permission] = true;
    }

    static void Revoke(BitArray permissions, Permission permission)
    {
        permissions[(int)permission] = false;
    }

    static bool HasPermission(BitArray permissions, Permission permission)
    {
        return permissions[(int)permission];
    }

    static void PrintPermissionStatus(BitArray permissions)
    {
        foreach (Permission permission in Enum.GetValues(typeof(Permission)))
        {
            Console.WriteLine("{0,-6}: {1}", permission, HasPermission(permissions, permission));
        }
    }

    static string BitArrayToString(BitArray bits)
    {
        char[] chars = new char[bits.Length];

        for (int i = 0; i < bits.Length; i++)
        {
            chars[i] = bits[i] ? '1' : '0';
        }

        return new string(chars);
    }
}

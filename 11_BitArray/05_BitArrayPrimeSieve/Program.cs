using System;
using System.Collections;
using System.Collections.Generic;

static class BitArrayPrimeSieve
{
    static void Main(string[] args)
    {
        const int limit = 100;
        List<int> primes = Sieve(limit);

        Console.WriteLine("Prime numbers up to " + limit + ":");
        Console.WriteLine(string.Join(", ", primes));
    }

    static List<int> Sieve(int n)
    {
        BitArray isPrime = new BitArray(n + 1, true);
        isPrime[0] = false;
        isPrime[1] = false;

        for (int i = 2; i * i <= n; i++)
        {
            if (!isPrime[i])
            {
                continue;
            }

            for (int j = i * i; j <= n; j += i)
            {
                isPrime[j] = false;
            }
        }

        List<int> primes = new List<int>();
        for (int i = 2; i <= n; i++)
        {
            if (isPrime[i])
            {
                primes.Add(i);
            }
        }

        return primes;
    }
}

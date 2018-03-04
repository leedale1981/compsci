using System;
using System.Collections.Generic;

namespace DynamicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fib = new Fibonacci();
            int result = fib.RecursiveSumMemoization(9);
            Console.WriteLine($"Fibonacci of 9 is {result}");
        }
    }

    public class Fibonacci
    {
        public int RecursiveSum(int n)
        {
            if (n == 0 || n == 1) { return n; } 

            int result = RecursiveSum(n-1) + RecursiveSum(n-2);
            Console.WriteLine($"Fib {n} result {result}");
            return result;
        }

        Dictionary<int, int> m = new Dictionary<int, int>();

        public int RecursiveSumMemoization(int n)
        {
            if (n == 0 || n == 1) { return n; } 

            if (!m.ContainsKey(n)) 
            { 
                m.Add(n, RecursiveSumMemoization(n-1) + RecursiveSumMemoization(n-2));
            }

            var result = m[n];
            Console.WriteLine($"Fib {n} result {result}");
            return result;
        }
    }
}

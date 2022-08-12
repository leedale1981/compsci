using System;
using System.Linq;

namespace Lee.CompSci.DataStructures
{
    public class Program
    {
        static void Main(string[] args)
        {
            string text = "Some random text with some random values in it.";
            string[] words = text.Split(" ");
            HashTable<int> wordCountHashTable = new HashTable<int>();

            foreach (string word in words)
            {
                var wordCount = words.Count(w => w == word);
                wordCountHashTable.Put(word, wordCount);
            }

            Console.WriteLine($"The word random has a count of {wordCountHashTable.Get("random")}");
            Console.WriteLine("Finished");
        }
    }
}
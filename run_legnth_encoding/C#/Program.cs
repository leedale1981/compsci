using System;
namespace Lee.CompSci.DataStructures
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = "aaabbbbbccccccca";
            string output = RunLengthEncoder.EncodeAscii(input);

            Console.WriteLine(output);
        }
    }
}
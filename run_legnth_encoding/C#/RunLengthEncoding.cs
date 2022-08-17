using System;
using System.Collections.Generic;

namespace Lee.CompSci.DataStructures
{
    public static class RunLengthEncoder
    {
        public static string EncodeAscii(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("Input is empty");
            }

            List<string> runs = GetRuns(input);
            string output = string.Empty;
            foreach (string run in runs)
            {
                output += EncodeAsciiRun(run);
            }

            return output;
        }

        private static List<string> GetRuns(string input)
        {
            char[] letters = input.ToCharArray();
            char prevLetter = '\0';
            List<string> runs = new();
            string run = string.Empty;

            for (int index = 0; index < letters.Length; index++)
            {
                char letter = letters[index];
                if (letter == prevLetter || prevLetter == '\0')
                {
                    run += letter;
                }
                else
                {
                    runs.Add(run);
                    run = letter.ToString();

                    if (index == letters.Length - 1)
                    {
                        runs.Add(run);
                    }
                }

                prevLetter = letter;
            }

            return runs;
        }

        private static string EncodeAsciiRun(string input)
        {
            char letter = input[0];
            int count = input.Length;
            return $"{count}{letter}";
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;

namespace MyReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> filestrings = new List<string>();

            string text1 = File.ReadAllText(@"C:\Lex\text1.txt");
            string[] words = text1.Split(' ');
            foreach (string word in words)
            {
                filestrings.Add(word);
            }

            string text2 = File.ReadAllText(@"C:\Lex\text2.txt");
            string[] words2 = text2.Split(' ');
            foreach (string word in words2)
            {
                filestrings.Add(word);
            }
            
            filestrings.Sort();
            Console.WriteLine("File 1 and file 2 mixed and sorted: \n");
            foreach (string text in filestrings)
            {
                Console.WriteLine(text);
            }
        }
    }
}

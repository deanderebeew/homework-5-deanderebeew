using System;
using System.Collections.Generic;
using System.IO;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sentence = File.ReadAllLines("Jane Erye.txt");

            Dictionary<string, int> wordcount = new Dictionary<string, int>();
            bool chapteroneFound = false;

            foreach (var line in sentence)
            {

                if (line.Contains("CHAPTER 1")== true)
                {
                    chapteroneFound = true;
                }

                if (chapteroneFound == false && string.IsNullOrWhiteSpace(line) == true)
                {
                    continue;
                }

                if (line.Contains("***END OF THE PROJECT GUTENBERG EBOOK JANE ERYEE***") == true)
                {
                    break;
                }

                string[] words = line.Split(" ");

                foreach (string word in words)
                {

                    char[] punctuation = { ',', '.', '!', '?', '"', ';', ':', '-' };
                    string current = word.ToLower().Trim(punctuation);

                    if (wordcount.ContainsKey(current) == false)
                    {
                        wordcount.Add(current, 0);

                    }

                    wordcount[current] = wordcount[current] + 1;



                }

                //Project Gutenberg Ebook Jane Erye

                Console.WriteLine("\nJane Erye Dictionary");
                Console.WriteLine($"{"Word".PadRight(25, ' ' )} \t\t\tCount");

                foreach (string word in wordcount.Keys)
                {
                    Console.WriteLine($"{"Word".PadRight(25, ' ')} \t\t\t{wordcount[word].ToString("N0")}");
                }

                Console.WriteLine("Do you want to search for a specific word? Yes or No>>");
                string answer = Console.ReadLine().ToLower();

                if (answer.ToLower()[0] == 'y')
                {
                    Console.WriteLine("What is the word you want to see the count of? >>");
                    answer = Console.ReadLine();

                    if (wordcount.ContainsKey(answer) == true)
                    {
                        Console.WriteLine($"{answer} is found {wordcount[answer].ToString("N0")} times!!" );
                    }
                    else
                    {
                        Console.WriteLine("Sorry your word was not found! ://");
                        Environment.Exit(-1);
                    }





                }






            }
        }
    }
}

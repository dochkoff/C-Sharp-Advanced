namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"../../../Files/words.txt";
            string textPath = @"../../../Files/text.txt";
            string outputPath = @"../../../Files/output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            using (StreamReader readerWords = new StreamReader(wordsFilePath))
            {
                string[] words = readerWords.ReadLine().Split();
                Dictionary<string, int> wordsCount = new Dictionary<string, int>();

                for (int i = 0; i < words.Length; i++)
                {
                    if (!wordsCount.ContainsKey(words[i]))
                    {
                        wordsCount.Add(words[i], 0);
                    }
                }

                using (StreamReader readerText = new StreamReader(textFilePath))
                {
                    string line = readerText.ReadLine();

                    while (line != null)
                    {
                        char[] punctuation = line.Where(Char.IsPunctuation).Distinct().ToArray();
                        string[] text = line.Split().Select(x => x.Trim(punctuation).ToLower()).ToArray();

                        for (int i = 0; i < text.Length; i++)
                        {
                            if (wordsCount.ContainsKey(text[i]))
                            {
                                wordsCount[text[i]]++;
                            }
                        }

                        line = readerText.ReadLine();
                    }

                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        var sortedWordsCount = from entry in wordsCount orderby entry.Value descending select entry;

                        foreach (var kvp in sortedWordsCount)
                        {
                            writer.WriteLine($"{kvp.Key} - {kvp.Value}");
                        }
                    }
                }
            }
        }
    }
}

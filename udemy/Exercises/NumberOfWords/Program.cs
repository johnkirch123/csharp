using System;
using System.IO;

namespace NumberOfWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var longestWord = "";
            var count = 0;
            var longestCount = 0;

            string text = File.ReadAllText(@"C:\Users\dubsk\Desktop\programming\csharp\udemy\Exercises\test.txt");
            string[] words = text.Split(' ');
            foreach (var word in words)
            {
                if (word.Length > longestCount)
                {
                    longestWord = word;
                    longestCount = word.Length;
                }
                count++;
            }

            Console.WriteLine("Longest Word: " + longestWord);
            Console.WriteLine("Total Word Count: " + count);

        }
    }
}
/*try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(@"C:\Users\dubsk\Desktop\programming\csharp\udemy\Exercises\test.txt"))
                {
                    String word = "";
                    String longestWord = "";
                    int lineLength = 0;
                    int lineCount = 0;

                    while ((word = sr.ReadLine()) != null)
                    {
                        if (word.Length > lineLength)
                            longestWord = word;
                        lineCount++;
                    }

                    Console.WriteLine("Count: " + lineCount);
                    Console.WriteLine("Longest Word: " + longestWord);
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
    */

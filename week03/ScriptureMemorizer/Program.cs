using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        string json = File.ReadAllText("scriptures.json");

        List<Dictionary<string, JsonElement>> scriptures =
            JsonSerializer.Deserialize<List<Dictionary<string, JsonElement>>>(json);

        Random random = new Random();
        Dictionary<string, JsonElement> selected =
            scriptures[random.Next(scriptures.Count)];

       // Get the reference information
        string book = selected["book"].GetString();
        int chapter = selected["chapter"].GetInt32();
        int verse = selected["verse"].GetInt32();

        // Create the Reference
        Reference reference;

        if (selected.ContainsKey("endVerse"))
        {
            int endVerse = selected["endVerse"].GetInt32();

            reference = new Reference(
                book,
                chapter,
                verse,
                endVerse
            );
        }
        else
        {
            reference = new Reference(
                book,
                chapter,
                verse
            );
        }

        // Get the scripture text
        string text = selected["text"].GetString();

        // Create the Scripture
        // Scripture will turn the text into Word objects
        Scripture scripture = new Scripture(
            reference,
            text
        );

        // Start the memorization
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.WriteLine("Press Enter or Type 'quit' to exit.");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

    }
}
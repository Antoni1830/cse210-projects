using System;
using System.Collections.Generic;
using System.Threading;

class ReflectionActivity
{
    static void StartingMessage()
    {
        Console.WriteLine("Starting list activity. Prepare to begin...");
        Thread.Sleep(5000);
    }
    
    static void FinishingMessage()
    {
        Console.WriteLine("\nYou have successfully completed the list activity.");
    }
    
    static IEnumerable<string> Prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    
    static IEnumerable<string> Questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    
    static IEnumerable<char> Spinner()
    {
        while (true)
        {
            yield return '|';
            yield return '/';
            yield return '-';
            yield return '\\';
        }
    }
    
    static void Main()
    {
        StartingMessage();
        
        Random random = new Random();
        string prompt = Prompts.ElementAt(random.Next(Prompts.Count));
        Console.WriteLine(prompt);
        
        foreach (char cursor in Spinner())
        {
            Console.Write(cursor);
            Thread.Sleep(100);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
        
        FinishingMessage();
    }
}



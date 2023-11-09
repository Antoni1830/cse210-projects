using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity 
{
    public static void Main(string[] args)
    {
        ListActivity();
    }
    
    public static void ListActivity()
    {
        List<string> prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        
        Console.WriteLine("Starting list activity. Prepare to begin...");
        Thread.Sleep(5000);
        
        Console.WriteLine(prompt);
        
        Console.WriteLine("5...");
        Thread.Sleep(1000);
        Console.WriteLine("4...");
        Thread.Sleep(1000);
        Console.WriteLine("3...");
        Thread.Sleep(1000);
        Console.WriteLine("2...");
        Thread.Sleep(1000);
        Console.WriteLine("1...");
        Thread.Sleep(1000);
        
        List<string> items = new List<string>();
        
        Console.Write("Enter the duration (in seconds) for this activity: ");
        int duration = int.Parse(Console.ReadLine());
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.Write("Enter an item or press enter to stop: ");
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                items.Add(item);
            }
            else
            {
                break;
            }
        }
        
        Console.WriteLine("\nYou have successfully completed the list activity.");
        
        Console.WriteLine($"Number of items entered: {items.Count}");
    }
}
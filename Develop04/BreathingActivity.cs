using System;
using System.Collections.Generic;
using System.Threading;

public class BreathingActivity
{
    public static void StartingMessage()
    {
        Console.WriteLine("Starting list activity. Prepare to begin...");
        Thread.Sleep(5000);
    }
    
    public static void FinishingMessage()
    {
        Console.WriteLine("\nYou have successfully completed the list activity.");
    }
    
    public static IEnumerable<char> Spinner()
    {
        while (true)
        {
            yield return '|';
            yield return '/';
            yield return '-';
            yield return '\\';
        }
    }
    
    public static void Main()
    {
        StartingMessage();
        Console.Write("Enter the duration for this activity in seconds: ");
        int duration = int.Parse(Console.ReadLine());
        
        for (int i = duration; i > 0; i--)
        {
            Console.Write("\rTime remaining: {0}", i);
            Thread.Sleep(1000);
        }
        
        Console.WriteLine("\nBeginning activity...");
        string breatheIn = "Breathe in...";
        string breatheOut = "Breathe out...";
        
        for (int i = 0; i < duration; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(breatheIn);
            }
            else
            {
                Console.WriteLine(breatheOut);
            }
            
            Thread.Sleep(1000);
        }
        
        FinishingMessage();
    }
}



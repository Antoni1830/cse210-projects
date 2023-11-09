using System;

class Program
{
    static void Main(string[] args)
    {
        class ActivityApp
{
    private string current_activity;
    private DateTime activity_start_time;
    private Dictionary<string, Action> activities;

    public ActivityApp()
    {
        current_activity = null;
        activity_start_time = DateTime.MinValue;
        activities = new Dictionary<string, Action>
        {
            { "reflection", ReflectionActivity },
            { "breathing", BreathingActivity },
            { "listining", ListingActivity  }
        };
    }

    public void StartActivity(string activity)
    {
        current_activity = activity;
        activity_start_time = DateTime.Now;
        Console.WriteLine($"Starting {activity}. Prepare to begin...");
        Thread.Sleep(5000);
        Animate();
    }

    public void EndActivity(string activity)
    {
        current_activity = null;
        activity_start_time = DateTime.MinValue;
    }

    private void ReflectionActivity()
    {
        // TODO: Implement reflection activity
    }

    private void BreathingActivity()
    {
        // TODO: Implement breathing activity
    }

    private void ListingActivity ()
    {
        // TODO: Implement enumeration activity
    }

    private void Animate()
    {
        // TODO: Implement animation logic
    }
}
    }
}























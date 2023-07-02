using System;

public class Activity 
{
    private string _name;
    private string _description;
    private int _duration;



public Activity()
{
    _name = "none";
    _description = "none";
    _duration = 0;
}

public void DisplayStartingMessage()
{
    Console.WriteLine($"\nWelcome to the {_name} Activity.");
    Console.WriteLine($"\n{_description}");
    Console.Write("\nHow long in seconds would you like for your session?");

}

public void DisplayEndingMessage()
{
    Console.WriteLine("\nWell Done!");
    Console.WriteLine($"\nYou have completed another {_duration} seconds of {_name} Activity.");
}

public void ShowSpinner(int seconds)
{
    List<string> spinner = new List<string>{"|", "/", "-", "\\", "|"};
    

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(seconds);

    int i = 0;

    while (DateTime.Now < endTime)
    {
        string s = spinner[i];
        Console.Write(s);
        Thread.Sleep(1000);
        Console.Write("\b \b");

        i++;

        if (i >= spinner.Count)
        {
            i=0;
        }
    }
    
}

public void ShowCountDown(int seconds)
{
    
    for (int i = seconds; i > 0; i--)
    {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
    }

}

public void SetName(string name)
{
    _name = name;
}

public void SetDescription(string description)
{
    _description = description;
}

public void SetTime(int time)
{
    _duration = time;
}

public int GetDuration()
{
    return _duration;
}

}
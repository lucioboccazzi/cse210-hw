using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected Random _random = new Random();

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine($"{_description}");
        Console.Write("How long, in seconds, would you like for your session? ");
        string secondInput = Console.ReadLine();

        if (int.TryParse(secondInput, out var result))
        {
            _duration = result;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number of seconds.");
            DisplayStartingMessage();
        }
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Excellent work! Remember to keep coming back and taking care of yourself :)");
    }

    public void ShowSpinner(int durationInSeconds = 4)
    {
        List<string> animationStrings = new List<string> { "|", "/", "-", "\\", "|", "/", "-", "\\" };
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(durationInSeconds);

        while (DateTime.Now < endTime)
        {
            foreach (string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
        Console.WriteLine();
    }

    public void ShowCountDown(int _duration)
    {
        for (int i = _duration; i > 0; i--)
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write($"{i} seconds remaining...");
            Thread.Sleep(1000);
        }

        Console.SetCursorPosition(0, Console.CursorTop);
    }
}

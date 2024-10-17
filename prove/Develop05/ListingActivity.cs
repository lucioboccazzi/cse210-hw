using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    protected int _count;
    protected List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", 
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
        10)
    {
    }

    public ListingActivity(int duration) : base("Listing Activity", 
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
        duration)
    {
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);

        Console.WriteLine("Take a moment to think about this prompt. You have a few seconds to reflect...");
        ShowCountDown(5);

        Console.WriteLine("\nNow, start listing as many items as you can:");

        DateTime activityStartTime = DateTime.Now; 
        _count = 0; 
        List<string> userItems = new List<string>();

        while ((DateTime.Now - activityStartTime).TotalSeconds < _duration)
        {
            Console.Write("Enter an item: ");
            string userInput = Console.ReadLine();

            if (!string.IsNullOrEmpty(userInput))
            {
                userItems.Add(userInput);
                _count++; 
            }
            else
            {
                Console.WriteLine("Please enter a valid item.");
            }

            Console.WriteLine($"{_count} items listed so far...");

            Thread.Sleep(500); 
        }

        Console.Clear();
        Console.WriteLine("Time's up! You've listed:");
        Console.WriteLine($"{_count} items.");

        Console.WriteLine("Here are the items you listed:");
        foreach (var item in userItems)
        {
            Console.WriteLine($"- {item}");
        }

        DisplayEndingMessage();
        ShowSpinner(); 
        Console.Clear();
    }
    public string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    
}

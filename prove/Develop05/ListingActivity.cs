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

        // Display prompt
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);

        // Countdown before the user starts listing items
        Console.WriteLine("Take a moment to think about this prompt. You have a few seconds to reflect...");
        ShowCountDown(5); // Countdown for 5 seconds

        // Now, start listing items
        Console.WriteLine("\nNow, start listing as many items as you can:");

        DateTime activityStartTime = DateTime.Now; // Record the start time
        _count = 0; // Reset the item count
        List<string> userItems = new List<string>(); // List to store user input

        // Run the input loop while the total time elapsed is less than the specified duration
        while ((DateTime.Now - activityStartTime).TotalSeconds < _duration)
        {
            Console.Write("Enter an item: ");
            string userInput = Console.ReadLine();

            // Only process non-empty input
            if (!string.IsNullOrEmpty(userInput))
            {
                userItems.Add(userInput); // Add item to the list
                _count++; // Increment item count
            }
            else
            {
                Console.WriteLine("Please enter a valid item.");
            }

            // Show feedback and how many items have been listed so far
            Console.WriteLine($"{_count} items listed so far...");

            // Optional: Add a small delay to slow down the loop
            Thread.Sleep(500); // 500ms pause between inputs to avoid rapid processing
        }

        // Clear the console and display results after the duration is up
        Console.Clear();
        Console.WriteLine("Time's up! You've listed:");
        Console.WriteLine($"{_count} items.");

        // Optionally, display the items the user listed
        Console.WriteLine("Here are the items you listed:");
        foreach (var item in userItems)
        {
            Console.WriteLine($"- {item}");
        }

        // Call the standard ending message for all activities
        DisplayEndingMessage();
        ShowSpinner(); // Optional pause with spinner before finishing
        Console.Clear();
    }

    // Randomly selects a prompt from the list
    public string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    
}

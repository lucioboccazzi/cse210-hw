using System;
using System.Collections.Generic;

public class PromptGenerator
{
        public List<string> _prompts = new()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?", 
            "What was the strongest emotion I felt today?", 
            "If I had one thing I could do over today, what would it be?", 
            "What made you laugh the most today?" 
        };
        
        public string GetRandomPrompt()
        {
            // Random randomGenerator = new();
            // int number = randomGenerator.Next(0,5);
            
            // string prompt= Console.WriteLine(_prompts[number]);
            // return prompt;

            var random = new Random();
            int index = random.Next(_prompts.Count);
            Console.WriteLine(_prompts[index]);
            string randomPrompt = Console.ReadLine();
            return randomPrompt;
        }     

}

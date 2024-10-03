using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the scripture memorizer!");

        Reference r1 = new Reference("Nephi", 3, 7);

        Scripture s1 = new Scripture(r1);  

        Console.WriteLine(r1.GetDisplayText());

        s1.AddScriptureToList();

        Console.WriteLine(s1.GetDisplayText()); 
        Console.WriteLine("\nPress Enter to start hiding random words or type quit to finish.");

        Console.ReadLine();

        string userInput = Console.ReadLine();
        if (userInput.Equals("quit", StringComparison.OrdinalIgnoreCase))
        {
            return;
        }

        while (!s1.IsCompletelyHidden())
        {
            s1.HideRandomWord();  
            Console.Clear();
            Console.WriteLine(r1.GetDisplayText());  
            Console.WriteLine(s1.GetDisplayText());  
            Console.WriteLine("\nPress Enter to continue hiding random words or type 'quit' to exit...");


            userInput = Console.ReadLine();
            if (userInput.Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\nExiting program. Thank you for playing!");
                return;  
            }

            else if (userInput.Equals("Enter", StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }
        }

        Console.Clear();
        Console.WriteLine("All words are hidden! Great job!");
    }
}



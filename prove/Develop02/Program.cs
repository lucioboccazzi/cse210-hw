using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        int inputNumber = -1;
        PromptGenerator newGenerator = new PromptGenerator();
        Journal journal = new Journal();

        while (inputNumber != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            string answer = Console.ReadLine();

            inputNumber = int.TryParse(answer, out var number) ? number : -1;

            if (inputNumber == 1)
            {
                string generatedPrompt = newGenerator.GetRandomPrompt();
                Console.WriteLine(generatedPrompt);

                Console.Write("Answer: ");
                string entryText = Console.ReadLine();

                journal.AddEntry(generatedPrompt, entryText);
            }

            else if (inputNumber == 2)
            {
                journal.DisplayAll();
            }
            else if (inputNumber == 3)
            {
                journal.LoadFromFile("journal.txt");
            }
            else if (inputNumber == 4)
            {
                journal.SaveToFile("journal.txt");
            }

        }
    }
}
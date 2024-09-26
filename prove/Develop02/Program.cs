using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        int inputNumber = -1;

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

            inputNumber = int.Parse(answer);

            if (inputNumber == 1)
            {
                PromptGenerator newGenerator = new PromptGenerator();
                newGenerator.GetRandomPrompt();
                string generatedPrompt = Console.ReadLine();

                Entry entry1 = new Entry();
                entry1._promptText = generatedPrompt;

                Console.Write("Answer: ");
                entry1._entryText = Console.ReadLine();
                entry1.Display();
            }

            if (inputNumber == 2)
            {

            }

            if (inputNumber == 3)
            {

            }

            if (inputNumber == 4)
            {

            }

        }
    }
}
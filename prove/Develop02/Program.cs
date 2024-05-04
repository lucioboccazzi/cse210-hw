using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        int answerNumber = -1;

        Console.WriteLine("Welcome to the Journal Program!");
        

        while (answerNumber != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would I like to do? Write the number: ");
            answerNumber = int.Parse(Console.ReadLine());

            if (answerNumber == 1)
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

            // if (answerNumber == 2)
            // {

            // }

            // if (answerNumber == 3)
            // {
          
            // }

            // if (answerNumber == 4)
            // {
                
            // }
        }
    }
}
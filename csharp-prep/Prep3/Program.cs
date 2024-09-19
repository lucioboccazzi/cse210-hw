using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int guessNumber = -1;

        while (magicNumber != guessNumber)
        {
            Console.Write("What is your guess? ");
            string guessNumberText = Console.ReadLine();
            guessNumber = int.Parse(guessNumberText);

            if (magicNumber > guessNumber)
            {
                Console.WriteLine("Higher");
            }

            else if (magicNumber < guessNumber)
            {
                Console.WriteLine("Lower");
            }
        } 

        if (magicNumber == guessNumber)
        {
            Console.WriteLine("Youg guessed it!");
        }
    }
}
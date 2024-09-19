using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Console.Write("What is your magic number? ");
        string magicNumberText = Console.ReadLine();

        int magicNumber = int.Parse(magicNumberText);

        Console.Write("What is your guess? ");
        string guessNumberText = Console.ReadLine();

        int guessNumber = int.Parse(guessNumberText);

        if (magicNumber > guessNumber)
        {
            Console.WriteLine("Lower");
        }

        else if (magicNumber < guessNumber)
        {
            Console.WriteLine("Higher");
        }

        else
        {
            Console.WriteLine("Youg guessed it!");
        }
    }
}
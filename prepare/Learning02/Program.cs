using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Console.Write("What was your score on the test? ");
        string scoreInput = Console.ReadLine();

        int score = int.Parse(scoreInput);

        // if (score >= 90)
        // {
        //     Console.WriteLine("Your grade is A.");
        // }
        // else if (score >= 80 && score < 90)
        // {
        //     Console.WriteLine("Your grade is B.");
        // }
        // else if (score >= 70 && score < 80)
        // {
        //     Console.WriteLine("Your grade is C.");
        // }
        // else if (score >= 60 && score < 70)
        // {
        //     Console.WriteLine("Your grade is D.");
        // }
        // else
        // {
        //     Console.WriteLine("Your grade is F.");
        // }

        string letter = "";

        if (score >= 90)
        {
            letter = "A";
        }

        else if (score >= 80 && score < 90)
        {
            letter = "B";
        }

        else if (score >= 70 && score < 80)
        {
            letter = "C";
        }

        else if (score >= 60 && score < 70)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}.");

        if (score >= 70)
        {
            Console.WriteLine("Congratulations! You have passed!");
        }
        else
        {
            Console.WriteLine("Sorry, you have not passed. Go back and review your notes again, you can do it :)");
        }
    }
}
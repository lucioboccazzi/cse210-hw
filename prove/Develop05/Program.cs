using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Clear();
        Console.WriteLine("Welcome to the Minfulness Program! :D");

        int inputNumber = -1;

        while (inputNumber != 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");

            Console.Write("Select a choice from the menu: ");
            string answer = Console.ReadLine();

            inputNumber = int.TryParse(answer, out var number) ? number : -1;

            if (inputNumber == 1)
            {
                BreathingActivity a1 = new BreathingActivity();
                a1.Run();
            }

            else if (inputNumber == 2)
            {
                ReflectingActivity a2 = new ReflectingActivity();
                a2.Run();
            }

            else if (inputNumber == 3)
            {
                ListingActivity a3 = new ListingActivity();
                a3.Run();
            }

        }
    

    }
}
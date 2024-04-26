using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        int number = -1;

        List <int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
            numbers.Add(number);
            }
        }

        int total = numbers.Sum();

        double average = numbers.Average();

        int max = numbers.Max();

        Console.WriteLine($"The sum is: {total}");

        Console.WriteLine("The average is {0}", average);

        Console.WriteLine($"The largest number is: {max}");

    }
}
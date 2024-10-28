using System;

class Program
{
    static void Main(string[] args)
    {
        Swimming swim = new Swimming(numberOfLaps: 20, date: "2024-10-28", length: 30);
        Running run = new Running(distance: 5, date: "2024-10-27", length: 40);
        Cycling cycle = new Cycling(speed: 15, date: "2024-10-26", length: 60);

        Console.Clear();

        Console.WriteLine("Welcome to the Inheritance and Polymorphism with Exercise Tracking :)");
        
        Console.WriteLine();
        Console.WriteLine(swim.GetSummary());
        Console.WriteLine(run.GetSummary());
        Console.WriteLine(cycle.GetSummary());
        Console.WriteLine();

    }
}
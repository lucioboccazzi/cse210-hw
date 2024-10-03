using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("Welcome to the scripture memorizer!"); 

        Reference r1 = new Reference("Nephi", 3, 7);
        Console.WriteLine(r1.GetDisplayText());  

    }
}
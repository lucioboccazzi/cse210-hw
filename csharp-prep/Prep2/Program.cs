using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is the percentage of the grade? ");
        string userInputGrade = Console.ReadLine();
        int gradeNumber = int.Parse(userInputGrade);

        string letter = "";
           
        if (gradeNumber >= 90 && gradeNumber <= 100)
        {
            letter =  "A";
        }
        else if (gradeNumber >= 80 && gradeNumber < 90)
        {
            letter =  "B";
        }
        else if (gradeNumber >= 70 && gradeNumber < 80)
        {
            letter =  "C";
        }
           
        else if (gradeNumber >= 60 && gradeNumber < 70)
        {
            letter =  "D";
        }
        else 
        {
            letter =  "F";
        }
            
        Console.WriteLine($"Your grade is: {letter}");


        if (gradeNumber >= 70 && gradeNumber <= 100)
        { 
            Console.WriteLine("Congratulations!! You passed!");
        }

        else if (gradeNumber >= 0 && gradeNumber <60)
        {
            Console.WriteLine("Sorry! You didn't pass! Keep working hard and you'll get it next time.");
        }

        else
        {
           Console.WriteLine("Invalid Value. Check the value of your input again in order to get the grade and find out if you passed."); 
        }
    }
}
public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", 
    "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 
    10)
    {
    }

    public BreathingActivity(int duration) 
            : base("Breathing Activity", 
                "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 
                duration)
        {
        }
    public void Run()
    {
        Console.Clear();
        
        DisplayStartingMessage();
        ShowSpinner(); 

        Console.Clear();
        Console.WriteLine("Breath in...");  
        ShowCountDown(); 

        Console.WriteLine("Breath out..."); 
        ShowCountDown(); 

        Console.Clear();
        Console.WriteLine("Good!"); 
        Console.WriteLine("Pause and Relax"); 
        ShowSpinner(); 

        Console.WriteLine("Let's go again :)"); 

        Console.Clear();
        Console.WriteLine("Let's go again :)"); 
        ShowSpinner(); 

        Console.WriteLine("Breath in...");  
        ShowCountDown(); 

        Console.WriteLine("Breath out..."); 
        ShowCountDown(); 


        Console.Clear();
        Console.WriteLine("Good!"); 
        ShowSpinner(); 

        DisplayEndingMessage();
        ShowSpinner(); 
        Console.Clear();
    }


}
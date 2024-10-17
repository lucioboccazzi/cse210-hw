public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine($"{_description}");
        Console.Write("How long, in seconds, would you like for your session? ");
        string secondInput = Console.ReadLine();

        _duration = int.Parse(secondInput);

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Excellent work! Remember to keep coming back and taking care of yourself :)");
    }

    public void ShowSpinner()
    {
        List<string>animationStrings = new List<string>()
        {
            "|", "/", "-", "\\", "|", "/", "-", "\\" 
        };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(4);

        while (DateTime.Now < endTime)
        {
            foreach (string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }

    public void ShowCountDown()
    {

        for (int i = _duration; i>0; i--)
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(i + "/");
            Thread.Sleep(1000);
        }

        Console.SetCursorPosition(0, Console.CursorTop);
    }

}
public class ReflectingActivity : Activity
{
    protected List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };

    protected List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() :base("Reflection Activity",
    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
    10)
    {
    }

    public ReflectingActivity(int duration) 
            : base("Reflection Activity",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
            duration)
        {
        }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        DateTime activityStartTime = DateTime.Now;

        while ((DateTime.Now - activityStartTime).TotalSeconds < _duration)
        {
            DisplayPrompt();

            Console.WriteLine("Reflect on the prompt...");
            ShowSpinner(3);

            DisplayQuestion();

            Console.WriteLine("Pause and reflect on the question...");
            ShowSpinner(3); 
        }

        DisplayEndingMessage();
        ShowSpinner(); 
        Console.Clear();
    }

    public string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        var random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }
    public void DisplayQuestion()
    {
        Console.WriteLine(GetRandomQuestion());
    }

}
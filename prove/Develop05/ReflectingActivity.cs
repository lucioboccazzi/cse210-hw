// public class ReflectingActivity : Activity
// {
//     protected List<string> _prompts = new List<string>
//     {
//         "Think of a time when you stood up for someone else.",
//         "Think of a time when you did something really difficult.",
//         "Think of a time when you helped someone in need.",
//         "Think of a time when you did something truly selfless.",
//     };

//     protected List<string> _questions = new List<string>
//     {
//         "Why was this experience meaningful to you?",
//         "Have you ever done anything like this before?",
//         "How did you get started?",
//         "What made this time different than other times when you were not as successful?",
//         "What is your favorite thing about this experience?",
//         "What could you learn from this experience that applies to other situations?",
//         "What did you learn about yourself through this experience?",
//         "How can you keep this experience in mind in the future?"
//     };

//     public ReflectingActivity() :base

//     public void Run()
//     {

//     }
//     public string GetRandomPrompt()
//     {
//         var random = new Random();
//         int index = random.Next(_prompts.Count);
//         return _prompts[index];
//     }

//     public string GetRandomQuestion()
//     {
//         var random = new Random();
//         int index = random.Next(_questions.Count);
//         return _questions[index];
//     }
//     public void DisplayPrompt()
//     {
//         Console.WriteLine(GetRandomPrompt());
//     }
//     public void DisplayQuestion()
//     {
//         Console.WriteLine(GetRandomQuestion());
//     }

// }
public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something trully selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was the experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What is your favourite thing about this experience?",
        "What made this time different than other times when you where not successfull",
        "How can you keep this experenice inm mind in the future",
        "What could you learn from this experience that applies to future situations",
        "What did you learn about yourself through this experience?"
    };

    private static List<string> _remainingPrompts = null;
    private static List<string> _remainingQuestions = null;
    private static Random _random = new Random();

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {}

    private string GetNextPrompt()
    {
        if (_remainingPrompts == null || _remainingPrompts.Count == 0)
        {
            _remainingPrompts = new List<string>(_prompts);
        }

        int index = _random.Next(_remainingPrompts.Count);
        string p = _remainingPrompts[index];
        _remainingPrompts.RemoveAt(index);
        return p;
    }

    private string GetNextQuestion()
    {
        if (_remainingQuestions == null || _remainingQuestions.Count == 0)
        {
            _remainingQuestions = new List<string>(_questions);
        }

        int index = _random.Next(_remainingQuestions.Count);
        string q = _remainingQuestions[index];
        _remainingQuestions.RemoveAt(index);
        return q;
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetNextPrompt();

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"----{prompt}----");
        Console.WriteLine();

        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the follwing questions as they relate to this experience.");
        Console.Write("You may begin:");
        ShowCountDown(5);
        Console.Clear();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = GetNextQuestion();
            Console.WriteLine(question);
            ShowSpinner(10);
            Console.WriteLine();

        }   

        DisplayEndingMessage();         

    }
}
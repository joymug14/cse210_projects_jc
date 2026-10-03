public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are the people you appreciate?",
        "What are your personal strengths?",
        "When have you felt the Holy Ghost prompts this week?",
        "How many people did you help this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things a you can in a certain area.")
    {}

    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        Console.Write("You may begin:");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> answers = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            string answer = Console.ReadLine();
            answers.Add(answer);

        } 

        Console.WriteLine($"You have listed {answers.Count} items!");  

        DisplayEndingMessage();         

    }
}
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine($"How long in seconds would you like for this session?");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine($"Get ready...");
        ShowSpinner(5);
    
 
    }
     public void DisplayEndingMessage()
    {
        Console.WriteLine($"Good Job!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}");
        ShowSpinner(5);
        Console.WriteLine("Press enter to continue...");
        Console.ReadLine();
        
    }
    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
        Console.Write(".");
        Thread.Sleep(500);
        }

        Console.WriteLine();
        
         
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();

    }
}



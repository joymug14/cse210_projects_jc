using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator prompts = new PromptGenerator();
        string choice = "";
        while (choice != "5")
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = prompts.GetRandomPrompt();
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
                string date = DateTime.Now.ToShortDateString();

                Entry entry = new Entry();
                entry._date = date;
                entry._promptText = prompt;
                entry._entryText = response;

                journal.AddEntry(entry);
            }

            else if (choice == "2")
            {
                journal.DisplayAll();
            }

            else if (choice == "3")
            {
                Console.Write("What is your prefered filename? ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);

            }

            else if (choice == "4")
            {
                Console.Write("What is your prefered filename? ");
                string file =Console.ReadLine();
                journal.LoadFromFile(file);
            }
        }
    }
}
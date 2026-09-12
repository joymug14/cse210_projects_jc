using System.Collections.Generic;

public class PromptGenerator 
{
    public List<string> _prompts = new List<string>
    {
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "What was the best part of my day?",
        "What made me smile today?",
        "Who was the most interesting person I interacted with today?",
        "Is there anything new that I learnt today? ",
        "Did I help anyone that needed help today?",
        "What could I have done better today?",
        "If there is one thing I could do over today, what would it be?"

    };

    public string GetRandomPrompt()
    {
        System.Random random = new System.Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
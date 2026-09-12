using System.Collections.Generic;

public class PromptGenerator 
{
    public List<string> _prompts = new List<string>
    {
        "How did i see the hsnd of the lord in my life today?",
        "What was the strongest emotion i felt today?",
        "What was the best part of my day?",
        "What made me smile today?",
        "Who was the most interesting person I interacted with today?",
        "Is ther anything new that I learnt today? ",
        "Did I help anyone that needed help today?",
        "What could i have done better today?",
        "If there is one thing i could do over today, what would it be?"

    };

    public string GetRandomPrompt()
    {
        System.Random random = new System.Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
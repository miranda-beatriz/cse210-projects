using System;
public class PromptGenerator
{
    public List<string> _prompts = new List<string>{
        "What made you smile today?",
        "Who made your day special?",
        "What have you done for someone else today?",
        "What is something you don’t want to forget about today?",
        "If you could change something, what would you have done differently?",
        "What were you grateful for today?",
        "What would you like to share with a friend about today?"

    };

    public string GetRandomPrompt()
    {
         Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
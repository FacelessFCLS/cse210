public class PromptGenerator
{
    public static Random _random = new Random();
    List<string> _prompts = new List<string>
    {
        "What was the best part of your day?",
        "What are you grateful for today?",
        "Describe a challenge you faced and how you overcame it.",
        "What is something new you learned today?",
        "Write about a memorable moment from your day.",
        "How did you make someone smile today?",
        "What is a goal you have for tomorrow?",
        "Reflect on a positive interaction you had with someone today.",
        "What is something that made you laugh today?",
        "Describe a moment when you felt proud of yourself today.",
        "Describe one intrusive thought you had today."
    };

    public string GetRandomPrompt()
    {
       int index = _random.Next(_prompts.Count);
       return _prompts[index]; 
    }
}
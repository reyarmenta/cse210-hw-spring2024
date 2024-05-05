public class PromptGenerator
{
    public List<string> _prompt = new List<string>
    {
        "Who did you talk to today?",
        "What was the best part of your day?",
        "What is one thing that you wish you could change from today?",
        "What new thing did you learn today?",
        "How did you feel today?"
    };
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompt.Count);

        return _prompt[index];
    }
}
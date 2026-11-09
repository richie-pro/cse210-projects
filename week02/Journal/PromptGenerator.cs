public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public PromptGenerator()
    {
        {
            _prompts.Add("What is something you are grateful for today?");
            _prompts.Add("Describe a challenge you faced recently and how you overcame it.");
            _prompts.Add("Write about a memorable experience from your childhood.");
            _prompts.Add("What are your goals for the next month?");
            _prompts.Add("Reflect on a time when you helped someone and how it made you feel.");
        }
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
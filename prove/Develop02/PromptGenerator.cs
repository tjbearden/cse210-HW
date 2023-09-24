
public class PromptGenerator {
    
    List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>()
        {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "Did you read your scriptures today?",
        "Would you like to play a game of global thermonuclear war?",
        "Free Form!", 
        "What would you like to talk about today?",
        "what did you dream about last night? "
        };
    }

    public string GetPrompt()
        {
            Random rndm = new Random();
            int index = rndm.Next(0, _prompts.Count());
            return _prompts[index];
        }

    }

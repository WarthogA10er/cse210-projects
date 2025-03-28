public class PromptGenerator
    {
        
        public List<string> _prompts;

        public PromptGenerator()
        {
            _prompts = new List<string> {"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", "What is something that made you smile today?", "What is something new you learned or did today?", "What is a goal you set, accomplished, or made progress towards today?"};
        }
        public string GetRandomPrompt(List<string> _prompt)
        {
            // Random object
            Random rnd = new Random();

            // Get random index
            int index = rnd.Next(_prompt.Count);

            string prompt = (_prompt[index]);
            return prompt;
        }
    }



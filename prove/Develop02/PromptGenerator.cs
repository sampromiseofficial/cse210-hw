using System;

class PromptGenerator
{
    public List<string> prompts;

    public PromptGenerator()
    {
        // Initialize with some example prompts
        prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What are your goals for tomorrow?",
            "what have you archive today?",
            "How did you take good care of your physical and mental wellbeing today?",
            "What are the activities and schedule for today?",
            "What is that thing you do everyday that makes you happy and gives you joy?",
            "What did you learn today?",
            "What are your activities and schedule for this week?",
            "Where would you like to travel to for holiday?",
            "Who made your day today?",
            "Where are you planning to go/visit today?",
            "What did you eat for breakfast?",
            "What are you thinking of right now?",
            "What did you eat for lunch?",
            "What are your challenges for today?",
            "What did you eat for dinner?",
            "Have you say your prayer today?",
            "when was the last time you visited the temple?",
            "Are you a christian?",
            "What did you study in school?",
            "Have you given your life to Christ?",
            "Are you married or single?",
            "What are your wishes this year?",
            "What is your date of birth?",
            "Have you being to the mountain before?",
            "Where did you eat your breakfast?",
            "Who visited you yesterday?",
            "When was the last time you read your Bible?",
            "Where did you eat your lunch?",
            "Are you willing to learn new things everyday?",
            "How was your day?",
            

            

        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}
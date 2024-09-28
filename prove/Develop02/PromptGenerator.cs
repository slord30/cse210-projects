using System;
using System.Collections.Generic;

class PromptGenerator
{
  public static string GetRandomPrompt()
  {
    List<string> prompts = new List<string>
        {
            "Who was the most intersting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotiion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "Consider what challenges you faced today and how you overcame them.",
            "What do you feel most grateful for today?",
            "Think about what you did today that brought you joy or fulfillment.",
            "What was a small act of kindness I witness or experience today?",
            "What promptings did you feel today that you should act on?"
        };

    Random random = new Random();
    int index = random.Next(prompts.Count);
    return prompts[index];
  }
}
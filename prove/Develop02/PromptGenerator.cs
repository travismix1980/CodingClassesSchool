namespace JournalApp
{
  // this Class generates randomly chosen writing prompts
  public class PromptGenerator
  {
    // readonly (not writable to at runtime) string array of writing prompts
    private readonly string[] prompts = {
      "What happened today?",
      "What was the best thing that happened today?",
      "What did you learn today?",
      "What was the most fun thing I did today?",
      "What is the current problem or challenge you am facing?",
      "What is one place or environment that inspires your creativity, and how can I create more opportunities to be in that space?",
      "What are your passions and interests, and how can you incorporate them into your work or personal life?",
      "What is one small creative project that you can do today, and how can you make it unique to your personal style?",
      "Write a story from the perspective of an inanimate object that has come to life.",
      "Write a story that begins with the sentence 'The door creaked open, revealing a long-forgotten room.'",
      "Write a story about a character who discovers a mysterious book with a hidden message.",
      "How am you feeling today?",
      "What are your top priorities for the day?",
      "What was the most memorable dream you had last night? Write down as many details as you can remember.",
      "If you could ask a dream character any question, who would you choose, and what would you ask them?",
      "What is the most common type of dream you have (like nightmares, flying dreams, etc.)? What do you think it says about your psyche?",
      "What did you learn today?",
      "How did you show gratitude today?",
      "What were some challenges you faced today and how did you overcome them?",
      "What is something silly that always makes you laugh?",
      "If I could live in any time period or place, where would I choose and why?",
      "What is one thing you can’t live without?",
      "If you could be any fictional character, who would you choose and why?",
      "What are your top three goals for this year?",
      "What are three things that are holding you back from achieving your goals?",
      "What brings you the most joy and fulfillment, and how can you make time for those things in your life?",
      "What are the most important relationships in your life? How can you strengthen them?",
      "What are my personal values and beliefs? How do they shape my identity?",
      "What life experiences have shaped who you are today?",
      "What are your favorite hobbies or activities?",
      "What skills do you possess that could be applied to a new hobby or activity?",
      "What am you afraid of?",
      "What problems would you like to solve this year?",
      "What are your strengths and weaknesses? Consider the things you’re good at and the areas where you struggle.",
      "What are some things that make you feel confident?",
      "How can you embrace your unique qualities and use them to your advantage?",
      "How do you think others perceive you?",
      "When do I feel the need to lie, and what is the worst lie I’ve told?",
      "What are some of the sources of stress in my life right now?",
      "How can I reframe negative thoughts and maintain a positive outlook?",
      "How can I set realistic expectations and boundaries to reduce stress?"
    };

    // this generates a random number between 0 and max
    // to get a random prompt from the array of prompts and
    // returns the prompt
    public string GetRandomPrompt()
    {
      Random rand = new();
      int index = rand.Next(0, prompts.Length);
      return prompts[index];
    }
  }
}

namespace JournalApp
{
  // this is a required class for the assignment
  // you need to have the three things to save for the journal
  // a string for the randomly created prompt
  // a string for the user input
  // a date for the entry
  // FinalizedEntry I added to keep loading and saving
  // to text files as well as output
  public class Entry
  {
    public string Prompt { get; set; }
    public string Post { get; set; }
    public DateTime Date { get; set; }
    public string FinalizedEntry { get; set; }

    /// <summary>
    /// Creates new entries from journal posts
    /// </summary>
    /// <param name="prompt">Writing prompt</param>
    /// <param name="post">User journal Entry</param>
    /// <param name="date">Date of journal entry</param>
    public Entry(string prompt, string post, DateTime date)
    {
      Prompt = prompt;
      Post = post;
      Date = date;

      FinalizedEntry = $"Date: {date.ToString("dddd MMMM dd, yyyy")} Prompt: {prompt} Post: {post}";
    }

    /// <summary>
    /// Used for loading journal entries from save file
    /// </summary>
    /// <param name="entry">line entry from text file</param>
    public Entry(string entry)
    {
      FinalizedEntry = entry;
    }
  }
}

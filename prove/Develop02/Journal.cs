namespace JournalApp
{
  public class Journal
  {
    public List<Entry> entries = new();
    public string EntryPrompt { get; set; }
    public string EntryPost { get; set; }
    public DateTime Date { get; set; }

    public void CreateEntry()
    {
      PromptGenerator prompt = new();
      EntryPrompt = prompt.GetRandomPrompt();
      Date = DateTime.Today;
      Console.WriteLine(); // Spacing
      Console.WriteLine($"Prompt: {EntryPrompt}");
      EntryPost = Console.ReadLine();
      entries.Add(new Entry(EntryPrompt, EntryPost, Date));
      Console.WriteLine(); // spacing
    }

    public void NewJournal()
    {
      // prompt for save
      Console.Write("Would you like to save current journal first (y\\n)? ");
      string decision = Console.ReadLine().ToLower().Trim();
      decision = decision[0].ToString();

      if (decision == "y")
      {
        Save();
      }
      entries.Clear();
      Console.WriteLine("New Journal Created... Feel free to make more posts using the Write Option...");
      Console.WriteLine();
    }

    public void Display()
    {
      foreach (var post in entries)
      {
        string[] userPost = post.FinalizedEntry.Split("Post:");
        string[] userPost2 = userPost[0].Split("Prompt:");
        Console.WriteLine(userPost2[0]);
        Console.WriteLine($"Prompt: {userPost2[1]}");
        Console.WriteLine($"Post: {userPost[1]}\n");
      }
    }

    public void Load()
    {
      Console.WriteLine("Enter the file you would like to load?");
      Console.WriteLine("Enter only the file name no extensions (.txt, .csv, etc.)");
      Console.Write("Only text files created by this program please ");
      string fileName = Console.ReadLine();
      fileName += ".txt";

      //clear journalPosts and replace it with new file
      entries.Clear();
      FileManagement fm = new(fileName);
      entries = fm.LoadFile();
    }

    public void Save()
    {
      string fileName;
      Console.Write("Enter your filename with no extension (.txt, .csv, etc) ");
      fileName = Console.ReadLine();

      if (fileName == null)
      {
        Console.WriteLine("Error unable to save file without a filename!");
        Console.WriteLine("Please chose save from the menu and try again!");
      }
      else
      {
        fileName += ".txt";
        FileManagement fm = new(fileName, entries);
        fm.SaveFile();

        Console.WriteLine($"File saved as {fileName}");
        Console.WriteLine();
      }
    }
  }
}

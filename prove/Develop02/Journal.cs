namespace JournalApp
{
  // this is our big Class it handles all journal
  // related things
  public class Journal
  {
    // create a list to store objects of Class Entry
    public List<Entry> entries = new();

    // properties to hold all of our data needed
    // to create a new entry
    public string EntryPrompt { get; set; }
    public string EntryPost { get; set; }
    public DateTime Date { get; set; }

    // allows the user to make a new journal entry
    // it gets a random writing prompt
    // sets the date to current date
    // outputs the prompt to the console and
    // saves users input into post
    // creates a new Journal entry and adds it
    // to our list of entries.  Because it is
    // of type Entry (Class) we need to make a new
    // instance of the class each time before we can add it
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

    // asks if the user wants to save the current contents
    // of the entries list stored in our journal
    // and deletes the entries list in essence
    // creating a new journal
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

    // displays the contents of the journal to the console
    // most of this code is for formatting our journal output
    // into something more easy to look at and read
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

    // gets the information needed to load a text file
    // and hands it off to our FileManagement object for final loading
    // then it returns the data loaded from the text file so it can be stored
    // in our entry list
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

    // gets the information needed from the user to save our current
    // journal and passes it to our FileManagement to handle saving the text file
    // this and our Load method need more work to make it better probably by
    // making our FileManagement class static
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

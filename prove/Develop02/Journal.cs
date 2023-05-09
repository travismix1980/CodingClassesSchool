using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.IO;

namespace JournalApp
{
  public class Journal
  {
    public List<string> journalPosts = new();

    public List<string> writingPrompts = new();

    public Journal()
    {
      //read in and store our writing prompts
      foreach (var line in File.ReadAllLines("writing_prompts.txt"))
      {
        writingPrompts.Add(line.TrimEnd(',').Trim('"'));
      }

    }

    public int GetRandomNumber()
    {
      Random rand = new();
      return rand.Next(0, writingPrompts.Count);
    }

    public void Write()
    {
      //Console.WriteLine(today.ToString("dd/MM/yyyy"));
      string? userInput = "";
      DateTime today = DateTime.Today;
      // generate random number between 0 and writing prompts.length
      string prompt = writingPrompts[GetRandomNumber()];
      userInput += today.ToString("dd/MM/yyyy");
      Console.WriteLine(); // for spacing
      Console.WriteLine($"Prompt: {prompt}");
      Console.WriteLine();
      userInput += " " + prompt + "\n\n";
      userInput += Console.ReadLine();
      userInput += "\n";
      journalPosts.Add(userInput);
      Console.WriteLine(); // spacing
    }

    public void NewJournal()
    {
      // prompt for save
      Console.Write("Would you like to save current journal first (y\\n)? ");
      string decision = Console.ReadLine().ToLower().Trim();
      decision = decision[0].ToString();
      Console.WriteLine(decision);

      if (decision == "y")
      {
        Save();
      }
      journalPosts.Clear();
      Console.WriteLine("New Journal Created... Feel free to make more posts using the Write Option...");
      Console.WriteLine();
    }

    public void Display()
    {
      foreach (var post in journalPosts)
      {
        Console.WriteLine(post);
        Console.WriteLine(); // spacing
      }
    }

    public void Load()
    {
      Console.WriteLine("Enter the file you would like to load?");
      Console.WriteLine("Enter only the file name no extensions (.txt, .csv, etc.)");
      Console.Write("Only text files created by this program please ");
      string? fileName = Console.ReadLine();
      fileName += ".txt";

      //clear journalPosts and replace it with new file
      journalPosts.Clear();

      foreach (var line in File.ReadAllLines(fileName))
      {
        journalPosts.Add(line.TrimEnd());
      }
    }

    public void Save()
    {
      string? fileName;
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
        using (StreamWriter outputFile = new(fileName))
        {
          foreach (var post in journalPosts)
          {
            outputFile.WriteLine(post);
          }
        }

        Console.WriteLine($"File saved as {fileName}");
        Console.WriteLine();
      }
    }
  }
}

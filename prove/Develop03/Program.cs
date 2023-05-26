namespace Scripture
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Reference reference = new("Proverbs", "3", "5-6", "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight");
      Scripture scripture = new(reference);
      string userEntry = string.Empty;

      // display scripture to console and ask user to enter quit to quit or press enter to continue
      Console.WriteLine("Program will automatically end if you press ENTER and all words are hidden\n\n");
      Console.WriteLine(scripture.GetRenderedText());
      Console.WriteLine("\nPress Enter to hide words at Random or Enter 'quit' to exit: ");
      userEntry = Console.ReadLine();


      while (userEntry.ToLower() != "quit")
      {
        Console.Clear();
        scripture.HideWords();
        Console.WriteLine("Program will automatically end if you press ENTER and all words are hidden\n\n");
        Console.WriteLine(scripture.GetRenderedText());

        Console.WriteLine("\nPress Enter to hide words at Random or Enter 'quit' to exit: ");
        userEntry = Console.ReadLine();


        //if scripture is shown with all the words missing already go ahead and quit the program
        // when the user presses enter instead of hiding more words
        if (scripture.IsCompletelyHidden())
        {
          userEntry = "quit";
        }
      }
    }
  }
}

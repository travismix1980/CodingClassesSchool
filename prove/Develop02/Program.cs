namespace JournalApp
{
  public class Program
  {

    // main entry point for our code
    // it generates an instance of all needed Classes
    // and runs a loop to keep the program running till
    // the user wants to quit
    // then we display the menu output and chose our code
    // based on the users input.
    static void Main(string[] args)
    {
      Menu menu = new();
      Journal journal = new();
      bool flag = true;
      while (flag)
      {
        menu.MenuOutput();

        switch (menu.UserChoice)
        {
          case 1:
            journal.CreateEntry();
            break;
          case 2:
            journal.NewJournal();
            break;
          case 3:
            journal.Display();
            break;
          case 4:
            journal.Load();
            break;
          case 5:
            journal.Save();
            break;
          // case 6 and default set the flag var to false and quit the program
          case 6:
            flag = Quit();
            break;
          default:
            flag = Quit();
            break;
        }
      }
    }
    public static bool Quit(){
      Console.WriteLine("Thank you for using the journal program!");
      Console.WriteLine("Closing now");
      return false;
    }


  }
}

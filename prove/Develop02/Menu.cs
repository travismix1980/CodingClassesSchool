namespace JournalApp
{
  // menu class holds the menu options and displays them
  // it also gets the users choice from the prompt as
  // to what functionality they want to use that is used
  // in main to allow the code to route to the right functionality.
  public class Menu
  {
    // string array that is read only (cant write to it) to
    // hold the menu options to display
    private readonly string[] menuPrompts = new string[] {
            "Write",
            "New Journal",
            "Display",
            "Load",
            "Save",
            "Quit"
        };
    // holds the users menu choice that gets used by main to route to the right
    // code for the users chosen menu option
    public int UserChoice { get; private set; }

    // displays the menu to the console
    public void MenuOutput()
    {
      Console.WriteLine("Please select one of the following choices");
      for (int i = 0; i < menuPrompts.Length; i++)
      {
        Console.WriteLine($"{i + 1}) {menuPrompts[i]}");
      }
      Console.Write("What would you like to do? ");
      UserChoice = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(); // spacing
    }
  }
}

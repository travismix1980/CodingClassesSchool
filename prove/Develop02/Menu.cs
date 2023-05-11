namespace JournalApp
{
  public class Menu
  {
    Journal j = new();

    private string[] menuPrompts = new string[] {
            "Write",
            "New Journal",
            "Display",
            "Load",
            "Save",
            "Quit"
        };

    public int UserChoice { get; private set; }

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

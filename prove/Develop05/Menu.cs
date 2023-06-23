public abstract class Menu
{
  List<string> _menuOptions;

  /// <summary>
  /// outputs the menu to the console
  /// </summary>
  /// <returns>(int) the user choice from the menu</returns>
  public virtual void ShowMenu()
  {
    int count = 1;
    foreach (string mo in _menuOptions)
    {
      Console.WriteLine($"{count}. {mo}");
      count++;
    }
    Console.WriteLine(); // spacing
    Console.Write("Enter your choice: ");
  }

/// <summary>
/// Reads and returns the userchoice from the menu
/// </summary>
/// <returns></returns>
  public virtual int GetMenuChoice(){
    return Convert.ToInt32(Console.ReadLine());
  }
}

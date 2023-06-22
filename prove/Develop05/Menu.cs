public abstract class Menu
{
  List<string> _menuOptions;

  /// <summary>
  /// outputs the menu to the console
  /// </summary>
  /// <returns>(int) the user choice from the menu</returns>
  public virtual int ShowMenu()
  {
    int count = 1;
    foreach (string mo in _menuOptions)
    {
      Console.WriteLine($"{count}. {mo}");
      count++;
    }
    Console.WriteLine(); // spacing
    Console.Write("Select a choice from the menu: ");
    return Convert.ToInt32(Console.ReadLine());
  }
}

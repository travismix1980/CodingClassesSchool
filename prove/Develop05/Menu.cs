public class Menu{
  /// <summary>
  /// a list containing all the menu options
  /// </summary>
  List<string> _menuOptions;

/// <summary>
/// Creates _menuOptions and fills it with menu options
/// </summary>
  public Menu(){
    _menuOptions = new();
    _menuOptions.Add("Create New Goal");
    _menuOptions.Add("List Goals");
    _menuOptions.Add("Save Goals");
    _menuOptions.Add("Load Goals");
    _menuOptions.Add("Record Event");
    _menuOptions.Add("Show Total Points");
    _menuOptions.Add("Quit");
  }

/// <summary>
/// outputs the menu to the console
/// </summary>
/// <returns>(int) the user choice from the menu</returns>
  public int ShowMenu(){
    int count = 1;
    foreach(string mo in _menuOptions){
      Console.WriteLine($"{count}. {mo}");
      count++;
    }
    Console.WriteLine(); // spacing
    Console.Write("Select a choice from the menu: ");
    return Convert.ToInt32(Console.ReadLine());
  }
}

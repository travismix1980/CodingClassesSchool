public class Menu{
  /// <summary>
  /// This is our list of menu options
  /// We store each menu item in our sub
  /// classes here
  /// </summary>
  protected List<string> _menuOptions;
  /// <summary>
  /// _menu holds our constructed menu
  /// created in the ConstructMenu method
  /// and output in the
  /// </summary>
  protected string _menu;

  public Menu(){
    _menuOptions = new();
    _menu = "";
  }

/// <summary>
/// outputs our menu to the console window
/// </summary>
  public void ShowMenu(){
    Console.WriteLine(_menu);
  }

/// <summary>
/// puts together our menu in a string for outputting
/// </summary>
  public void ConstructMenu(){
    for(int i = 1; i < _menuOptions.Count(); i++){
      _menu += $"{i}) {_menuOptions[i]} \n";
    }
  }
}

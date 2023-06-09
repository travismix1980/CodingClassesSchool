public class MainMenu : Menu{
  /// <summary>
  /// a list containing all the menu options
  /// </summary>

/// <summary>
/// Creates _menuOptions and fills it with menu options
/// </summary>
  public MainMenu(){
    _menuOptions = new();
    _menuOptions.Add("Create New Goal");
    _menuOptions.Add("List Goals");
    _menuOptions.Add("Save Goals");
    _menuOptions.Add("Load Goals");
    _menuOptions.Add("Record Goal");
    _menuOptions.Add("Show Total Points");
    _menuOptions.Add("Show Current Level");
    _menuOptions.Add("Quit");
  }

  public override void ShowMenu()
  {
    base.ShowMenu();
  }
}

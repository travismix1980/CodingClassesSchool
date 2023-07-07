public class MainMenu : Menu{
  public MainMenu(){
    _menuOptions.Add("Play a Round of BlackJack");
    _menuOptions.Add("Read Rules");
    _menuOptions.Add("Visit ATM");
    _menuOptions.Add("Save Game");
    _menuOptions.Add("Quit");
    base.ConstructMenu();
  }
}

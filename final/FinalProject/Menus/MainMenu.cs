public class MainMenu : Menu{
  public MainMenu(){
    _menuOptions.Add("Play BlackJack");
    _menuOptions.Add("Read Rules");
    _menuOptions.Add("Visit ATM");
    _menuOptions.Add("Quit");
    base.ConstructMenu();
  }
}

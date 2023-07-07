public class MenuController{

  MainMenu mm;
  SaveMenu sm;
  ATMMenu am;
  public MenuController(){
    mm = new();
    sm = new();
    am = new();
  }
  public void DisplayMainMenu(){
    mm.ShowMenu();
  }

  public int GetMainMenuChoice(){
    return mm.GetMenuChoice();
  }

  public void DisplaySaveMenu(){
    sm.ShowMenu();
  }

  public int GetSaveMenuChoice(){
    return sm.GetMenuChoice();
  }

  public void DisplayATMMenu(){
    am.ShowMenu();
  }

  public int GetATMMenuChoice(){
    return am.GetMenuChoice();
  }
}

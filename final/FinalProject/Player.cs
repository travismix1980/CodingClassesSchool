public class Player : Person{

  private double _currentBet;
  public Player(){}

// TODO: Finish player
  public void GetInsurance(){
    Console.WriteLine("Player purchases insurance");
  }

  public void DoubleDown(){
    Console.WriteLine("Player Doubles Down");
  }

  public void Split(){
    Console.WriteLine("Player splits their hand");
  }

  public void Bet(double betAmount){
    Console.WriteLine($"Player bets {betAmount}");
  }

  private double GetCurrentBet(){
    return _currentBet;
  }
}

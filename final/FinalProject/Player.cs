public class Player : Person{
  private double _currentBet;
  private double _splitCurrentBet;
  Money _playerMoney;
  private Card[] _secondHand;
  public Player(double playerMoney){
    _playerMoney = new(playerMoney);
  }

// TODO: Finish player
  public void GetInsurance(){
    if(_playerMoney.GetMoneyOnPerson() >= _currentBet / 2){
      _playerMoney.SetMoneyOnPerson(-(_currentBet / 2));
      Console.WriteLine("You have purchased Insurance. Good Luck...");
    } else {
      Console.WriteLine("You don't have enough money to purchase insurance");
    }
  }

  public void DoubleDown(){
    if(_playerMoney.GetMoneyOnPerson() >= _currentBet){
      _playerMoney.SetMoneyOnPerson(-_currentBet);
      _currentBet += _currentBet;
      // player doubles down and receives only one more card
    } else {
      Console.WriteLine("You cannot afford to double down");
    }
  }

  public void Split(){
    if(_playerMoney.GetMoneyOnPerson() >= _currentBet){
      _playerMoney.SetMoneyOnPerson(-_currentBet);
      _splitCurrentBet = _currentBet;
    } else {
      Console.WriteLine("You cannot afford to split");
    }
  }

  public void Bet(double minBet){
    do{
      Console.Write("How much would you like to bet? $");
      _currentBet = Convert.ToDouble(Console.ReadLine());
    }while(_currentBet < minBet || _currentBet > _playerMoney.GetMoneyOnPerson());
    _playerMoney.SetMoneyOnPerson(-_currentBet);
  }

  private double GetCurrentBet(){
    return _currentBet;
  }
}

public class Player : Person{
  private double _currentBet;
  private double _splitCurrentBet;
  Money _playerMoney;
  private bool _hasDoubledDown;
  private bool _hasSplit;
  private bool _hasStood;
  private List<Card> _secondHand;
  public Player(double playerMoney, string name){
    base.SetName(name);
    _playerMoney = new(playerMoney);
    _hasDoubledDown = false;
    _hasSplit = false;
    _secondHand = new();
    _hasStood = false;
  }

  public void AddCardToSecondHand(Card c){
    _secondHand.Add(c);
  }

  public List<Card> GetSecondHand(){
    return _secondHand;
  }

  public void RemoveCardFromHand(int handLocation){
    _cards.RemoveAt(handLocation);
  }

  public double GetCurrentMoney(){
    return _playerMoney.GetMoneyOnPerson();
  }

  public void SetCurrentMoney(double money){
    _playerMoney.SetMoneyOnPerson(money);
  }

// TODO: Finish player
  public void GetInsurance(){
    if(_playerMoney.GetMoneyOnPerson() >= (_currentBet / 2)){
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
    _hasDoubledDown = true;
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

  public double GetCurrentBet(){
    return _currentBet;
  }

  public void SetCurrentBet(double bet){
    _currentBet = bet;
  }

  public bool CanDoubleDown()
  {
    if(!_hasDoubledDown){
      return true;
    }
    return false;
  }

  public void SetDoubledDown(bool doubleDown){
    _hasDoubledDown = doubleDown;
  }

  public bool CanSplit()
  {
    if(_cards.Count < 3){
      if(_cards[0] == _cards[1]){
        if(!_hasSplit){
          return true;
        }
      }
    }
    return false;
  }

  public bool CanPurchaseInsurance(Card dealerFaceUp)
  {
    if(dealerFaceUp.GetCardValue() == "Ace"){
      return true;
    }
    return false;
  }


  public void SetHasStood(bool stand){
    _hasStood = stand;
  }

  public bool GetHasStood(){
    return _hasStood;
  }
}

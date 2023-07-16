public class Player : Person
{
  private double _currentBet;
  Money _playerMoney;
  private bool _hasDoubledDown;

  private List<Card> _secondHand;
  public Player(double playerMoney, string name)
  {
    base.SetName(name);
    _playerMoney = new(playerMoney);
    _hasDoubledDown = false;
    _secondHand = new();
    _hasStood = false;
  }

  public void AddCardToSecondHand(Card c)
  {
    _secondHand.Add(c);
  }


  public double GetCurrentMoney()
  {
    return _playerMoney.GetMoneyOnPerson();
  }

  public void SetCurrentMoney(double money)
  {
    _playerMoney.SetMoneyOnPerson(money);
  }

  public void DoubleDown(Dealer dealer)
  {
    if (_playerMoney.GetMoneyOnPerson() >= _currentBet)
    {
      _playerMoney.SetMoneyOnPerson(-_currentBet);
      _currentBet += _currentBet;
      // player doubles down and receives only one more card
      AddCardToHand(dealer.Deal());
      Stand();
      _handValue = CalcHandValue();
    }
    else
    {
      Console.WriteLine("You cannot afford to double down");
    }
    _hasDoubledDown = true;
  }

  public void Bet(double minBet)
  {
    do
    {
      Console.WriteLine($"You have ${_playerMoney.GetMoneyOnPerson()}");
      Console.Write("How much would you like to bet? $");
      _currentBet = Convert.ToDouble(Console.ReadLine());
    } while (_currentBet < minBet || _currentBet > _playerMoney.GetMoneyOnPerson());
    _playerMoney.SetMoneyOnPerson(-_currentBet);
  }

  public double GetCurrentBet()
  {
    return _currentBet;
  }

  public void SetCurrentBet(double bet)
  {
    _currentBet = bet;
  }

  public bool CanDoubleDown()
  {
    if (!_hasDoubledDown)
    {
      return true;
    }
    return false;
  }

  public void SetDoubledDown(bool doubleDown)
  {
    _hasDoubledDown = doubleDown;
  }

  // public bool CanSplit()
  // {
  //   if(_cards.Count < 3){
  //     if(_cards[0] == _cards[1]){
  //       if(!_hasSplit){
  //         return true;
  //       }
  //     }
  //   }
  //   return false;
  // }

  // public bool CanPurchaseInsurance(Card dealerFaceUp)
  // {
  //   if(dealerFaceUp.GetCardValue() == "Ace"){
  //     return true;
  //   }
  //   return false;
  // }



}

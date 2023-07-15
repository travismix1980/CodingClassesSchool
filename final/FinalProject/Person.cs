public abstract class Person{
  private string _name;
  protected List<Card> _cards;
  protected int _handValue; // total int value of cards in hand
  protected bool _hasStood;
  protected bool _hasBusted;

  public Person(){
    _cards = new();
    _hasStood = false;
    _hasBusted = false;
  }

  public virtual List<Card> GetHand(){
    return _cards;
  }

  public virtual void AddCardToHand(Card c){
    _cards.Add(c);
  }

  public virtual void Hit(Dealer dealer){
    AddCardToHand(dealer.Deal());
    _handValue = CalcHandValue();
  }

  public virtual void Stand(){
    SetHasStood(true);
    _handValue = CalcHandValue();
  }

  public int CalcHandValue(){
    int total = 0;
    foreach(var c in _cards){
      if(c.GetCardValue() != "Ace"){
      total += c.GetPipsValue(c);
      }
    }
    foreach(var c in _cards){
      if(c.GetCardValue() == "Ace"){
        total += c.HandleAces(total);
      }
    }
    return total;
  }

  public void HasBusted(int handValue){
    if(handValue > 21){
      Console.WriteLine("Busted");
      SetHasBusted(true);
      Stand();
    }
  }

  public bool GetHasBusted(){
    return _hasBusted;
  }

  public void SetName(string name){ _name = name; }

  public string GetName(){ return _name; }

  protected List<Card> GetCurrentCards(){
    return _cards;
  }

  public void SetHasStood(bool stand){
    _hasStood = stand;
  }

  public bool GetHasStood(){
    return _hasStood;
  }

  public void SetHasBusted(bool busted){
    _hasBusted = busted;
  }

  public int GetHandValue(){
    return _handValue;
  }
}

public abstract class Person{
  private string _name;
  protected List<Card> _cards;
  protected int _handValue; // total int value of cards in hand

  public Person(){
    _cards = new();
  }

  public virtual List<Card> GetHand(){
    return _cards;
  }

  public virtual void AddCardToHand(Card c){
    _cards.Add(c);
  }

  public virtual void Hit(){}

  public virtual void Stand(){}

  public int CalcHandValue(){
    // TODO: Deal with aces
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

  public void SetName(string name){ _name = name; }

  public string GetName(){ return _name; }

  protected List<Card> GetCurrentCards(){
    return _cards;
  }
}

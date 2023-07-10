public class Deck{
  private List<Card> _cards;

  public Deck(){
    _cards = new();
    _cards.Add(new Card("Hearts", "Ace"));
    _cards.Add(new Card("Hearts", "One"));
    _cards.Add(new Card("Hearts", "Two"));
    _cards.Add(new Card("Hearts", "Three"));
    _cards.Add(new Card("Hearts", "Four"));
    _cards.Add(new Card("Hearts", "Five"));
    _cards.Add(new Card("Hearts", "Six"));
    _cards.Add(new Card("Hearts", "Seven"));
    _cards.Add(new Card("Hearts", "Eight"));
    _cards.Add(new Card("Hearts", "Nine"));
    _cards.Add(new Card("Hearts", "Ten"));
    _cards.Add(new Card("Hearts", "Jack"));
    _cards.Add(new Card("Hearts", "Queen"));
    _cards.Add(new Card("Hearts", "King"));
    _cards.Add(new Card("Diamonds", "Ace"));
    _cards.Add(new Card("Diamonds", "One"));
    _cards.Add(new Card("Diamonds", "Two"));
    _cards.Add(new Card("Diamonds", "Three"));
    _cards.Add(new Card("Diamonds", "Four"));
    _cards.Add(new Card("Diamonds", "Five"));
    _cards.Add(new Card("Diamonds", "Six"));
    _cards.Add(new Card("Diamonds", "Seven"));
    _cards.Add(new Card("Diamonds", "Eight"));
    _cards.Add(new Card("Diamonds", "Nine"));
    _cards.Add(new Card("Diamonds", "Ten"));
    _cards.Add(new Card("Diamonds", "Jack"));
    _cards.Add(new Card("Diamonds", "Queen"));
    _cards.Add(new Card("Diamonds", "King"));
    _cards.Add(new Card("Clubs", "Ace"));
    _cards.Add(new Card("Clubs", "One"));
    _cards.Add(new Card("Clubs", "Two"));
    _cards.Add(new Card("Clubs", "Three"));
    _cards.Add(new Card("Clubs", "Four"));
    _cards.Add(new Card("Clubs", "Five"));
    _cards.Add(new Card("Clubs", "Six"));
    _cards.Add(new Card("Clubs", "Seven"));
    _cards.Add(new Card("Clubs", "Eight"));
    _cards.Add(new Card("Clubs", "Nine"));
    _cards.Add(new Card("Clubs", "Ten"));
    _cards.Add(new Card("Clubs", "Jack"));
    _cards.Add(new Card("Clubs", "Queen"));
    _cards.Add(new Card("Clubs", "King"));
    _cards.Add(new Card("Spades", "Ace"));
    _cards.Add(new Card("Spades", "One"));
    _cards.Add(new Card("Spades", "Two"));
    _cards.Add(new Card("Spades", "Three"));
    _cards.Add(new Card("Spades", "Four"));
    _cards.Add(new Card("Spades", "Five"));
    _cards.Add(new Card("Spades", "Six"));
    _cards.Add(new Card("Spades", "Seven"));
    _cards.Add(new Card("Spades", "Eight"));
    _cards.Add(new Card("Spades", "Nine"));
    _cards.Add(new Card("Spades", "Ten"));
    _cards.Add(new Card("Spades", "Jack"));
    _cards.Add(new Card("Spades", "Queen"));
    _cards.Add(new Card("Spades", "King"));
  }

  public List<Card> GetDeck(){
    return _cards;
  }

  public void SetDeck(List<Card> cards){
    _cards.Clear();
    _cards = cards;
  }
}

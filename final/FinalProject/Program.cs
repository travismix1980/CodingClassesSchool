class Program
{
    static void Main(string[] args)
    {
        // Controller c = new();
        // c.RunBlackJack();

        Dealer d = new(1);
        d.Shuffle();
    }
}

namespace JournalApp
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Menu menu = new();
      Journal journal = new Journal();
      bool flag = true;
      while (flag)
      {
        menu.MenuOutput();

        switch (menu.UserChoice)
        {
          case 1:
            journal.CreateEntry();
            break;
          case 2:
            journal.NewJournal();
            break;
          case 3:
            journal.Display();
            break;
          case 4:
            journal.Load();
            break;
          case 5:
            journal.Save();
            break;
          case 6:
            Console.WriteLine("Thank you for using the journal program!");
            flag = false;
            Console.WriteLine("Closing now");
            break;
          default:
            Console.WriteLine("Thank you for using the journal program!");
            flag = false;
            Console.WriteLine("Closing now");
            break;
        }
      }

    }
  }
}

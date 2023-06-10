namespace Mindfulness
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu menu = new();

      const string QUIT_MESSAGE = "Thank you for being mindful exiting now";
      int choice = 0;
      while(choice != 4){
        choice = menu.RunMenu();
        switch (choice)
        {
          case 1:
            BreathingActivity ba = new();
            ba.RunBreathe();
            break;
          case 2:
            ReflectingActivity ra = new();
            ra.RunReflecting();
            break;
          case 3:
            ListingActivity la = new();
            la.RunListing();
            break;
          case 4:
            Console.WriteLine(QUIT_MESSAGE);
            Thread.Sleep(5000);
            Console.Clear();
            break;
          default:
            Console.WriteLine("Invalid Choice");
            menu.RunMenu();
            break;
        }
      }
    }
  }
}

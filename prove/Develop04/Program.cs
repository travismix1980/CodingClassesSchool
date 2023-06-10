namespace Mindfulness
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu menu = new();
      
      const string QUIT_MESSAGE = "Thank you for being mindful exiting now";

      SelectActivity(menu.RunMenu());

      #region Chose Activity

      void SelectActivity(int choice)
      {
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
            break;
          default:
            Console.WriteLine("Invalid Choice");
            menu.RunMenu();
            break;
        }
      }
      #endregion
    }
  }
}

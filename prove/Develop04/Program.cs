namespace Mindfulness
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu menu = new();
      Activity a = new();
      a.ShowSpinner(500, 10000);
      a.ShowCountdown(10);
      const string REFLECT_START_MESSAGE = "Welcome to the Reflecting Activity";
      const string REFLECT_END_MESSAGE = "";
      const string LISTING_START_MESSAGE = "Welcome to the Listing Activity";
      const string LISTING_END_MESSAGE = "";
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
            ReflectingActivity ra = new(REFLECT_START_MESSAGE, REFLECT_END_MESSAGE);
            ra.RunReflecting();
            break;
          case 3:
            ListingActivity la = new(LISTING_START_MESSAGE, LISTING_END_MESSAGE);
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

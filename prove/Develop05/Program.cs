// *********************************************************************************************************************
// for extra creativity I added the following extra menu options Show Total Points and Show Current Level check them
// out. Added a complete leveling system though their are some bugs if the data in the levelfile.txt are bad.  If you
// get an error running the program delete the levelfile.txt and try again as that should fix the issue.
//
// When you level up the level up system alternates between two different animations that are pretty cool.  I did not
// create the animations myself and borrowed them from a console animation tutorial which can be found at
// https://www.michalbialecki.com/en/2018/05/25/how-to-make-you-console-app-look-cool/ and then modified them for
// time.  I do know how the animations work however just found them and decided to use them instead of creating them
// from scratch as that would take a very long time and I was running out.
//
// The leveling system saves the current level status including current level and everything needed to keep track of
// how many points are still needed to get to the next level and needed to calculate the required points for the next
// level.  I put the majority of the code to run the program in the controller class and wished I had the time to break
// it up better.
//
// I added IGoal just to have an interface.  I know it isnt really needed but it was a left over while going over
// interfaces with the team, and figured it showed that I knew how to use them.  I originally and believe in some
// places use the interface type for handling collections of goals by using the IGoal type instead of the Goal type but
// there were a couple spots where it didn't work as I needed access to stuff outside of IGoal to process the goals.
// In the end I ran out of time to finish everything I wanted to do on this project.  Hope you like it the way it ended
// up all the same.
// *********************************************************************************************************************

class Program
{
  static void Main(string[] args)
  {
    Controller c = new();
    bool flag = true;
    while (flag)
    {
      flag = c.RunMainMenu();
    }
  }
}

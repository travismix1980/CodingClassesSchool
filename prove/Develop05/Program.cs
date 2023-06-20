using System;

class Program
{
    static void Main(string[] args)
    {
        Menu m = new();
        int menuChoice = m.ShowMenu();
        Score s = new();
        GotoMenuChoice(menuChoice);
    }

    static void GotoMenuChoice(int choice){
        switch(choice){
            case 1:
                Console.WriteLine("You chose Create New Goal");
                break;
            case 2:
                Console.WriteLine("You chose List Goals");
                break;
            case 3:
                Console.WriteLine("You chose Save Goals");
                break;
            case 4:
                Console.WriteLine("you chose Load Goals");
                break;
            case 5:
                Console.WriteLine("you chose Record Event");
                break;
            case 6:
                Console.WriteLine("You chose quit");
                break;
            default:
                Console.WriteLine("You chose a non existant option");
                break;
        }
    }
}

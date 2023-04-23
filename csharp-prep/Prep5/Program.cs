using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        DisplayResult(PromptUserName(), PromptUserNumber());
    }

    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName(){
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber(){
        Console.Write("Please enter your favorite number: ");
        return Int32.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number){
        return (int)Math.Pow(number, 2);
    }

    static void DisplayResult(string name, int number){
        int squared = SquareNumber(number);
        Console.WriteLine($"{name}, the square of your favorite number is {squared}.");
    }
}

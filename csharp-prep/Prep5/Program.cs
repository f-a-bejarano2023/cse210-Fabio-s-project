using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        
        string userName = PromptUserName();
        
        int favoriteNumber = PromptUserNumber();
        
        int squaredNumber = SquareNumber(favoriteNumber);
        
        DisplayResult(userName, squaredNumber);
    }

    // Display a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Hello, welcome to this virtual gathering!");
    }

    // Prompt the user for their name...
    static string PromptUserName()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Prompt the user for their favorite number ...
    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }

    // Square the given number...
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Display the user's name and the squared number
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"Hello, {name}! Your favorite number squared is: {squaredNumber}");
    }
}
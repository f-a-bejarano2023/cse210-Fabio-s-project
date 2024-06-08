using System;

class Program
{
    static void Main(string[] args)
    {
        //Get the score percentage from the user
        Console.Write("PLease, enter your grade percentage ");
        int gradePercent = int.Parse(Console.ReadLine());
        
        //Determine the grade letter depending on the score percentage
        string letter;
        if (gradePercent >= 90)
        {
            letter = "A";
        }
        else if (gradePercent >= 80)
        {
            letter = "B";
        }
        else if (gradePercent >= 70)
        {
            letter = "C";
        }
        else if (gradePercent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        //Show the letter grade
        Console.WriteLine($"Your letter grade is: {letter}");

        //Display the appropriate message informing the user of a passed or failed course
        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass the course. Try again next semester... you'll do better next time!");
        }
    }
}

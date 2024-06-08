using System;

class Program
{
    static void Main(string[] args)
    {
        //Get the score percentage from the user
        Console.Write("PLease, enter your grade percentage ");
        int gradePercent = int.Parse(Console.ReadLine());
        
        //Determine the grade letter depending on the score percentage
        if (gradePercent  >  90)
        {
            Console.WriteLine("You received an A grade");
        }
        else if (gradePercent  >=  80)
        {
            Console.WriteLine("You received a B grade");
        }
        else if (gradePercent  >=  70)
        {
            Console.WriteLine("You received a C grade");
        }
        else if (gradePercent  >=  60)
        {
            Console.WriteLine("You received a D grade");
        }
        else if (gradePercent  <  60)
        {
            Console.WriteLine("You received an F grade");
        }

        if (gradePercent >= 70)
        {
            System.Console.WriteLine("You passed this course. Congratulations!");
        }
        else
        {
            System.Console.WriteLine("You barely made it. you can try again next block!");
        }
    }
}
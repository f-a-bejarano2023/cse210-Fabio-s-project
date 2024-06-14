using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userOption;
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        do
        {
            Console.Write("Please, enter a number: ");
            userOption = Convert.ToInt32(Console.ReadLine());
            
            if (userOption == 0)
                break;
            else
                numbers.Add(userOption);
        
        } while (true);

        Console.WriteLine("Numbers entered: ");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Calculate the sum of the numbers
        int total = 0;
        foreach (int num in numbers)
        {
            total += num;
        }
        Console.WriteLine($"The sum is: {total}");

        // Calculate the average of the numbers
        double average = (double)total / numbers.Count;
        Console.WriteLine($"The average is: {average:F2}");

        // Find the largest number in the list
        int largest = numbers.Count > 0 ? numbers.Max() : 0;
        Console.WriteLine($"The largest number is: {largest}");
    }
}
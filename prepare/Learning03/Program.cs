using System;

class Program
{
    static void Main(string[] args)
    {
        // Test default constructor
        Fraction frac1 = new Fraction();
        Console.WriteLine("Default Constructor:");
        Console.WriteLine($"Fraction: {frac1.GetFractionString()}");
        Console.WriteLine($"Decimal: {frac1.GetDecimalValue()}");

        // Test constructor with numerator only
        Fraction frac2 = new Fraction(5);
        Console.WriteLine("\nConstructor with numerator only:");
        Console.WriteLine($"Fraction: {frac2.GetFractionString()}");
        Console.WriteLine($"Decimal: {frac2.GetDecimalValue()}");

        // Test constructor with numerator and denominator
        Fraction frac3 = new Fraction(3, 4);
        Console.WriteLine("\nConstructor with numerator and denominator:");
        Console.WriteLine($"Fraction: {frac3.GetFractionString()}");
        Console.WriteLine($"Decimal: {frac3.GetDecimalValue()}");

        // Test getters and setters
        frac3.SetNumerator(1);
        frac3.SetDenominator(3);
        Console.WriteLine("\nAfter using setters:");
        Console.WriteLine($"Fraction: {frac3.GetFractionString()}");
        Console.WriteLine($"Decimal: {frac3.GetDecimalValue()}");
    }
}
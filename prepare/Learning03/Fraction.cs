using System;

// Fraction.cs
public class Fraction
{
    // Private attributes
    private int numerator;
    private int denominator;

    // Default constructor
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    // Constructor with numerator only
    public Fraction(int numerator)
    {
        this.numerator = numerator;
        denominator = 1;
    }

    // Constructor with numerator and denominator
    public Fraction(int numerator, int denominator)
    {
        this.numerator = numerator;
        if (denominator != 0) // Prevent division by zero
        {
            this.denominator = denominator;
        }
        else
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
    }

    // Getter for numerator
    public int GetNumerator()
    {
        return numerator;
    }

    // Setter for numerator
    public void SetNumerator(int numerator)
    {
        this.numerator = numerator;
    }

    // Getter for denominator
    public int GetDenominator()
    {
        return denominator;
    }

    // Setter for denominator
    public void SetDenominator(int denominator)
    {
        if (denominator != 0)
        {
            this.denominator = denominator;
        }
        else
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
    }

    // Displaying fraction as string
    public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }

    // Displaying the fraction as decimal value
    public double GetDecimalValue()
    {
        return (double)numerator / denominator;
    }
}

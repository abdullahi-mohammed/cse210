using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }
    public string GetNumerator()
    {
        return $"{_numerator}";
    }
    public void SetDenominator(int denominator)
    {
        _denominator = denominator;
    }
    public string GetDenominator()
    {
        return $"{_denominator}";
    }
    public string DisplayFraction()
    {
        return $"{_numerator}/{_denominator}";
    }
}
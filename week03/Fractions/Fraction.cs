using System;

public class Fraction
{
    // Step 3: Attributes for the top and bottom numbers set to private
    private int _top;
    private int _bottom;

    // Step 4: Constructors
    
    // Constructor with no parameters that initializes the number to 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor that has one parameter for the top and initializes the denominator to 1
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor that has two parameters, one for the top and one for the bottom
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Step 5: Getters and Setters
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Step 6: Methods to return the representations
    
    // Returns the fraction in the form 3/4
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Returns a double that is the result of dividing the top number by the bottom number
    public double GetDecimalValue()
    {
        // Cast to double to ensure floating-point division rather than integer division
        return (double)_top / (double)_bottom;
    }
}
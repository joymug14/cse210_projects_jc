using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    // Constuctor with no paramenrtes that initializes the 
    // fraction to 1/1


    public Fraction()
    {
        _top = 1;
        _bottom =1;

    }

    // Constructor that has one parameter 
    // for the topand that intializes the denominator to 1
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor that has two parameters,
    // one at the top and one at the bottom.

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Create Getters and Setters
    public int GetTop()
    {
        return _top;
    }
    public void Settop(int top)
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
    public string GetFractionString()
    {   
        string text = $"{_top}/{_bottom}";
        return text;
    }
    
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }


}
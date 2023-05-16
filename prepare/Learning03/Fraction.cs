using System;
// Create a class to hold fraction. The class should be in its own file.
public class Fraction
{
    // The class should have two attributes for the top and bottom numbers. Make sure the attributes are private.
    private int _top;
    private int _bottom;

    //Constructors: Create the following constructors:
 
    // Constructor that has no parameters that initializes the number to 1/1.
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    
    // Constructor that has one parameter for the top and that initializes the denominator to 1. So that if you pass in the number 5, the fraction would be initialized to 5/1.
    public Fraction(int number)
    {
        _top = number;
        _bottom = 1;
    }

    // Constructor that has two parameters, one for the top and one for the bottom.
    public Fraction (int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //Getters and Setters: Create getters and setters for both the top and the bottom values.
    public int GetTopNumber()
    {
        return _top;
    }
    public int GetBottomNumber()
    {
        return _bottom;
    }

    private void SetTopNumber(int top)
    {
        _top = top;
    }

    private void SetBottomNumber(int bottom)
    {
        _bottom = bottom;
    }

//Create Methods
//Create a method called GetFractionString that returns the fraction in the form 3/4.
public string GetFractionString()
{
    string fraction = ($"{_top}/{_bottom}");
    return fraction;
}
//Create a method called GetDecimalValue that returns a double that is the result of dividing the top number by the bottom number, such as 0.75.
public double GetDecimalValue()
{
    return (double)_top / (double)_bottom;
}
}
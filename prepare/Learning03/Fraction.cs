using System;

public class Fraction
{
    //Fraction class has two private attributes for the top and bottom numbers
    private int _top;
    private int _bottom;

    //Create constructor that has no parameters and initializes the top and bottom numbers to 1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    //Create constructor that has one parameter for the top and initializes the bottom number to 1
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    //Create constructor that has two parameters, one for the top and one for the bottom
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //Create getters and setters for both the top and bottom values

    //Create a method called GetFracitonString that returns the fraction in the form x/y
    public string GetFractionString()
    {
        //local variable that will be recomputed each time this method is called
        string returnFraction = $"{_top}/{_bottom}";
        return returnFraction;
    }

    //Create a method call GetDecimalValue that returns a double that is the result of dividing the top number by the bottom number, 0.75
    public double GetDecimalValue()
    {
        return _top / (double)_bottom;
    }


    // public void ReturnFraction()
    // {
    //     Console.WriteLine($"{_top}/{_bottom}");
    // }
}
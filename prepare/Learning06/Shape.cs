using System;
using System.Diagnostics.Contracts;

public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();
}

//It does not make sense to define a default body for this method in the
//base class, rather than make a "virtual" function here like this:

//public virtual double GetArea()
//{
//  return 0;
//}

//We can instead declare the function as an "abstract" function. That means that it
//is an empty virual function that must be implemented or "filled in" by any class
//that inherits from "Shape". Then, any class that has an abstract method must be
//also declared as abstract.
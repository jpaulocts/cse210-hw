using System;

public abstract class Shape
{
    private string _color;

    private double _area;
    
    private string _name;

    public string GetColor()
    {
        return _color;
    }

    public Shape(string color)
    {
        SetColor(color);
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();
    
    
    public void SetName(string name)
    {
        _name = name;

       
    }

    public string GetName()
    {
        return _name;
    }



}

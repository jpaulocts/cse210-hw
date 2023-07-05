using System;

public class Square : Shape 
{

    private double _side;

    
    public Square(string color, double side) : base(color)
    {
        _side = side;
        SetName("square");
    }

    public override double GetArea()
    {
        return Math.Round(_side * _side, 2);
    }
    
}

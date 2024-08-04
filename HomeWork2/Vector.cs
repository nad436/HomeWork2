﻿public struct Vector
{
    public double X { get; set; }
    public double Y { get; set; }
    public Vector(double x, double y)
    {
        X = x;
        Y = y;

    }
    public double Lenght()
    {
        return Math.Sqrt(X * X + Y * Y);
    }

}

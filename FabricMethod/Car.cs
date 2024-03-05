﻿using System.Drawing;
using System.Reflection;

public class Car : Vehicle
{
    public Car(string brand, string model, int year, string color)
    {
        Type = "Car";
        Brand = brand;
        Model = model;
        Year = year;
        Color = color;
    }

    public override string Move()
    {
        return $"{Year} {Brand} {Model} is moving on the road";
    }

    public override string GetDetails()
    {
        return $"{Type}: {Year} {Brand} {Model}, Color: {Color}";
    }
}

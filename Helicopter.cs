using System;
namespace OOP_CSharp_Assignment1;

public class Helicopter : Vehicle, Flyable
{
    public int NumRotors{get; set;}

    public Helicopter(string make, string model, int year, int speed, int numRotors) : base(make, model, year, speed)
    {
        NumRotors = numRotors;
    }

    public override void Decelerate()
    {
        Speed = Speed - 15;
    }

    public void Fly()
    {
        Console.WriteLine("The helicopter flies with its rotors.");
    }
}
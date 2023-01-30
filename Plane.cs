using System;
namespace OOP_CSharp_Assignment1;
public class Plane : Vehicle, Flyable
{
    public int NumWings{get; set;}

    public Plane(string make, string model, int year, int speed, int numWings) : base(make, model, year, speed)
    {
        NumWings = numWings;
    }


    public override void Accelerate()
    {
        Speed = Speed + 20;
    }

    public void Fly()
    {
        Console.WriteLine("The plane flies using its wings.");
    }
}
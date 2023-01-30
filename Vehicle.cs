using System;

public abstract class Vehicle
{
    public string Make{get; set;}

    public string Model{get; set;}
    public int Year{get; set;}
    public int Speed{get; set;}

    public Vehicle(string make, string model, int year, int speed)
    {
        this.Make = make;
        this.Model = model;
        this.Year = year;
        this.Speed = speed;
    }
    public virtual void Accelerate()
    {
        Speed = Speed + 10;
    }

        public virtual void Decelerate()
    {
        Speed = Speed - 10;
    }

        public void DisplayInfo()
    {
            Console.WriteLine(string.Format("Make: {0} \nModel: {1} \nYear: {2} \nSpeed: {3}", Make, Model, Year, Speed));
    }
}

namespace OOP_CSharp_Assignment1;
public class Boat : Vehicle
{
    public int NumSails{get; set;}

    public Boat(string make, string model, int year, int speed, int numSails) : base(make, model, year, speed)
    {
        NumSails = numSails;
    }

    public override void Decelerate()
    {
        Speed = Speed - 7;
    }

    public void RaiseSail()
    {
        NumSails++;
    }

    public void LowerSail()
    {
        NumSails--;
    }
}
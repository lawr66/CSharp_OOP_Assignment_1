public class Car : Vehicle
{
    public int NumDoors{get; set;}

    public Car(string make, string model, int year, int speed, int numDoors) : base(make, model, year, speed)
    {
        NumDoors = numDoors;
    }

    public override void Accelerate()
    {
        Speed = Speed + 5;
    }

    public void OpenDoor()
    {
        NumDoors++;
    }

    public void CloseDoor()
    {
        NumDoors--;
    }
}
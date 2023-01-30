using System;
namespace OOP_CSharp_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Opel","Astra",2010,45, 4);
            car1.DisplayInfo();
            Console.WriteLine("Accelerating.");
            car1.Accelerate();      //speed increases by 5 as declared in the child class
            car1.DisplayInfo();
            Console.WriteLine("Decelarating.");
            car1.Decelerate();      //speed decreases by 10 as declared in the parent class
            car1.DisplayInfo();
            Console.WriteLine("Number of doors for the car: {0}", car1.NumDoors);
            car1.OpenDoor();                                                        //veryfing the OpenDoor() method from the Car class
            Console.WriteLine("Opened a door, number of doors for the car: {0}", car1.NumDoors);
            car1.CloseDoor();                                                       //veryfing the CloseDoor() method from the Car class
            Console.WriteLine("Closed a door, number of doors for the car: {0}", car1.NumDoors);
            Boat boat1 = new Boat("Gulf Craft","Majesty",2007,83, 2);
            boat1.DisplayInfo();
            Console.WriteLine("Accelerating.");   
            boat1.Accelerate();      //speed increases by 10 as declared in the parent class
            boat1.DisplayInfo();
            Console.WriteLine("Decelarating.");
            boat1.Decelerate();      //speed decreases by 7 as declared in the child class
            boat1.DisplayInfo();
            Console.WriteLine("Number of sails for the boat: {0}", boat1.NumSails);
            boat1.RaiseSail();                                                      //veryfing the RaiseSail() method from the Boat class
            Console.WriteLine("Raised a sail, number of sails for the boat: {0}", boat1.NumSails);
            boat1.LowerSail();                                                       //veryfing the RaiseSail() method from the Boat class
            Console.WriteLine("Lowered a sail, number of sails for the boat: {0}", boat1.NumSails);
            Plane plane1 = new Plane("Boeing","747",2020,556,2);
            plane1.DisplayInfo();
            Console.WriteLine("Accelerating.");
            plane1.Accelerate();      //speed increases by 20 as declared in the child class
            plane1.DisplayInfo();
            Console.WriteLine("Decelarating.");
            plane1.Decelerate();      //speed decreases by 10 as declared in the parent class
            plane1.DisplayInfo();
            plane1.Fly();              //veryifing the Fly() method from the Plane class
            Console.WriteLine("Number of wings for the plane: {0}", plane1.NumWings);
            Helicopter helicopter1 = new Helicopter("Apache","AH-64A",2022,186,4);
            helicopter1.DisplayInfo();
            Console.WriteLine("Accelerating.");
            helicopter1.Accelerate();      //speed increases by 10 as declared in the parent class
            helicopter1.DisplayInfo();
            Console.WriteLine("Decelarating.");
            helicopter1.Decelerate();      //speed decreases by 15 as declared in the child class
            helicopter1.DisplayInfo();
            helicopter1.Fly();              //veryifing the Fly() method from the Helicopter class
            Console.WriteLine("Number of rotors for the helicopter: {0}", helicopter1.NumRotors);
        }
    }
}

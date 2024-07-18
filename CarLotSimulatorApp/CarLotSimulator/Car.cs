using System;
using System.Runtime.InteropServices;

namespace CarLotSimulator;
//Create a seperate class file called Car
// //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
// //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
// //The methods should take one string parameter: the respective noise property

public class Car
{
    public int Year { get; set; }

    public string Make { get; set; }

    public string Model { get; set; }

    public string EngineNoise { get; set; }

    public string HonkNoise { get; set; }

    public bool IsDriveable { get; set; }

    public void MakeEngineNoise()
    {
        Console.WriteLine($"{MakeEngineNoise}");
    }

    public void MakeHonkNoise()
    {
        Console.WriteLine($"{MakeHonkNoise}");
    }
    
    //Extra credit method
    public void WriteToConsole()
    {
        Console.WriteLine($"We have a '{Year} {Make} {Model} available today!");
    }

    //Default contructor
    public Car()
    {

    }

    //Custom constructor
    public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
    {
        Year = year;
        Make = make;
        Model = model;
        EngineNoise = engineNoise;
        HonkNoise = honkNoise;
        IsDriveable = isDriveable;
    }
}

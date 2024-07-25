using System;
using System.Collections.Generic;

namespace CarLotSimulator;
//Create a CarLot class
//It should have at least one property: a List of cars
public class CarLot
{
    public List<Car> CarLotList { get; set; } = new List<Car>();

    public static int _numberOfCars;

    public void ListCarAvailability()
    {
        foreach (var carOption in CarLotList)
        {
            carOption.WriteToConsole();
        }
    }
}
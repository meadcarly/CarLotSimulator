using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            var carLot1 = new CarLot(); 
            
            var muscleCar = new Car();

            muscleCar.Year = 69;
            muscleCar.Make = "Corvette";
            muscleCar.Model = "Stingray";
            muscleCar.IsDriveable = true;

            muscleCar.MakeEngineNoise("Vroom Vroom");
            muscleCar.MakeHonkNoise("Beep Beep");
            
            carLot1.CarLotList.Add(muscleCar);

            var offRoadVehicle = new Car()
            {
                Year = 21,
                Make = "Jeep",
                Model = "Gladiator Mojave",
                IsDriveable = true,
            };
            
            offRoadVehicle.MakeEngineNoise("BBRRUUUMM");
            offRoadVehicle.MakeHonkNoise("honk honk");
            
            carLot1.CarLotList.Add(offRoadVehicle);

            var bike = new Car(24, "Ducati", "Diavel", true);
            
            bike.MakeEngineNoise("VVRRMMMMMM");
            bike.MakeHonkNoise("mmmmmmeeeeeee");
            
            carLot1.CarLotList.Add(bike);
            
            carLot1.ListCarAvailability();

        }
    } 
}

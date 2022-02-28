using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            var lot = new CarLot();
            
            //Vehicle 1
            var cheyennesCar = new Car();
            cheyennesCar.Make = "Nissan";
            cheyennesCar.Model = "Sentra";
            cheyennesCar.Year = 2018;
            cheyennesCar.EngineNoise = "vroom";
            cheyennesCar.HonkNoise = "beep";
            cheyennesCar.IsDriveable = true;

            lot.Cars.Add(cheyennesCar);

            //Vehicle 2
            var truck = new Car()
            {
                Year = 2011,
                Make = "Ford",
                Model = "Ranger",
                EngineNoise = "vroom",
                HonkNoise = "beep",
                IsDriveable = true,
            };

            lot.Cars.Add(truck);

            //Vehicle 3
            var suv = new Car(1999,"Jeep","Wrangler","vroom","beep",true);

            lot.Cars.Add(suv);

            // Call Methods
            cheyennesCar.MakeEngineNoise();
            truck.MakeEngineNoise();
            suv.MakeEngineNoise();

            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

           foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model:{car.Model}");
            }

        }
    }
}

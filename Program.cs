using Station.Interfaces;
using Station.Vehicles;
using System;

namespace Station
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a classic fuel Station
            IClassicStation classicFuelStation = new ClassicFuelStation();

            // Create classic vehicles
            IClassicVehicle dieselCar = new DieselVehicle("Audi A4");
            IClassicVehicle benzinaCar = new BenzinaVehicle("Ford Fiesta");
            IClassicVehicle gplCar = new GPLVehicle("Dacia Logan");

            // fill classic vehicles with fuel at classic fuel station
            classicFuelStation.Fill(dieselCar, 30);
            classicFuelStation.Fill(benzinaCar, 40);
            classicFuelStation.Fill(gplCar, 20);

            // Create a hibrid Station
            IHybridStation hybridStation = new HybridFuelStation();

            // Create a electrical and hybrid cars
            IElectricalVehicle electricalVehicle = new ElectricVehicle("Tesla Model S");
            IHybridVehicle hybridVehicle = new HybridVehicle("Toyota Prius");

            hybridStation.ConnectToCharger(hybridVehicle, 35);
            hybridStation.ConnectToCharger(electricalVehicle, 35);
            hybridStation.Fill(hybridVehicle, 22);
            hybridStation.Fill(dieselCar, 22);
            hybridStation.Fill(gplCar, 34);

            // Create a truck
            IClassicVehicle truck = new DieselVehicle("Volvo VF");
            ITanker tanker = new Tanker();

            tanker.LoadFuel("diesel", 500);
            tanker.Refuel(dieselCar, 100);
            tanker.Refuel(dieselCar, 100);
            tanker.Refuel(benzinaCar, 100);

        }
    }
}

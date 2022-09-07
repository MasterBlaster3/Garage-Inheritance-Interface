using System;
using System.Collections.Generic;

namespace Garage
{
    public class GasStation : FuelingStation<IGas>
    {
        public int Capacity { get; set; }
        public void Refuel(List<IGas> vehicles)
        {
            if (vehicles.Count <= Capacity)
            {
                foreach (IGas vehicle in vehicles)
                {
                    Console.WriteLine($"The {vehicle} has been refueled to a full {vehicle.FuelCapacity} gallons of gas.");

                }
            }
            else
            {
                Console.WriteLine($"Sorry you are trying to charge too many vehicles at once this station can only handle {Capacity} vehicles at a time.");
            }

        }
    }

}
using System;
using System.Collections.Generic;

namespace Garage
{
    public class BatteryStation : FuelingStation<IElectric>
    {
        public int Capacity { get; set; }
        public void Refuel(List<IElectric> vehicles)
        {

            if (vehicles.Count <= Capacity)
            {
                foreach (IElectric vehicle in vehicles)
                {
                    Console.WriteLine($"The {vehicle} has been refueled to a full charge 0f {vehicle.BatteryKWh} KWhs.");

                }
            }
            else
            {
                Console.WriteLine($"Sorry you are trying to charge too many vehicles at once. This station can only handle {Capacity} vehicles at a time.");
            }
        }
    }

}
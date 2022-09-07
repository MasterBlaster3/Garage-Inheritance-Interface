using System;
using System.Collections.Generic;

namespace Garage
{
    public interface FuelingStation<T>
    {
        //Total vehicles that can refuel at once
        int Capacity { get; set; }
        void Refuel(List<T> vehicles)
        {

            foreach (T vehicle in vehicles)
            {
                Console.WriteLine($"The {vehicle} has been refueled");

            }
        }

    }
}
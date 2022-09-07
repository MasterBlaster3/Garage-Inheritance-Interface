using System;

namespace Garage
{
    public class Ram : Vehicle, IGas // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; }

        public Ram()
        {
            FuelCapacity = 26.0;
            CurrentTankPercentage = 100;
        }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram rumbles past. Clankity Clank!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"After side swiping three cars eventually turning {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine($"The ram skids to an alarming stop.");
        }
    }
}
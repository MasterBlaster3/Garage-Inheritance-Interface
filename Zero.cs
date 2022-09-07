using System;

namespace Garage
{
    public class Zero : Vehicle, IElectric // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; }

        public Zero()
        {
            BatteryKWh = 42.5;
            CurrentChargePercentage = 25;
        }
        public void ChargeBattery()
        {
            CurrentChargePercentage();
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips past. Blam!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"After scraping a knee, the {MainColor} Zero buzzes to the {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Zero slams to an alarming stop.");
        }
    }
}
using System;

namespace Garage
{
    public interface IElectric
    {
        double BatteryKWh { get; set; }
        int CurrentChargePercentage { get; set; }
        void ChargeBattery();
    }

    public interface IGas
    {
        double FuelCapacity { get; set; }
        int CurrentTankPercentage { get; set; }
        void RefuelTank();

    }
}
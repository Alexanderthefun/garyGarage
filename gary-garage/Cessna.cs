using System;

namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle
    {

        public double FuelCapacity { get; set; }

        public int CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The Ram carries plywood for a home project..... glugglugglugchugglug. (It's {MainColor}).");
        }

    }
}
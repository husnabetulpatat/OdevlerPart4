using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsPart4
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double FuelConsumption { get; set; }
        public double TotalDistance { get; set; }

        public Car (string brand, string model, double fuelConsumption, double totalDistance)
        {
            Brand = brand;
            Model = model;
            FuelConsumption = fuelConsumption;
            TotalDistance = totalDistance;
        }

        public  double CalculateFuelConsumption()
        {
            return FuelConsumption * (TotalDistance/100);
        }
    }
}

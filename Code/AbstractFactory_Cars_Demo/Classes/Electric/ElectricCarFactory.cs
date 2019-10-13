using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory_Cars_Demo.Classes.Electric;

namespace AbstractFactory_Cars_Demo.Classes.Combustion
{
    public class ElectricCarFactory : ICarFactory
    {
        private double capacityInUnits;
        private double availableUnits;
        private string unitName;

        public ElectricCarFactory(double capacityInUnits, double availableUnits, string unitName)
        {
            this.capacityInUnits = capacityInUnits;
            this.availableUnits = availableUnits;
            this.unitName = unitName;
        }

        public Engine CreateEngine()
        {
            return new ElectricEngine();
        }

        public FuelStorage CreateFuelStorage()
        {
            return new ElectricBattery(capacityInUnits, availableUnits, unitName);
        }
    }
}

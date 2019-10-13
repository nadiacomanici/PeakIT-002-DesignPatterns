using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Cars_Demo.Classes.Combustion
{
    public class CombustionCarFactory : ICarFactory
    {
        private double capacityInUnits;
        private double availableUnits;
        private string unitName;

        public CombustionCarFactory(double capacityInUnits, double availableUnits, string unitName)
        {
            this.capacityInUnits = capacityInUnits;
            this.availableUnits = availableUnits;
            this.unitName = unitName;
        }

        public Engine CreateEngine()
        {
            return new CombustionEngine();
        }

        public FuelStorage CreateFuelStorage()
        {
            return new GasTank(capacityInUnits, availableUnits, unitName);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Cars_Demo.Classes.Electric
{
    class ElectricBattery : FuelStorage
    {
        public ElectricBattery(double capacityInUnits, double availableUnits, string unitName)
            : base(capacityInUnits, availableUnits, unitName)
        {
        }

        protected override double GetUnitsToFillInHalfASecond()
        {
            return 0.2;
        }
    }
}

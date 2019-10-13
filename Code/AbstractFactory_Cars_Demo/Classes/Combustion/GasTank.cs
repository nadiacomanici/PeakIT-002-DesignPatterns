using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Cars_Demo.Classes.Combustion
{
    public class GasTank : FuelStorage
    {
        public GasTank(double capacityInUnits, double availableUnits, string unitName)
            : base(capacityInUnits, availableUnits, unitName)
        {
        }

        protected override double GetUnitsToFillInHalfASecond()
        {
            return 1;
        }
    }
}

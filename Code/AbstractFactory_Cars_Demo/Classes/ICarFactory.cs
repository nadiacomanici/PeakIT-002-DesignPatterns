using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory_Cars_Demo.Classes.Combustion;

namespace AbstractFactory_Cars_Demo.Classes
{
    public interface ICarFactory
    {
        Engine CreateEngine();
        FuelStorage CreateFuelStorage();
    }
}

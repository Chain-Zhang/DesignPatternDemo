using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemo.FactoryMethod
{
    public class AudiFactory : ICarFactory
    {
        public ICar CreateCar()
        {
            return new Audi();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemo.FactoryMethod
{
    public class BmwFactory : ICarFactory
    {
        public ICar CreateCar()
        {
            return new Bmw();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemo.FactoryMethod
{
    public interface ICarFactory
    {
        ICar CreateCar();
    }
}

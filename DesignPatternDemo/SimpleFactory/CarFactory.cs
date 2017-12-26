using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemo.SimpleFactory
{
    public class CarFactory
    {
        public ICar CreateCar(string type)
        {
            switch (type)
            {
                case "audi":
                    return new Audi();
                case "bmw":
                    return new Bmw();
                default:
                    return null;
            }
        }
    }
}

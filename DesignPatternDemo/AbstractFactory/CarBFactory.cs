using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemo.AbstractFactory
{
    public class CarBFactory : ICarFactory
    {
        public IEngine CreateEngine()
        {
            return new EngineB();
        }

        public ISeat CreateSeat()
        {
            return new SeatB();
        }
    }
}

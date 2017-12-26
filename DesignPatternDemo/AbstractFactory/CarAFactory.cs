using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemo.AbstractFactory
{
public class CarAFactory : ICarFactory
{
    public IEngine CreateEngine()
    {
        return new EngineA();
    }

    public ISeat CreateSeat()
    {
        return new SeatA();
    }
}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemo.AbstractFactory
{
    public interface ICarFactory
    {
        IEngine CreateEngine();
        ISeat CreateSeat();
    }
}

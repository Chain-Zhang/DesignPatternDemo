using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemo.FactoryMethod
{
    public class Bmw : ICar
    {
        public void Run()
        {
            Console.WriteLine("bmw is runing");
        }
    }
}

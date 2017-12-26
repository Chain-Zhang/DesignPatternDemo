using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemo.SimpleFactory
{
    public class Audi : ICar
    {
        public void Run()
        {
            Console.WriteLine("audi is runing");
        }
    }
}

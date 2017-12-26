using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemo.SimpleFactory
{
    public class Bmw : ICar
    {
        public void Run()
        {
            Console.WriteLine("bmw is runing");
        }
    }
}

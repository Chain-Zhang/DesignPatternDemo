using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemo.AbstractFactory
{
    public class EngineB : IEngine
    {
        public void Run()
        {
            Console.WriteLine("this is engine b");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemo.AbstractFactory
{
    public class EngineA : IEngine
    {
        public void Run()
        {
            Console.WriteLine("this is engine A");
        }
    }
}

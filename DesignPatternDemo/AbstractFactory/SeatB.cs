using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemo.AbstractFactory
{
    public class SeatB : ISeat
    {
        public void Message()
        {
            Console.WriteLine("this is seat b");
        }
    }
}

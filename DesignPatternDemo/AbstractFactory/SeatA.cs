using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemo.AbstractFactory
{
    public class SeatA : ISeat
    {
        public void Message()
        {
            Console.WriteLine("this is seat a");
        }
    }
}

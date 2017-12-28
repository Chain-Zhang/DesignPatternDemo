using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemo.Singleton
{
    public class EagerSingleton
    {
        private EagerSingleton() { }
        private static EagerSingleton instance = new EagerSingleton();

        public static EagerSingleton GetInstance()
        {
            return instance;
        }

        public void Print()
        {
            Console.WriteLine("this is eager singleton");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemo.Singleton
{
public class LazySingleton
{
    private LazySingleton() { }
    private static LazySingleton _instance;
    private static readonly object locker = new object();
    public static LazySingleton Instance
    {
        get
        {
            if (_instance == null)
            {


                lock (locker)
                {
                    if (_instance == null)
                    {
                        _instance = new LazySingleton();
                    }
                }
            }
            return _instance;
        }
    }

    public void Print()
    {
        Console.WriteLine("this is lazy singleton");
    }
}
}

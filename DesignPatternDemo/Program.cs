using System;
using DesignPatternDemo.SimpleFactory;
using DesignPatternDemo.AbstractFactory;
using System.Collections.Generic;
using DesignPatternDemo.Singleton;

namespace DesignPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("=================设计模式测试=================");
                Console.WriteLine("====1 - 简单工厂模式==========================");
                Console.WriteLine("====2 - 工厂方法模式==========================");
                Console.WriteLine("====3 - 抽象工厂模式==========================");
                Console.WriteLine("====4 - 单例模式==============================");
                Console.WriteLine("====0 - 退出==================================");
                Console.WriteLine("==============================================");
                Console.Write("请输入编号：");
                string num = Console.ReadLine();
                switch (num)
                {
                    case "1":
                        SimpleFactory();
                        break;
                    case "2":
                        FactoryMethod();
                        break;
                    case "3":
                        AbstractFactory();
                        break;
                    case "4":
                        Singleton();
                        break;
                    case "0":
                        flag = false;
                        break;
                    default:
                        break;
                }

                Console.WriteLine("\r\n");
            }
        }

        /// <summary>
        /// 简单工厂模式测试
        /// </summary>
        static void SimpleFactory()
        {
            CarFactory carFactory = new CarFactory();
            ICar audi = carFactory.CreateCar("audi");
            audi.Run();
            ICar bmw = carFactory.CreateCar("bmw");
            bmw.Run();
        }

        /// <summary>
        /// 工厂方法模式测试
        /// </summary>
        static void FactoryMethod()
        {
            FactoryMethod.ICar audi = new FactoryMethod.AudiFactory().CreateCar();
            audi.Run();

            FactoryMethod.ICar bmw = new FactoryMethod.BmwFactory().CreateCar();
            bmw.Run();
        }

        /// <summary>
        /// 抽象工厂模式测试
        /// </summary>
        static void AbstractFactory()
        {
            ICarFactory cara = new CarAFactory();
            IEngine e1 = cara.CreateEngine();
            ISeat s1 = cara.CreateSeat();
            e1.Run();
            s1.Message();

            ICarFactory carab = new CarBFactory();
            IEngine e2 = carab.CreateEngine();
            ISeat s2 = carab.CreateSeat();
            e2.Run();
            s2.Message();
        }

        /// <summary>
        /// 单例模式测试
        /// </summary>
        static void Singleton()
        {
            EagerSingleton.GetInstance().Print();
            LazySingleton.Instance.Print();
        }
    }


}

using System;

namespace Clone_23._03._2023
{
    class Program
    {
        class Engine
        {
            public double Power { set; get; }
            public string Model { set; get; }

            public Engine(double P, string M)
            {
                Power = P;
                Model = M;

            }

            public void PrintE()
            {
                Console.WriteLine($"Power_E{Power}\nModel_E{Model}\n");
            }
        }
        abstract class Transport
        {
            public string Name_Transport { set; get; }
            public int Year { set; get; }
            public string Model { set; get; }

            public Transport(string N, int Y, string M)
            {
                Name_Transport = N;
                Year = Y;
                Model = M;
            }

            public abstract Transport Clone();
           
        }
        class Car : Transport
        {
            public Engine Engine { set; get; }

            public Car(Engine engine,string N, int Y, string M) : base(N, Y, M)
            {

            }
            public override Transport Clone()
            {
                return new Car(Engine,Name_Transport,Year,Model);
            }

            public void Print()
            {
                Console.WriteLine($"Name_Transport{Name_Transport}\nYear{Year}\nModel{Model}\n,Engine{Engine}");
            }
        }
        class Ship : Transport
        {
            public Engine Engine;

            public Ship(Engine engine,string N, int Y, string M) : base(N, Y, M)
            {
            }

            public void Print()
            {
                Console.WriteLine($"Name_Transport{Name_Transport}\nYear{Year}\nModel{Model}\n,Engine{Engine}");
            }

            public override Transport Clone()
            {
                return new Ship(Engine, Name_Transport, Year, Model);
            }
        }
        class Air : Transport
        {
            public Engine Engine;

            public Air(Engine engine,string N, int Y, string M) : base(N, Y, M)
            {

            }

            public void Print()
            {
                Console.WriteLine($"Name_Transport{Name_Transport}\nYear{Year}\nModel{Model}\n,Engine{Engine}");
            }

            public override Transport Clone()
            {
                return new Air(Engine, Name_Transport, Year, Model);
            }
        }
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;

            Engine engine = new Engine(4.4,"Biturbo");

            Car car = new Car(engine, "BMW",2019,"M5");
            car.Print();
            car.Clone();
            engine.PrintE();
            Console.WriteLine("\n");
            Ship ship = new Ship(engine,"Mers",2018,"C400");
            ship.Print();
            ship.Clone();
            engine.PrintE();
            Console.WriteLine("\n");
            Air air = new Air(engine,"Audi",2020,"A7");
            air.Print();
            air.Clone();
            engine.PrintE();
            Console.WriteLine("\n");

            
        }
    }
}

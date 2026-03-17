using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3_Assignment
{
    //ЗАВДАННЯ 1
    public class Point
    {
        protected int x, y, c;

        public Point() { x = 0; y = 0; c = 0; }
        public Point(int x, int y, int c)
        {
            this.x = x; this.y = y; this.c = c;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Color => c;

        public virtual void Display() =>
            Console.WriteLine($"Точка: ({x}, {y}), Колір ID: {c}, Відстань: {GetDistance():F2}");

        public double GetDistance() => Math.Sqrt(x * x + y * y);

        public void Move(int x1, int y1) { x += x1; y += y1; }
    }

    // ЗАВДАННЯ 2
    public class TransportVehicle
    {
        public string Brand { get; set; }
        public int MaxSpeed { get; set; }

        public TransportVehicle(string brand, int maxSpeed)
        {
            Brand = brand; MaxSpeed = maxSpeed;
        }

        public virtual void Show() =>
            Console.Write($"[{this.GetType().Name}] Бренд: {Brand}, Швидкість: {MaxSpeed} км/год");
    }

    public class Car : TransportVehicle
    {
        public string FuelType { get; set; }
        public Car(string brand, int maxSpeed, string fuelType) : base(brand, maxSpeed) => FuelType = fuelType;
        public override void Show() { base.Show(); Console.WriteLine($", Паливо: {FuelType}"); }
    }

    public class Train : TransportVehicle
    {
        public int Wagons { get; set; }
        public Train(string brand, int maxSpeed, int wagons) : base(brand, maxSpeed) => Wagons = wagons;
        public override void Show()
        {
            base.Show();
            Console.WriteLine($", Вагонів: {Wagons}");
        }

        public class Express : Train
        {
            public string Route { get; set; }
            public Express(string brand, int maxSpeed, int wagons, string route) : base(brand, maxSpeed, wagons) => Route = route;
            public override void Show()
            {
                base.Show();
                Console.WriteLine($", Маршрут: {Route}");
            }
        }
    }
}
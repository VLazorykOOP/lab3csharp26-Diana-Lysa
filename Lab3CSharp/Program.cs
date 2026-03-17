using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab3_Assignment;
using static Lab3_Assignment.Train;

namespace Lab3CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("\n--- Лабораторна робота №3 ---");
                Console.WriteLine("1. Завдання 1 (Точки)");
                Console.WriteLine("2. Завдання 2 (Транспорт)");
                Console.WriteLine("0. Вихід");
                Console.Write("Ваш вибір: ");

                string choice = Console.ReadLine();
                if (choice == "1") RunTask1();
                else if (choice == "2") RunTask2();
                else if (choice == "0") break;
            }
        }

        static void RunTask1()
        {
            Console.WriteLine("\n--- Результати Завдання 1 ---");
            List<Point> points = new List<Point>
            {
                new Point(7, 4, 3),
                new Point(0, 5, 2),
                new Point(10, 10, 1),
                new Point()
            };

            double avg = points.Average(p => p.GetDistance());
            Console.WriteLine($"Середня відстань: {avg:F2}");

            foreach (var p in points)
            {
                if (p.GetDistance() > avg) p.Move(5, 5);
                p.Display();
                p.Move(3, 4);
            }
        }

        static void RunTask2()
        {
            Console.WriteLine("\n--- Результати Завдання 2 ---");
            TransportVehicle[] fleet = {
                new Car("Audi", 220, "Бензин"),
                new Express("Intercity", 160, 9, "Київ-Львів"),
                new Train("Вантажний", 80, 30)
            };

            foreach (var v in fleet.OrderBy(x => x.GetType().Name))
            {
                v.Show();
            }
        }
    }
}
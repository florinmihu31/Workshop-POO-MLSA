﻿using System;

namespace OOP {
    class Program {
        static void Main(string[] args) {
            Car car1 = new Mercedes("Florin", FuelType.DIESEL, Colour.WHITE);
            ((Mercedes)car1).IsDrivePilotOn = true;
            Console.WriteLine(car1.OwnerName);
            Console.WriteLine(car1.FuelType);
            Console.WriteLine(car1.Colour);
            Console.WriteLine(((Mercedes)car1).IsDrivePilotOn);
            Console.WriteLine(car1.EngineSize);
            car1.Drive();

            Car car2 = new BMW();
            car2.OwnerName = "Lucian";
            ((BMW)car2).IsSportModeOn = true;
            Console.WriteLine(car2.OwnerName);
            Console.WriteLine(car2.FuelType);
            Console.WriteLine(car2.Colour);
            Console.WriteLine(((BMW)car2).IsSportModeOn);
            Console.WriteLine(car2.EngineSize);
            car2.Drive();

            Console.WriteLine(Car.NumberOfCars);
        }
    }
}
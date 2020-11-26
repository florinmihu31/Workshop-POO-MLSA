using System;

namespace OOP {
    class Program {
        static void Main(string[] args) {
            Car car1 = new Mercedes("Florin", FuelType.DIESEL, Colour.WHITE);
            ((Mercedes)car1).IsCruiseControlOn = true;
            Console.WriteLine(car1.OwnerName);
            Console.WriteLine(car1.FuelType);
            Console.WriteLine(car1.Colour);
            Console.WriteLine(((Mercedes)car1).IsCruiseControlOn);
            car1.GetSpecialFeature();
            car1.Drive();

            Car car2 = new BMW();
            car2.OwnerName = "Lucian";
            ((BMW)car2).IsSportModeOn = true;
            Console.WriteLine(car2.OwnerName);
            Console.WriteLine(car2.FuelType);
            Console.WriteLine(car2.Colour);
            Console.WriteLine(((BMW) car2).IsSportModeOn);
            car2.GetSpecialFeature();
            car2.Drive();

            Console.WriteLine(Car.NumberOfCars);

            IShape circle = new Circle();
            circle.Draw();
            IShape square = new Square();
            square.Draw();

            Complex c1 = new Complex(4, 6);
            Complex c2 = new Complex(6, 3);
            Console.WriteLine(c1 + c2);
        }
    }
}

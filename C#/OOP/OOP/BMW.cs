using System;

namespace OOP {
    class BMW : Car {
        public BMW() : base() { }

        public BMW(string ownerName, FuelType fuelType, Colour colour)
            : base(ownerName, fuelType, colour) { }

        public bool IsSportModeOn { get; set; }

        public override void GetSpecialFeature()
        {
            Console.WriteLine("I have sport mode.");
        }

        public override void Drive() {
            Console.WriteLine("Driving BMW");
        }
    }
}

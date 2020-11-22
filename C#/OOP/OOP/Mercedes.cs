using System;

namespace OOP {
    class Mercedes : Car {
        public Mercedes() : base() { }

        public Mercedes(string ownerName, FuelType fuelType, Colour colour)
            : base(ownerName, fuelType, colour) { }

        public bool IsDrivePilotOn { get; set; }

        public override void GetSpecialFeature()
        {
            Console.WriteLine("I have drive pilot.");
        }

        public override void Drive() {
            Console.WriteLine("Driving Mercedes");
        }
    }
}

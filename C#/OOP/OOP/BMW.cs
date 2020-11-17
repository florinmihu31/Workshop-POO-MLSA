using System;

namespace OOP {
    class BMW : Car {
        public BMW() : base() { }

        public BMW(string ownerName, FuelType fuelType, Colour colour)
            : base(ownerName, fuelType, colour) { }

        public bool IsSportModeOn {
            get; set;
        }

        public override int EngineSize {
            get { return 2998; }
        }

        public override void Drive() {
            Console.WriteLine("Driving BMW");
        }
    }
}

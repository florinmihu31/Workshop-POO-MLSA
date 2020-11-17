using System;

namespace OOP {
    class Mercedes : Car {
        public Mercedes() : base() { }

        public Mercedes(string ownerName, FuelType fuelType, Colour colour)
            : base(ownerName, fuelType, colour) { }

        public bool IsDrivePilotOn {
            get; set;
        }

        public override int EngineSize {
            get { return 1982; }
        }

        public override void Drive() {
            Console.WriteLine("Driving Mercedes");
        }
    }
}

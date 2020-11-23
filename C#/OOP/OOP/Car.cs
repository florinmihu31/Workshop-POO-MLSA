using System;

namespace OOP {
    abstract class Car {
        public Car() : this("", FuelType.GAS, 0) { }

        public Car(string ownerName, FuelType fuelType, Colour colour)
        {
            _ownerName = ownerName;
            FuelType = fuelType;
            Colour = colour;
            NumberOfCars++;
        }

		private string _ownerName;
		public string OwnerName
        {
            get
            {
                return _ownerName;
            }

			set {
				if (value.Length > 1) {
					_ownerName = value;
				}
			}
		}

		public FuelType FuelType { get; }

		public Colour Colour { get; set; }

		public static int NumberOfCars { get; private set; }

        public virtual void GetSpecialFeature()
        {
            Console.WriteLine("I have no special feature.");
        }

        public abstract void Drive();
	}
}

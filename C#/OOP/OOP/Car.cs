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

        public static bool operator==(Car car1, Car car2)
        {
            return car1.OwnerName == car2.OwnerName &&
                   car1.FuelType == car2.FuelType &&
                   car1.Colour == car2.Colour && 
                   car1.GetType() == car2.GetType();
        }

        public static bool operator!=(Car car1, Car car2)
        {
            return !(car1 == car2);
        }

        public virtual void GetSpecialFeature()
        {
            Console.WriteLine("I have no special feature.");
        }

        public abstract void Drive();
	}
}

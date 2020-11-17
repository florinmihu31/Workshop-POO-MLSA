namespace OOP {
    abstract class Car {
		private string ownerName;
		public string OwnerName {
			get { return ownerName; }
			set {
				if (value.Length > 1) {
					ownerName = value;
				}
			}
		}

		public FuelType FuelType { get; }

		public Colour Colour { get; set; }

		public abstract int EngineSize { get; }

		public static int NumberOfCars { get; private set; }

		public Car() : this("", FuelType.GAS, 0) { }

		public Car(string ownerName, FuelType fuelType, Colour colour) {
			this.ownerName = ownerName;
			FuelType = fuelType;
			Colour = colour;
			NumberOfCars++;
		}

		public abstract void Drive();
	}
}

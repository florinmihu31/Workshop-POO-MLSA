
public abstract class Car {
    private String ownerName;
    private final FuelType fuelType;
    private Colour colour;
    private static int numberOfCars;

    public Car(String ownerName, FuelType fuelType, Colour colour) {
        this.ownerName = ownerName;
        this.fuelType = fuelType;
        this.colour = colour;
        numberOfCars++;
    }

    public Car() {
        this("", FuelType.GAS, Colour.WHITE);
    }

    public String getOwnerName() {
        return ownerName;
    }

    public void setOwnerName(String ownerName) {
        if(ownerName.length() > 1) {
            this.ownerName = ownerName;
        }
    }

    public FuelType getFuelType() {
        return fuelType;
    }

    public Colour getColour() {
        return colour;
    }

    public void setColour(Colour colour) {
        this.colour = colour;
    }

    public static int getNumberOfCars() {
        return numberOfCars;
    }

    private static void setNumberOfCars(int numberOfCars) {
        Car.numberOfCars = numberOfCars;
    }

    public void getSpecialFeature() {
        System.out.println("I have no special feature.");
    }

    public abstract void drive();
}

public class BMW extends Car{

    private boolean sportModeOn;

    public BMW() {
        super();
    }

    public BMW(String ownerName, FuelType fuelType, Colour colour) {
        super(ownerName, fuelType, colour);
    }

    public boolean isSportModeOn() {
        return sportModeOn;
    }

    public void setSportModeOn(boolean sportModeOn) {
        this.sportModeOn = sportModeOn;
    }

    @Override
    public void getSpecialFeature() {
        System.out.println("I have sports mode.");
    }

    @Override
    public void drive() {
        System.out.println("Driving BMW");
    }
}

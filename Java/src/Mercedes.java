public class Mercedes extends Car {

    public Mercedes() {
        super();
    }

    public Mercedes(String ownerName, FuelType fuelType, Colour colour) {
        super(ownerName, fuelType, colour);
    }

    private boolean drivePilotOn;

    public boolean isDrivePilotOn() {
        return drivePilotOn;
    }

    public void setDrivePilotOn(boolean drivePilotOn) {
        this.drivePilotOn = drivePilotOn;
    }

    @Override
    public void getSpecialFeature() {
        System.out.println("I have drive pilot.");
    }

    @Override
    public void drive() {
        System.out.println("Driving Mercedes");
    }
}

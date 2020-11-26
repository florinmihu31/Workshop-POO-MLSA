public class Main {
    public static void main(String[] args) {
        Car car1 = new Mercedes("Florin", FuelType.DIESEL, Colour.WHITE);
        ((Mercedes) car1).setDrivePilotOn(true);
        System.out.println(car1.getOwnerName());
        System.out.println(car1.getFuelType());
        System.out.println(car1.getColour());
        System.out.println(((Mercedes)car1).isDrivePilotOn());
        car1.getSpecialFeature();
        car1.drive();

        Car car2 = new BMW();
        car2.setOwnerName("Lucian");
        ((BMW)car2).setSportModeOn(true);
        System.out.println(car2.getOwnerName());
        System.out.println(car2.getFuelType());
        System.out.println(car2.getColour());
        System.out.println(((BMW) car2).isSportModeOn());
        car2.getSpecialFeature();
        car2.drive();

        System.out.println(Car.getNumberOfCars());

        IShape circle = new Circle();
        circle.draw();
        IShape square = new Square();
        square.draw();
    }
}

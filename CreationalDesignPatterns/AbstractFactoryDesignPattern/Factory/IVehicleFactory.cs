namespace AbstractFactoryDesignPattern{
    public interface IVehicleFactory
    {
        // In VehicleFactory we create two types of vehicles car and bike
        ICar CreateCar();
        IBike CreateBike();
    }
}
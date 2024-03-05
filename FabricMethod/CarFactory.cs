public class CarFactory : IVehicleFactory
{
    public Vehicle CreateVehicle(string brand, string model, int year, string color)
    {
        return new Car(brand, model, year, color);
    }
}

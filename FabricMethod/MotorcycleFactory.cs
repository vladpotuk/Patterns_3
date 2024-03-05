public class MotorcycleFactory : IVehicleFactory
{
    public Vehicle CreateVehicle(string brand, string model, int year, string color)
    {
        return new Motorcycle(brand, model, year, color);
    }
}

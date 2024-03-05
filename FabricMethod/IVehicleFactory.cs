public interface IVehicleFactory
{
    Vehicle CreateVehicle(string brand, string model, int year, string color);
}

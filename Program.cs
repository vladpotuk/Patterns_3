using System;

class Program
{
    static void Main(string[] args)
    {
        IVehicleFactory carFactory = new CarFactory();
        Vehicle car = carFactory.CreateVehicle("Toyota", "Camry", 2023, "Black");

        IVehicleFactory motorcycleFactory = new MotorcycleFactory();
        Vehicle motorcycle = motorcycleFactory.CreateVehicle("Honda", "CBR", 1000, "Red");

        Console.WriteLine(car.Move());
        Console.WriteLine(car.GetDetails());

        Console.WriteLine(motorcycle.Move());
        Console.WriteLine(motorcycle.GetDetails());
    }
}

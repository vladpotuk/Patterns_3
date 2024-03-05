public abstract class Vehicle
{
    public string Type { get; protected set; }
    public string Brand { get; protected set; }
    public string Model { get; protected set; }
    public int Year { get; protected set; }
    public string Color { get; protected set; }

    public abstract string Move();
    public abstract string GetDetails();
}
